using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;


namespace OpenAntumIDForDotNet
{
    public partial class FrmOpenAntumID : Form
    {

        private string _Internal_NonceCodeToCheck = "";
        private string _AntumID_API_Application_Token = "";

        public FrmOpenAntumID() {
            InitializeComponent();
             _AntumID_API_Application_Token = ""; // Place your API GUID KEY HERE -> Request API Key at support@antumid.be
        }


        private void Internal_Create_OpenAntumID_Authentication() {

            try
            {
                OpenAntumIDSOAP.AntumIDserverPortTypeClient SOAPClient = new OpenAntumIDSOAP.AntumIDserverPortTypeClient();
                OpenAntumIDSOAP.Message SOAPMessage = new OpenAntumIDSOAP.Message();
                SOAPMessage.AuthenticationRequestType = "action_create_auth|MyAppName";
                SOAPMessage.AuthenticationRequestReturnType = "";
                SOAPMessage.AuthenticationRequestReturnFields = "";
                SOAPMessage.AuthenticationRequestGUID = _AntumID_API_Application_Token; // Enter your Open AntumID API KEY Send Request to support@antumid.be 
                SOAPMessage.AuthenticationRequestClientIP = "0.0.0.0";
                SOAPMessage.AuthenticationValidateTokenID = ""; // Empty for create auth.    
                string MyJsonResult = SOAPClient.sendMessage(SOAPMessage);
                System.Web.Script.Serialization.JavaScriptSerializer jsonSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                dynamic dobj = jsonSerializer.Deserialize<dynamic>(MyJsonResult);
                string QrImageURL = dobj["QRIMAGE"].ToString();
                _Internal_NonceCodeToCheck = dobj["NONCE"].ToString();
                this.OpenAntumIDQR.ImageLocation = QrImageURL;

                if (QrImageURL.Length >0 )  {
                    // If OK-> SOAP Checker can be enabled.
                    SOAPTimer.Enabled = true;
                    SOAPTimer.Interval = 3000;
                    SOAPTimer.Tick += SOAPTimer_Tick;
                    SOAPTimer.Start();
                }

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message.ToString());
            }

            

        }

        private void SOAPTimer_Tick(object sender, EventArgs e)
        {


            SOAPTimer.Stop(); // Stop SOAP TIMER

            if (_Internal_NonceCodeToCheck.Length > 0)
            {
                try
                {
                    OpenAntumIDSOAP.AntumIDserverPortTypeClient SOAPClient = new OpenAntumIDSOAP.AntumIDserverPortTypeClient();
                    OpenAntumIDSOAP.Message SOAPMessage = new OpenAntumIDSOAP.Message();
                    SOAPMessage.AuthenticationRequestType = "action_validate_auth|MyFirstApplication"; // Pre-Register AntumID -> DigiID Result = idem of Open AntumID
                    SOAPMessage.AuthenticationRequestReturnFields = "*"; //Get all personal information

                    // SOAPMessage.AuthenticationRequestReturnFields = "FIRSTNAME|"; //Get single item
                    // SOAPMessage.AuthenticationRequestReturnFields = "FIRSTNAME|LASTNAME|"; //Get two or more items

                    // ReturnFields that can be used in this property
                     /*
                     FIRSTNAME
                     LASTNAME
                     BIRTHDAY
                     BIRTHPLACE
                     NATIONALITY
                     ADDRESS
                     CITY
                     POSTAL
                     GENDER
                     AGE
                     LASTUPDATE
                     EIDVALIDFROM
                     EIDVALIDUNTIL
                     EMAIL
                     */


                    SOAPMessage.AuthenticationRequestReturnType = ""; 
                    SOAPMessage.AuthenticationRequestGUID = _AntumID_API_Application_Token;
                    SOAPMessage.AuthenticationRequestClientIP = "0.0.0.0";
                    SOAPMessage.AuthenticationValidateTokenID = _Internal_NonceCodeToCheck;
                    ResponseOpenAntumID MyResponse = new ResponseOpenAntumID();
                    System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(MyResponse.GetType());
                    System.IO.Stream stream = new System.IO.MemoryStream(Encoding.UTF8.GetBytes(SOAPClient.sendMessage(SOAPMessage)));
                    MyResponse = (ResponseOpenAntumID)ser.Deserialize(stream);

                    switch (MyResponse.RESPONSE)
                    {
                        case "":
                            SOAPTimer.Start();
                            break;
                        case "ERR-200":
                            Internal_ShowMyResultDialog(MyResponse);
                            this.Close();
                            break;

                        case "ERR-503":
                            this.Close();
                            break;
                        case "ERR-404":
                            this.Close();
                            break;
                        case "ERR-500":
                            this.Close();
                            break;
                        default:
                            SOAPTimer.Start();
                            break;
                    }

                }

                catch (Exception ex) {
                    System.Diagnostics.Debug.WriteLine(ex.Message.ToString());
                }
            }
            else
            {

            }



        }

        private void Internal_ShowMyResultDialog(ResponseOpenAntumID MyResponse)
        {
            if (MyResponse!=null)
            {
                string MyInformation = "";

                Type myType = MyResponse.GetType();
                IList<System.Reflection.PropertyInfo> props = new List<System.Reflection.PropertyInfo>(myType.GetProperties());
                foreach (System.Reflection.PropertyInfo prop in props)
                {
                    string PropValueToUSe = "";
                    object propValue = prop.GetValue(MyResponse, null);
                    if (propValue != null) { PropValueToUSe = propValue.ToString(); }
                    MyInformation += prop.Name.ToString() + " : " + PropValueToUSe + "\n\r";
                }

                MessageBox.Show("OK, Connected, personal information received from AntumID Service based on * request: " + MyInformation);


            }

        }

        private void FrmOpenAntumID_Shown(object sender, EventArgs e)
        {
            // If Windows is loaded and shown, start request
            Internal_Create_OpenAntumID_Authentication(); // Create request and show QR-code 

        }
    }
}
