Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Xml
Imports System.Net
Imports System.Security.Cryptography.X509Certificates
Imports System.IO
Imports System.Text
Imports Microsoft.Web.Services3
Imports Microsoft.Web.Services3.Messaging
Imports Microsoft.Web.Services3.Addressing
Imports Microsoft.Web.Services3.Security
Imports Microsoft.Web.Services3.Security.Tokens
Imports System.Security.Cryptography
Imports System.Net.Security

Public Class ExchangeRate
    Dim Client As New Calculator1.Service1SoapClient()

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        Try
            If Client.LogIn(TxtClientID.Text, TxtBranchID.Text, TxtTransactionType.Text) = True Then
                DataGridView1.DataSource = Client.getExchangeRate.Tables("MyTable")
            Else
                MessageBox.Show("User login fail.", "login", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub BtnXMLSoapFormat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnXMLSoapFormat.Click
        Dim docXML As XmlDocument = New XmlDocument
        'docXML.Load("C:\getBuyQuote.xml")
        'txtToken.Text = Encrypt(TxtEncryped.Text, "Pas5pr@se", "s@1tValue", "SHA1", 2, "Qm13JGRENWZ4Jmc0NkdRMQ==", 128)
        txtToken.Text = Encrypt(TxtEncryped.Text.Trim, "Bmw$dD5fx&g46GQ1")
        'txtToken.Text = EncryptV1(TxtEncryped.Text.Trim, "Bmw$dD5fx&g46GQ1") 'Encrypt(TxtEncryped.Text, "Qm13JGRENWZ4Jmc0NkdRMQ==")
        Dim soapEnvelope As XmlElement = docXML.CreateElement("soap", "Envelope", "http://schemas.xmlsoap.org/soap/envelope/")
        soapEnvelope.SetAttribute("xmlns:soapenc", "http://schemas.xmlsoap.org/soap/encoding/")
        soapEnvelope.SetAttribute("xmlns:xsd", "http://www.w3.org/2001/XMLSchema")
        soapEnvelope.SetAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance")
        docXML.AppendChild(soapEnvelope)
        Dim soapHeaser As XmlElement = docXML.CreateElement("soap", "Header", docXML.DocumentElement.NamespaceURI)
        docXML.DocumentElement.AppendChild(soapHeaser)
        Dim soapBody As XmlElement = docXML.CreateElement("soap", "Body", docXML.DocumentElement.NamespaceURI)
        docXML.DocumentElement.AppendChild(soapBody)
        Dim soapQuote As XmlElement = docXML.CreateElement("soap", "getBuyQuote", String.Empty)


        Dim strQuote As String = "<msgName>getBuyQuote</msgName> " + _
                        "<ClientID>" & TxtClientID.Text & "</ClientID>" + _
                        "<branchID>" & TxtBranchID.Text & "</branchID>" + _
                        "<tranType>" & TxtTransactionType.Text & "</tranType>" + _
                        "<userID>" & TxtUserID.Text & "</userID>" + _
                        "<currCode>" & TxtCurrencyCode.Text & "</currCode>" + _
                        "<spreadType>" & TxtSpreadType.Text & "</spreadType>" + _
                        "<foreignAmount>" & TxtForeignAmount.Text & "</foreignAmount>" + _
                        "<requestSecToken>" & txtToken.Text & "</requestSecToken>"
        soapQuote.InnerXml = strQuote
        soapQuote.SetAttribute("xmlns", "http://api.ws.ba.com")
        soapBody.AppendChild(soapQuote)
        docXML.Save("C:\getBuyQuote.xml")
        Dim xml As XElement = XElement.Load("C:\getBuyQuote.xml")
        txtXMLFormate.Text = "<?xml version=""1.0"" encoding=""UTF-8""?>" & xml.ToString

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        PostTotal(TxtSOAPURL.Text, txtXMLFormate.Text, TxtSoapAction.Text)
    End Sub
    Function CertificateValidationCallBack( _
        ByVal sender As Object, _
        ByVal certificate As X509Certificate, _
        ByVal chain As X509Chain, _
        ByVal sslPolicyErrors As SslPolicyErrors _
) As Boolean
        Return True
    End Function
    Private Sub PostTotal(ByVal m_URL As String, ByVal m_PostMessage As String, ByVal SoapAction As String)

        Try
            ServicePointManager.Expect100Continue = True
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3
            ServicePointManager.ServerCertificateValidationCallback = New RemoteCertificateValidationCallback(AddressOf CertificateValidationCallBack)
            Dim Req As Net.HttpWebRequest = Net.HttpWebRequest.Create(m_URL)
            Req.Method = "POST"
            Req.ContentType = "text/xml; charset=""utf-8"""
            Req.KeepAlive = False
            Req.ProtocolVersion = HttpVersion.Version10
            If ChCertificate.Checked = True Then
                Dim certs As X509Certificate2 = New X509Certificate2(SslKey.Text, "singpost2013")
                Req.ClientCertificates.Add(certs)
            End If
           
            ' Req.Headers.Add("SOAPAction", "http://tempuri.org/HelloWorld")
            Req.Headers.Add("SOAPAction", SoapAction)


            'Dim KeyStore As X509Store = New X509Store("My", StoreLocation.CurrentUser)
            'Dim Certs As X509CertificateCollection = KeyStore.Certificates.Find(X509FindType.FindBySubjectName, "singpost2013", True)
            'Req.ClientCertificates = Certs
            Dim objStream As New System.IO.StreamWriter(Req.GetRequestStream(), System.Text.Encoding.UTF8)
            'Req.ClientCertificates.Add(System.Security.Cryptography.X509Certificates.X509Certificate.CreateFromCertFile(""))
            objStream.Write(m_PostMessage, 0, m_PostMessage.Length)
            objStream.Close()
            objStream = Nothing

            Dim objHTTPRes As HttpWebResponse = CType(Req.GetResponse(), HttpWebResponse)
            Dim SourceStream As IO.Stream = objHTTPRes.GetResponseStream()
            Dim objXML As New System.Xml.XmlDocument()
            objXML.Load(SourceStream)
            Dim ret As String
            Dim sr As System.IO.StreamReader = New IO.StreamReader(SourceStream)
            ret = sr.ReadToEnd
            objXML.Save("C:\getBuyQuoteRespond.xml")
            Dim xml As XElement = XElement.Load("C:\getBuyQuoteRespond.xml")
            TxtSOAPRespond.Text = xml.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub SignKeyBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''Dim x As New X509Certificate2
        ''x.Import(
        ' ''Dim Cert As X509Certificate = X509Certificate.CreateFromCertFile(Directory.GetCurrentDirectory & “\Adnan.cer”)

        'Dim privateKey As New RSACryptoServiceProvider






        'Dim dlg As New OpenFileDialog
        'Dim res As DialogResult
        'dlg.DefaultExt = ".cer"
        'res = dlg.ShowDialog
        'If res = Windows.Forms.DialogResult.OK And dlg.FileName.Length > 0 Then
        '    SignKey.Text = dlg.FileName
        '    Dim Cert As X509Certificate = X509Certificate.CreateFromCertFile(SignKey.Text)
        '    Dim SerialNumber() As Byte = Cert.GetSerialNumber()
        '    txtToken.Text = Cert.ToString(True)

        'End If

    End Sub

    Private Sub SslKeyBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SslKeyBrowse.Click
        Dim Dlg As New OpenFileDialog
        Dim Res As DialogResult
        Dlg.DefaultExt = ".cer"
        Res = Dlg.ShowDialog()
        If Res = DialogResult.OK And Dlg.FileName.Length > 0 Then
            SslKey.Text = Dlg.FileName
        End If

    End Sub

    Private Sub ExchangeRate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Function GetRijndaelManaged(ByVal secretKey As String) As RijndaelManaged
        'Dim keyBytes = New Byte(16)
        Dim keyBytes() As Byte = New Byte(15) {}
        Dim secretKeyBytes = Encoding.UTF8.GetBytes(secretKey)
        Array.Copy(secretKeyBytes, keyBytes, Math.Min(keyBytes.Length, secretKeyBytes.Length))
        Dim riJ As New RijndaelManaged
        With riJ
            .Mode = CipherMode.ECB
            .Padding = PaddingMode.PKCS7
            .KeySize = 128
            .BlockSize = 128
            .Key = keyBytes
            .IV = keyBytes
        End With
        Return riJ
    End Function

    Function Encrpt(ByVal plainByte() As Byte, ByVal rijndaelManaged As RijndaelManaged) As Byte()
        'Return rijndaelManaged.CreateEncryptor()
        '        .TransformFinalBlock(plainBytes, 0, plainBytes.Length);
        Return rijndaelManaged.CreateEncryptor().TransformFinalBlock(plainByte, 0, plainByte.Length)
    End Function
    Function Encrypt(ByVal plainText As String, ByVal key As String) As String
        Dim plainBytes = Encoding.UTF8.GetBytes(plainText)
        Return Convert.ToBase64String(Encrpt(plainBytes, GetRijndaelManaged(key)))
    End Function
    Function EncryptV1(ByVal Input As String, ByVal Key As String) As String
        Dim inputArray() As Byte = UTF8Encoding.UTF8.GetBytes(Input)

        Dim tripleDES As New TripleDESCryptoServiceProvider
        tripleDES.Key = UTF8Encoding.UTF8.GetBytes(Key)
        tripleDES.Mode = CipherMode.ECB
        tripleDES.Padding = PaddingMode.PKCS7
        Dim cTransform As ICryptoTransform = tripleDES.CreateEncryptor
        Dim ResultArray() As Byte = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length)
        tripleDES.Clear()
        Return Convert.ToBase64String(ResultArray, 0, ResultArray.Length)
    End Function


    'Public Function Encrypt(ByVal plainText As String, _
    '                                ByVal passPhrase As String, _
    '                                ByVal saltValue As String, _
    '                                ByVal hashAlgorithm As String, _
    '                                ByVal passwordIterations As Integer, _
    '                                ByVal initVector As String, _
    '                                ByVal keySize As Integer) _
    '                        As String

    '    ' Convert strings into byte arrays.
    '    ' Let us assume that strings only contain ASCII codes.
    '    ' If strings include Unicode characters, use Unicode, UTF7, or UTF8 
    '    ' encoding.
    '    Dim initVectorBytes As Byte()
    '    initVectorBytes = Encoding.ASCII.GetBytes(initVector)

    '    Dim saltValueBytes As Byte()
    '    saltValueBytes = Encoding.ASCII.GetBytes(saltValue)

    '    ' Convert our plaintext into a byte array.
    '    ' Let us assume that plaintext contains UTF8-encoded characters.
    '    Dim plainTextBytes As Byte()
    '    plainTextBytes = Encoding.UTF8.GetBytes(plainText)

    '    ' First, we must create a password, from which the key will be derived.
    '    ' This password will be generated from the specified passphrase and 
    '    ' salt value. The password will be created using the specified hash 
    '    ' algorithm. Password creation can be done in several iterations.
    '    Dim password As PasswordDeriveBytes
    '    password = New PasswordDeriveBytes(passPhrase, _
    '                                       saltValueBytes, _
    '                                       hashAlgorithm, _
    '                                       passwordIterations)

    '    ' Use the password to generate pseudo-random bytes for the encryption
    '    ' key. Specify the size of the key in bytes (instead of bits).
    '    Dim keyBytes As Byte()
    '    keyBytes = password.GetBytes(keySize / 8)

    '    ' Create uninitialized Rijndael encryption object.
    '    Dim symmetricKey As RijndaelManaged
    '    symmetricKey = New RijndaelManaged()

    '    ' It is reasonable to set encryption mode to Cipher Block Chaining
    '    ' (CBC). Use default options for other symmetric key parameters.
    '    symmetricKey.Mode = CipherMode.CBC

    '    ' Generate encryptor from the existing key bytes and initialization 
    '    ' vector. Key size will be defined based on the number of the key 
    '    ' bytes.
    '    Dim encryptor As ICryptoTransform
    '    encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes)

    '    ' Define memory stream which will be used to hold encrypted data.
    '    Dim memoryStream As MemoryStream
    '    memoryStream = New MemoryStream()

    '    ' Define cryptographic stream (always use Write mode for encryption).
    '    Dim cryptoStream As CryptoStream
    '    cryptoStream = New CryptoStream(memoryStream, _
    '                                    encryptor, _
    '                                    CryptoStreamMode.Write)
    '    ' Start encrypting.
    '    cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length)

    '    ' Finish encrypting.
    '    cryptoStream.FlushFinalBlock()

    '    ' Convert our encrypted data from a memory stream into a byte array.
    '    Dim cipherTextBytes As Byte()
    '    cipherTextBytes = memoryStream.ToArray()

    '    ' Close both streams.
    '    memoryStream.Close()
    '    cryptoStream.Close()

    '    ' Convert encrypted data into a base64-encoded string.
    '    Dim cipherText As String
    '    cipherText = Convert.ToBase64String(cipherTextBytes)

    '    ' Return encrypted string.
    '    Encrypt = cipherText
    'End Function

End Class