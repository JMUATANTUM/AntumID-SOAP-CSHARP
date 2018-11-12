# AntumID-SOAP-CSHARP
A SOAP based version of AntumID (DigiByte DigiID) For C# .NET with ID information (**Windows Desktop APP example**)

**AntumID SOAP Authentication Protocol with identification information**

Easily integrate the AntumID SOAP into Windows Applications with identification information. AntumID has an API available that does not require a digiid library, pure blockchain login without any problems.

Demo for this AntumID SOAP for .NET (C#)
=============================================
To use this demo you have to pre-register your AntumID. 
Using this source code with the API KEY you can try the demo.

Installation
============
* Copy source code into your C# project and add web-reference to the AntumID SOAP WSDL file ( https://www.antumid.be/services-digibyte/api/v1/messageService.wsdl )
* Property AuthenticationRequestReturnFields can be used to set the return fields (use * for all fields)
* Example 1 Get single item: SOAPMessage.AuthenticationRequestReturnFields = "FIRSTNAME|";
* Example 2 Get two or more items: SOAPMessage.AuthenticationRequestReturnFields = "FIRSTNAME|LASTNAME|"; 
* Example 3 Get all values: SOAPMessage.AuthenticationRequestReturnFields = "*";
* Aks for your AntumID SOAP Token-key to use this within your project, request for token GUID key at support@antumid.be 

Notes
=====



License
=======
The MIT License (MIT)

Copyright (c) 2018 Antum

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
