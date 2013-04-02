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
Imports System.Xml.XPath
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
                        "<requestSecToken>" & Encrypt(TxtPlandTextGetBuyQuot.Text.Trim, "Bmw$dD5fx&g46GQ1") & "</requestSecToken>"
        soapQuote.InnerXml = strQuote
        soapQuote.SetAttribute("xmlns", "http://api.ws.ba.com")
        soapBody.AppendChild(soapQuote)
        docXML.Save(Application.StartupPath & "\Log\Request\getBuyQuote.xml")
        Dim xml As XElement = XElement.Load(Application.StartupPath & "\Log\Request\getBuyQuote.xml")
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
        Dim soapQuote As XmlElement = docXML.CreateElement("soap", "getSellQuote", String.Empty)
        Dim strQuote As String = "<msgName>getSellQuote</msgName>" + _
                        "<ClientID>" & TxtClientID.Text & "</ClientID>" + _
                        "<branchID>" & TxtBranchID.Text & "</branchID>" + _
                        "<tranType>" & TxtTransactionType.Text & "</tranType>" + _
                        "<userID>" & TxtUserID.Text & "</userID>" + _
                        "<currCode>" & TxtCurrencyCode.Text & "</currCode>" + _
                        "<spreadType>" & TxtSpreadType.Text & "</spreadType>" + _
                        "<foreignAmount>" & TxtForeignAmountSell.Text & "</foreignAmount>" + _
                        "<localAmount>" & TxtLocalAmount.Text & "</localAmount>" + _
                        "<denominationMix>" & TxtDenomination.Text & "</denominationMix>" + _
                        "<requestSecToken>" & Encrypt(TxtPlanTextOfGetSell.Text.Trim, "Bmw$dD5fx&g46GQ1") & "</requestSecToken>"
        soapQuote.InnerXml = strQuote
        soapQuote.SetAttribute("xmlns", "http://api.ws.ba.com")
        soapBody.AppendChild(soapQuote)
        docXML.Save(Application.StartupPath & "\Log\Request\getSellQuote.xml")
        Dim xml As XElement = XElement.Load(Application.StartupPath & "\Log\Request\getSellQuote.xml")
        Return "<?xml version=""1.0"" encoding=""UTF-8""?>" & xml.ToString
    End Function
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim I As Int16 = 0
        For Each dRow As DataRow In TblXMLSOAPClient.Rows
            I = I + 1
            PostTotal(TxtSOAPURL.Text, dRow("XMLGetBuyQuate").ToString.Trim, Application.StartupPath & "\Log\Responds\getBuyQuoteRespond" & I & ".XML")
            PostTotal(TxtSOAPURL.Text, dRow("XMLGetSellQuate"), Application.StartupPath & "\Log\Responds\getSellQuoteRespond" & I & ".XML")
            MsgBox(GetValueLocalAmount(Application.StartupPath & "\Log\Responds\getBuyQuoteRespond" & I & ".XML") & " : Value of  Sell " & GetValueLocalAmount(Application.StartupPath & "\Log\Responds\getSellQuoteRespond" & I & ".XML"))
        Next

    End Sub
    Function CertificateValidationCallBack( _
        ByVal sender As Object, _
        ByVal certificate As X509Certificate, _
        ByVal chain As X509Chain, _
        ByVal sslPolicyErrors As SslPolicyErrors _
) As Boolean
        Return True
    End Function
    Private Sub PostTotal(ByVal m_URL As String, ByVal m_PostMessage As String, ByVal FileName As String)

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
            Req.Headers.Add("SOAPAction", "")



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
            objXML.Save(FileName)
            Dim xml As XElement = XElement.Load(FileName)
            TxtSOAPRespond.Text = xml.ToString
            sr.Close()
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
        TxtPlandTextGetBuyQuot.Text = GenerateKeyToken("getBuyQuote", TxtClientID.Text, TxtBranchID.Text, TxtUserID.Text)
        TxtPlanTextOfGetSell.Text = GenerateKeyToken("getSellQuote", TxtClientID.Text, TxtBranchID.Text, TxtUserID.Text)
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

    Private Sub BtnSubRequest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSubRequest.Click
        TblXMLSOAPClient.Rows(0).Delete()
        TblXMLSOAPClient.AcceptChanges()
    End Sub
    Public Function GenerateKeyToken(ByVal QuotFunction As String, ByVal ClientID As String, ByVal BranchID As String, ByVal UserID As String) As String
        Dim XMLString As String
        XMLString = "<token> " & vbCrLf & _
                        "<timestamp>" & Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.fff'GMT'") & "</timestamp>" & vbCrLf & _
                        "<msgName>" & QuotFunction & "</msgName>" & vbCrLf & _
                        "<clientID>" & ClientID & "</clientID>" & vbCrLf & _
                        "<branchID>" & BranchID & "</branchID>" & vbCrLf & _
                        "<userID>" & UserID & "</userID>" & vbCrLf & _
                        "<randomStr>AyeH7i61Kd</randomStr>" & vbCrLf & _
                    "</token>"
        Return XMLString
    End Function

    Private Sub TxtClientID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtClientID.TextChanged
        TxtPlandTextGetBuyQuot.Text = GenerateKeyToken("getBuyQuote", TxtClientID.Text, TxtBranchID.Text, TxtUserID.Text)
        TxtPlanTextOfGetSell.Text = GenerateKeyToken("getSellQuote", TxtClientID.Text, TxtBranchID.Text, TxtUserID.Text)
    End Sub

    Private Sub TxtBranchID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBranchID.TextChanged
        TxtPlandTextGetBuyQuot.Text = GenerateKeyToken("getBuyQuote", TxtClientID.Text, TxtBranchID.Text, TxtUserID.Text)
        TxtPlanTextOfGetSell.Text = GenerateKeyToken("getSellQuote", TxtClientID.Text, TxtBranchID.Text, TxtUserID.Text)
    End Sub

    Private Sub TxtUserID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtUserID.TextChanged
        TxtPlandTextGetBuyQuot.Text = GenerateKeyToken("getBuyQuote", TxtClientID.Text, TxtBranchID.Text, TxtUserID.Text)
        TxtPlanTextOfGetSell.Text = GenerateKeyToken("getSellQuote", TxtClientID.Text, TxtBranchID.Text, TxtUserID.Text)
    End Sub

   
    Function GetValueLocalAmount(ByVal XmlPartRespons As String) As String
        Using reader As XmlReader = XmlReader.Create(XmlPartRespons)
            While reader.Read
                If reader.IsStartElement Then
                    '  MessageBox.Show("Start Elelem")
                    If reader.Name = "p88:msgResult" Then
                        If reader.Read Then
                            If reader.Value.Trim = "Ok" Then
                                While reader.Read
                                    If reader.Name = "p88:localAmount" Then
                                        If reader.Read Then
                                            ' MessageBox.Show("Text Node: {0}" & reader.Value.Trim)
                                            Return reader.Value.Trim
                                        End If
                                    End If
                                End While
                               
                            End If
                            If reader.Value.Trim = "Fail" Then
                                Return "N.A"
                            End If
                        End If
                    End If

                End If
            End While
            reader.Close()
        End Using
    End Function
End Class