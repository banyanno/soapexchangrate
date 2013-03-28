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

    Dim TblXMLSOAPClient As DataTable = New DS_Helper.ClientRequestSOAPDataTable
    Private Sub BtnAddRequest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddRequest.Click
        Dim DRow As DataRow = TblXMLSOAPClient.NewRow
        DRow.Item("BrandID") = TxtBranchID.Text
        DRow.Item("UserID") = TxtUserID.Text
        DRow.Item("CurrencyCode") = TxtCurrencyCode.Text
        DRow.Item("ForeigAmount") = TxtForeignAmount.Text
        DRow.Item("LocalAmount") = TxtLocalAmount.Text
        DRow.Item("Denomination") = TxtDenomination.Text
        DRow.Item("XMLGetBuyQuate") = GetXMLSoapGetBuyQuat().Trim
        DRow.Item("XMLGetSellQuate") = GeneratXMLSoapGetSellQuat().Trim
        TblXMLSOAPClient.Rows.Add(DRow)
        GridClientEnvelopeRequest.DataSource = TblXMLSOAPClient
        ClearData()
    End Sub
    Private Sub ClearData()
        TxtCurrencyCode.Text = ""
        TxtForeignAmount.Text = ""
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

   
    Function GetXMLSoapGetBuyQuat() As String
        Dim docXML As XmlDocument = New XmlDocument
        'docXML.Load("C:\getBuyQuote.xml")
        'txtToken.Text = Encrypt(TxtEncryped.Text, "Pas5pr@se", "s@1tValue", "SHA1", 2, "Qm13JGRENWZ4Jmc0NkdRMQ==", 128)

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
        Dim strQuote As String = "<msgName>getBuyQuote</msgName>" + _
                        "<ClientID>" & TxtClientID.Text & "</ClientID>" + _
                        "<branchID>" & TxtBranchID.Text & "</branchID>" + _
                        "<tranType>" & TxtTransactionType.Text & "</tranType>" + _
                        "<userID>" & TxtUserID.Text & "</userID>" + _
                        "<currCode>" & TxtCurrencyCode.Text & "</currCode>" + _
                        "<spreadType>" & TxtSpreadType.Text & "</spreadType>" + _
                        "<foreignAmount>" & TxtForeignAmount.Text & "</foreignAmount>" + _
                        "<requestSecToken>" & Encrypt(TxtPlandText.Text.Trim, "Bmw$dD5fx&g46GQ1") & "</requestSecToken>"
        soapQuote.InnerXml = strQuote
        soapQuote.SetAttribute("xmlns", "http://api.ws.ba.com")
        soapBody.AppendChild(soapQuote)
        docXML.Save("C:\getBuyQuote.xml")
        Dim xml As XElement = XElement.Load("C:\getBuyQuote.xml")
        Return "<?xml version=""1.0"" encoding=""UTF-8""?>" & xml.ToString
    End Function
    Function GeneratXMLSoapGetSellQuat() As String
        Dim docXML As XmlDocument = New XmlDocument
        'docXML.Load("C:\getBuyQuote.xml")
        'txtToken.Text = Encrypt(TxtEncryped.Text, "Pas5pr@se", "s@1tValue", "SHA1", 2, "Qm13JGRENWZ4Jmc0NkdRMQ==", 128)


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
        Dim strQuote As String = "<msgName>getBuyQuote</msgName>" + _
                        "<ClientID>" & TxtClientID.Text & "</ClientID>" + _
                        "<branchID>" & TxtBranchID.Text & "</branchID>" + _
                        "<tranType>" & TxtTransactionType.Text & "</tranType>" + _
                        "<userID>" & TxtUserID.Text & "</userID>" + _
                        "<currCode>" & TxtCurrencyCode.Text & "</currCode>" + _
                        "<spreadType>" & TxtSpreadType.Text & "</spreadType>" + _
                        "<foreignAmount>" & TxtForeignAmount.Text & "</foreignAmount>" + _
                        "<localAmount>" & TxtLocalAmount.Text & "</localAmount>" + _
                        "<denominationMix>" & TxtDenomination.Text & "</denominationMix>" + _
                        "<requestSecToken>" & Encrypt(TxtPlandText.Text.Trim, "Bmw$dD5fx&g46GQ1") & "</requestSecToken>"
        soapQuote.InnerXml = strQuote
        soapQuote.SetAttribute("xmlns", "http://api.ws.ba.com")
        soapBody.AppendChild(soapQuote)
        docXML.Save("C:\getSellQuote.xml")
        Dim xml As XElement = XElement.Load("C:\getSellQuote.xml")
        Return "<?xml version=""1.0"" encoding=""UTF-8""?>" & xml.ToString
    End Function
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'PostTotal(TxtSOAPURL.Text, txtXMLFormate.Text, TxtSoapAction.Text)
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


         
            Dim objStream As New System.IO.StreamWriter(Req.GetRequestStream(), System.Text.Encoding.UTF8)
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
        Return rijndaelManaged.CreateEncryptor().TransformFinalBlock(plainByte, 0, plainByte.Length)
    End Function
    Function Encrypt(ByVal plainText As String, ByVal key As String) As String
        Dim plainBytes = Encoding.UTF8.GetBytes(plainText)
        Return Convert.ToBase64String(Encrpt(plainBytes, GetRijndaelManaged(key)))
    End Function
End Class