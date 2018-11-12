namespace OpenAntumIDForDotNet
{
    partial class FrmOpenAntumID
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOpenAntumID));
            this.OpenAntumIDQR = new System.Windows.Forms.PictureBox();
            this.SOAPTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.OpenAntumIDQR)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenAntumIDQR
            // 
            this.OpenAntumIDQR.Location = new System.Drawing.Point(75, 21);
            this.OpenAntumIDQR.Name = "OpenAntumIDQR";
            this.OpenAntumIDQR.Size = new System.Drawing.Size(314, 311);
            this.OpenAntumIDQR.TabIndex = 0;
            this.OpenAntumIDQR.TabStop = false;
            // 
            // SOAPTimer
            // 
            this.SOAPTimer.Interval = 3000;
            // 
            // FrmOpenAntumID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(440, 344);
            this.Controls.Add(this.OpenAntumIDQR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOpenAntumID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Full AntumID SOAP - Autthentication Sample";
            this.Shown += new System.EventHandler(this.FrmOpenAntumID_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.OpenAntumIDQR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox OpenAntumIDQR;
        private System.Windows.Forms.Timer SOAPTimer;
    }
}

