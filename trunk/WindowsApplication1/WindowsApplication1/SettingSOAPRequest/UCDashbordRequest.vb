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

Public Class UCDashbordRequest
    Dim DA_RATE_SETTING As New DS_HelperTableAdapters.REQUEST_SETTINGTableAdapter

    Private Sub LoadSetting()
        GridSOAPRequstSetting.DataSource = DA_RATE_SETTING.GetData
    End Sub

    Private Sub UCDashbordRequest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadSetting()
        TimerSending.Start()
    End Sub

    Private Sub TimerSending_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerSending.Tick
        'Try
        BackgroundWorker1.RunWorkerAsync()
        'Catch ex As Exception

        'End Try

    End Sub

    Function GetXMLSoapGetBuyQuat(ByVal ClientID As String, ByVal BranchID As String, ByVal TransactionType As String, ByVal UserID As String, ByVal CurrencyCode As String, ByVal SpreadType As String, ByVal ForeignAmount As String, ByVal TokeyKey As String) As String
        Dim docXML As XmlDocument = New XmlDocument
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
                        "<ClientID>" & ClientID & "</ClientID>" + _
                        "<branchID>" & BranchID & "</branchID>" + _
                        "<tranType>" & TransactionType & "</tranType>" + _
                        "<userID>" & UserID & "</userID>" + _
                        "<currCode>" & CurrencyCode & "</currCode>" + _
                        "<spreadType>" & SpreadType & "</spreadType>" + _
                        "<foreignAmount>" & ForeignAmount & "</foreignAmount>" + _
                        "<requestSecToken>" & TokeyKey & "</requestSecToken>" 'Encrypt(TxtPlandTextGetBuyQuot.Text.Trim, "Bmw$dD5fx&g46GQ1") & "</requestSecToken>"
        soapQuote.InnerXml = strQuote
        soapQuote.SetAttribute("xmlns", "http://api.ws.ba.com")
        soapBody.AppendChild(soapQuote)
        docXML.Save(Application.StartupPath & "\Log\Request\getBuyQuote.xml")
        Dim xml As XElement = XElement.Load(Application.StartupPath & "\Log\Request\getBuyQuote.xml")
        Return "<?xml version=""1.0"" encoding=""UTF-8""?>" & xml.ToString
    End Function

    Function GeneratXMLSoapGetSellQuat(ByVal ClientID As String, ByVal BrandID As String, ByVal TransactionType As String, ByVal UserID As String, ByVal CurrencyCode As String, ByVal SpreadType As String, ByVal ForeignAmountSell As String, ByVal LocalAmount As String, ByVal Denomination As String, ByVal Key As String)
        Dim docXML As XmlDocument = New XmlDocument
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
                        "<ClientID>" & ClientID & "</ClientID>" + _
                        "<branchID>" & BrandID & "</branchID>" + _
                        "<tranType>" & TransactionType & "</tranType>" + _
                        "<userID>" & UserID & "</userID>" + _
                        "<currCode>" & CurrencyCode & "</currCode>" + _
                        "<spreadType>" & SpreadType & "</spreadType>" + _
                        "<foreignAmount>" & ForeignAmountSell & "</foreignAmount>" + _
                        "<localAmount>" & LocalAmount & "</localAmount>" + _
                        "<denominationMix>" & Denomination & "</denominationMix>" + _
                        "<requestSecToken>" & Key & "</requestSecToken>" 'Encrypt(TxtPlanTextOfGetSell.Text.Trim, "Bmw$dD5fx&g46GQ1") & "</requestSecToken>"
        soapQuote.InnerXml = strQuote
        soapQuote.SetAttribute("xmlns", "http://api.ws.ba.com")
        soapBody.AppendChild(soapQuote)
        docXML.Save(Application.StartupPath & "\Log\Request\getSellQuote.xml")
        Dim xml As XElement = XElement.Load(Application.StartupPath & "\Log\Request\getSellQuote.xml")
        Return "<?xml version=""1.0"" encoding=""UTF-8""?>" & xml.ToString
    End Function
    ''' <summary>
    ''' ''''''''''''''''''
    ''' </summary>
    ''' <remarks></remarks>
    Sub SendingRequest()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf SendingRequest))
        Else
            MainApplicationForm.StatusLoading(True)
            TxtResult.Text = ""
            Application.DoEvents()
            Dim Dtbl As DataTable = DA_RATE_SETTING.GetData

            Dim I As Integer = 0
            Dim ArrValue(Dtbl.Rows.Count) As String
            Dim fileName As String = Application.StartupPath & "\Log\Result\Result.txt"
            Dim objWriter As New System.IO.StreamWriter(fileName)

            For Each drow As DataRow In Dtbl.Rows
                I = I + 1
                Application.DoEvents()
                '''' Create Key and Value befor send
                Dim KeyBuy As String = GenerateKeyToken("getBuyQuote", drow("CLIENT_ID"), drow("BRANCH_ID"), drow("USER_ID"))
                Dim KeySell As String = GenerateKeyToken("getSellQuote", drow("CLIENT_ID"), drow("BRANCH_ID"), drow("USER_ID"))
                Dim ValueOfBuy As String = GetXMLSoapGetBuyQuat(drow("CLIENT_ID"), drow("BRANCH_ID"), drow("TRANSACTION_TYPE"), drow("USER_ID"), drow("CURRENCY_CODE"), drow("SPREAD_TYPE"), drow("FOREIGN_AMOUNT"), Encrypt(KeyBuy.Trim, "Bmw$dD5fx&g46GQ1"))
                Dim ValueOfSell As String = GeneratXMLSoapGetSellQuat(drow("CLIENT_ID"), drow("BRANCH_ID"), drow("TRANSACTION_TYPE"), drow("USER_ID"), drow("CURRENCY_CODE"), drow("SPREAD_TYPE"), drow("FOREIGN_AMOUNT_SELL"), drow("LOCAL_AMOUNT"), drow("DENOMINATION"), Encrypt(KeySell.Trim, "Bmw$dD5fx&g46GQ1"))

                'Do send Message
                PostTotal("https://api.globalforeigncurrency.com:443/demo-api/services/QuoteGenerator", ValueOfBuy, Application.StartupPath & "\Log\Responds\getBuyQuoteRespond" & I & ".XML", drow("PATH_CERTIFICATE"))
                PostTotal("https://api.globalforeigncurrency.com:443/demo-api/services/QuoteGenerator", ValueOfSell, Application.StartupPath & "\Log\Responds\getSellQuoteRespond" & I & ".XML", drow("PATH_CERTIFICATE"))

                'Write result to text file
                'ArrValue(I - 1) = drow("IMG_MESSAGE") & "," & drow("CURRENCY_LABEL") & "," & drow("CURRENCY_CODE") & "," & GetValueLocalAmount(Application.StartupPath & "\Log\Responds\getBuyQuoteRespond" & I & ".XML") & "," & GetValueLocalAmount(Application.StartupPath & "\Log\Responds\getSellQuoteRespond" & I & ".XML")
                'objWriter.WriteLine(ArrValue(I - 1))
                'Try
                '    Dim sr As StreamReader = New StreamReader(Application.StartupPath & "\Log\Result\Result.txt")
                '    TxtResult.Text = sr.ReadToEnd
                '    sr.Close()
                'Catch ex As Exception
                '    MessageBox.Show(ex.Message)
                'End Try
            Next
            objWriter.Close()
        End If

    End Sub
    Function GetValueLocalAmount(ByVal XmlPartRespons As String) As String
        Dim StrValue As String = ""
        Try
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
                                                StrValue = reader.Value.Trim
                                            End If
                                        End If
                                    End While

                                End If
                                If reader.Value.Trim = "Fail" Then
                                    StrValue = "N.A"
                                End If
                            End If
                        End If

                    End If
                End While
                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        
        Return StrValue
    End Function
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


    Function Encrypt(ByVal plainText As String, ByVal key As String) As String
        Dim plainBytes = Encoding.UTF8.GetBytes(plainText)
        Return Convert.ToBase64String(Encrpt(plainBytes, GetRijndaelManaged(key)))
    End Function
    Function Encrpt(ByVal plainByte() As Byte, ByVal rijndaelManaged As RijndaelManaged) As Byte()
        Return rijndaelManaged.CreateEncryptor().TransformFinalBlock(plainByte, 0, plainByte.Length)
    End Function

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

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        MainApplicationForm.StatusLoading(False)
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        SendingRequest()
    End Sub


    Private Sub PostTotal(ByVal m_URL As String, ByVal m_PostMessage As String, ByVal FileName As String, ByVal KeyPath As String)

        'Try
        ServicePointManager.Expect100Continue = True
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3
        ServicePointManager.ServerCertificateValidationCallback = New RemoteCertificateValidationCallback(AddressOf CertificateValidationCallBack)

        Dim Req As Net.HttpWebRequest = Net.HttpWebRequest.Create(m_URL)
        Req.Method = "POST"
        Req.ContentType = "text/xml; charset=""utf-8"""
        Req.KeepAlive = False
        Req.ProtocolVersion = HttpVersion.Version10
        'If ChCertificate.Checked = True Then
        Dim certs As X509Certificate2 = New X509Certificate2(KeyPath, "singpost2013")
        Req.ClientCertificates.Add(certs)
        'End If

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
        'TxtSOAPRespond.Text = xml.ToString
        sr.Close()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub
    Function CertificateValidationCallBack( _
    ByVal sender As Object, _
    ByVal certificate As X509Certificate, _
    ByVal chain As X509Chain, _
    ByVal sslPolicyErrors As SslPolicyErrors _
) As Boolean
        Return True
    End Function
End Class
