Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Microsoft.Web.Services3
Imports Microsoft.Web.Services3.Messaging
Imports Microsoft.Web.Services3.Addressing
Imports System.Xml
Imports System.Xml.Serialization
Imports System.IO
Public Class ClassSoapClient
    Inherits SoapClient
    Dim soapAction As String
    Dim webMethodName As String
    Sub New(ByVal soapAction As String, ByVal ref1 As EndpointReference)
        Me.soapAction = soapAction
    End Sub
    'public SoapEnvelope SendEnvelope(XmlDocument xmlDoc)
    '    {
    '        SoapEnvelope soapRequest = new SoapEnvelope();
    '        soapRequest.CreateBody();

    '        soapRequest.Body.AppendChild(soapRequest.ImportNode(xmlDoc.DocumentElement, true));
    '        return base.SendRequestResponse(soapAction, soapRequest);
    '    }
    Public Function SendEnvelope(ByVal XmlDoc As XmlDocument) As SoapEnvelope
        Dim soapRequest As New SoapEnvelope
        soapRequest.CreateBody()
        soapRequest.Body.AppendChild(soapRequest.ImportNode(XmlDoc.DocumentElement, True))
        Return SendRequestResponse(soapAction, soapRequest)
    End Function

End Class
