﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.4927
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System.Data

Namespace Calculator1
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="Calculator1.Service1Soap")>  _
    Public Interface Service1Soap
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/HelloWorld", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute()>  _
        Function HelloWorld() As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Add", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute()>  _
        Function Add(ByVal x As Short, ByVal y As Short) As Integer
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Subtract", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute()>  _
        Function Subtract(ByVal x As Integer, ByVal y As Integer) As Integer
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Multiply", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute()>  _
        Function Multiply(ByVal x As Integer, ByVal y As Integer) As Integer
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Division", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute()>  _
        Function Division(ByVal x As Integer, ByVal y As Integer) As Integer
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/LogIn", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute()>  _
        Function LogIn(ByVal userName As String, ByVal pwd As String, ByVal Key As String) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/getExchangeRate", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute()>  _
        Function getExchangeRate() As System.Data.DataSet
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")>  _
    Public Interface Service1SoapChannel
        Inherits Calculator1.Service1Soap, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")>  _
    Partial Public Class Service1SoapClient
        Inherits System.ServiceModel.ClientBase(Of Calculator1.Service1Soap)
        Implements Calculator1.Service1Soap
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function HelloWorld() As String Implements Calculator1.Service1Soap.HelloWorld
            Return MyBase.Channel.HelloWorld
        End Function
        
        Public Function Add(ByVal x As Short, ByVal y As Short) As Integer Implements Calculator1.Service1Soap.Add
            Return MyBase.Channel.Add(x, y)
        End Function
        
        Public Function Subtract(ByVal x As Integer, ByVal y As Integer) As Integer Implements Calculator1.Service1Soap.Subtract
            Return MyBase.Channel.Subtract(x, y)
        End Function
        
        Public Function Multiply(ByVal x As Integer, ByVal y As Integer) As Integer Implements Calculator1.Service1Soap.Multiply
            Return MyBase.Channel.Multiply(x, y)
        End Function
        
        Public Function Division(ByVal x As Integer, ByVal y As Integer) As Integer Implements Calculator1.Service1Soap.Division
            Return MyBase.Channel.Division(x, y)
        End Function
        
        Public Function LogIn(ByVal userName As String, ByVal pwd As String, ByVal Key As String) As Boolean Implements Calculator1.Service1Soap.LogIn
            Return MyBase.Channel.LogIn(userName, pwd, Key)
        End Function
        
        Public Function getExchangeRate() As System.Data.DataSet Implements Calculator1.Service1Soap.getExchangeRate
            Return MyBase.Channel.getExchangeRate
        End Function
    End Class
End Namespace
