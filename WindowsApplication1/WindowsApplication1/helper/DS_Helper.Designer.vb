﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.4927
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On



'''<summary>
'''Represents a strongly typed in-memory cache of data.
'''</summary>
<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"),  _
 Global.System.Serializable(),  _
 Global.System.ComponentModel.DesignerCategoryAttribute("code"),  _
 Global.System.ComponentModel.ToolboxItem(true),  _
 Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema"),  _
 Global.System.Xml.Serialization.XmlRootAttribute("DS_Helper"),  _
 Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")>  _
Partial Public Class DS_Helper
    Inherits Global.System.Data.DataSet
    
    Private tableClientRequestSOAP As ClientRequestSOAPDataTable
    
    Private _schemaSerializationMode As Global.System.Data.SchemaSerializationMode = Global.System.Data.SchemaSerializationMode.IncludeSchema
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Sub New()
        MyBase.New
        Me.BeginInit
        Me.InitClass
        Dim schemaChangedHandler As Global.System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler MyBase.Tables.CollectionChanged, schemaChangedHandler
        AddHandler MyBase.Relations.CollectionChanged, schemaChangedHandler
        Me.EndInit
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
        MyBase.New(info, context, false)
        If (Me.IsBinarySerialized(info, context) = true) Then
            Me.InitVars(false)
            Dim schemaChangedHandler1 As Global.System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
            AddHandler Me.Tables.CollectionChanged, schemaChangedHandler1
            AddHandler Me.Relations.CollectionChanged, schemaChangedHandler1
            Return
        End If
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(String)),String)
        If (Me.DetermineSchemaSerializationMode(info, context) = Global.System.Data.SchemaSerializationMode.IncludeSchema) Then
            Dim ds As Global.System.Data.DataSet = New Global.System.Data.DataSet
            ds.ReadXmlSchema(New Global.System.Xml.XmlTextReader(New Global.System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("ClientRequestSOAP")) Is Nothing) Then
                MyBase.Tables.Add(New ClientRequestSOAPDataTable(ds.Tables("ClientRequestSOAP")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, Global.System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.ReadXmlSchema(New Global.System.Xml.XmlTextReader(New Global.System.IO.StringReader(strSchema)))
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As Global.System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler MyBase.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.ComponentModel.Browsable(false),  _
     Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property ClientRequestSOAP() As ClientRequestSOAPDataTable
        Get
            Return Me.tableClientRequestSOAP
        End Get
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.ComponentModel.BrowsableAttribute(true),  _
     Global.System.ComponentModel.DesignerSerializationVisibilityAttribute(Global.System.ComponentModel.DesignerSerializationVisibility.Visible)>  _
    Public Overrides Property SchemaSerializationMode() As Global.System.Data.SchemaSerializationMode
        Get
            Return Me._schemaSerializationMode
        End Get
        Set
            Me._schemaSerializationMode = value
        End Set
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.ComponentModel.DesignerSerializationVisibilityAttribute(Global.System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
    Public Shadows ReadOnly Property Tables() As Global.System.Data.DataTableCollection
        Get
            Return MyBase.Tables
        End Get
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.ComponentModel.DesignerSerializationVisibilityAttribute(Global.System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
    Public Shadows ReadOnly Property Relations() As Global.System.Data.DataRelationCollection
        Get
            Return MyBase.Relations
        End Get
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Sub InitializeDerivedDataSet()
        Me.BeginInit
        Me.InitClass
        Me.EndInit
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Overrides Function Clone() As Global.System.Data.DataSet
        Dim cln As DS_Helper = CType(MyBase.Clone,DS_Helper)
        cln.InitVars
        cln.SchemaSerializationMode = Me.SchemaSerializationMode
        Return cln
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return false
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return false
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As Global.System.Xml.XmlReader)
        If (Me.DetermineSchemaSerializationMode(reader) = Global.System.Data.SchemaSerializationMode.IncludeSchema) Then
            Me.Reset
            Dim ds As Global.System.Data.DataSet = New Global.System.Data.DataSet
            ds.ReadXml(reader)
            If (Not (ds.Tables("ClientRequestSOAP")) Is Nothing) Then
                MyBase.Tables.Add(New ClientRequestSOAPDataTable(ds.Tables("ClientRequestSOAP")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, Global.System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.ReadXml(reader)
            Me.InitVars
        End If
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Function GetSchemaSerializable() As Global.System.Xml.Schema.XmlSchema
        Dim stream As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream
        Me.WriteXmlSchema(New Global.System.Xml.XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return Global.System.Xml.Schema.XmlSchema.Read(New Global.System.Xml.XmlTextReader(stream), Nothing)
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Friend Overloads Sub InitVars()
        Me.InitVars(true)
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Friend Overloads Sub InitVars(ByVal initTable As Boolean)
        Me.tableClientRequestSOAP = CType(MyBase.Tables("ClientRequestSOAP"),ClientRequestSOAPDataTable)
        If (initTable = true) Then
            If (Not (Me.tableClientRequestSOAP) Is Nothing) Then
                Me.tableClientRequestSOAP.InitVars
            End If
        End If
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Private Sub InitClass()
        Me.DataSetName = "DS_Helper"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/DS_Helper.xsd"
        Me.EnforceConstraints = true
        Me.SchemaSerializationMode = Global.System.Data.SchemaSerializationMode.IncludeSchema
        Me.tableClientRequestSOAP = New ClientRequestSOAPDataTable
        MyBase.Tables.Add(Me.tableClientRequestSOAP)
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Private Function ShouldSerializeClientRequestSOAP() As Boolean
        Return false
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As Global.System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = Global.System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Shared Function GetTypedDataSetSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
        Dim ds As DS_Helper = New DS_Helper
        Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType
        Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence
        Dim any As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny
        any.Namespace = ds.Namespace
        sequence.Items.Add(any)
        type.Particle = sequence
        Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
        If xs.Contains(dsSchema.TargetNamespace) Then
            Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream
            Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream
            Try 
                Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                dsSchema.Write(s1)
                Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                Do While schemas.MoveNext
                    schema = CType(schemas.Current,Global.System.Xml.Schema.XmlSchema)
                    s2.SetLength(0)
                    schema.Write(s2)
                    If (s1.Length = s2.Length) Then
                        s1.Position = 0
                        s2.Position = 0
                        
                        Do While ((s1.Position <> s1.Length)  _
                                    AndAlso (s1.ReadByte = s2.ReadByte))
                            
                            
                        Loop
                        If (s1.Position = s1.Length) Then
                            Return type
                        End If
                    End If
                    
                Loop
            Finally
                If (Not (s1) Is Nothing) Then
                    s1.Close
                End If
                If (Not (s2) Is Nothing) Then
                    s2.Close
                End If
            End Try
        End If
        xs.Add(dsSchema)
        Return type
    End Function
    
    Public Delegate Sub ClientRequestSOAPRowChangeEventHandler(ByVal sender As Object, ByVal e As ClientRequestSOAPRowChangeEvent)
    
    '''<summary>
    '''Represents the strongly named DataTable class.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"),  _
     Global.System.Serializable(),  _
     Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>  _
    Partial Public Class ClientRequestSOAPDataTable
        Inherits Global.System.Data.TypedTableBase(Of ClientRequestSOAPRow)
        
        Private columnBrandID As Global.System.Data.DataColumn
        
        Private columnUserID As Global.System.Data.DataColumn
        
        Private columnCurrencyCode As Global.System.Data.DataColumn
        
        Private columnForeigAmount As Global.System.Data.DataColumn
        
        Private columnLocalAmount As Global.System.Data.DataColumn
        
        Private columnDenomination As Global.System.Data.DataColumn
        
        Private columnXMLGetBuyQuate As Global.System.Data.DataColumn
        
        Private columnXMLGetSellQuate As Global.System.Data.DataColumn
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub New()
            MyBase.New
            Me.TableName = "ClientRequestSOAP"
            Me.BeginInit
            Me.InitClass
            Me.EndInit
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Friend Sub New(ByVal table As Global.System.Data.DataTable)
            MyBase.New
            Me.TableName = table.TableName
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
            Me.InitVars
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property BrandIDColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnBrandID
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property UserIDColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnUserID
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property CurrencyCodeColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnCurrencyCode
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property ForeigAmountColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnForeigAmount
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property LocalAmountColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnLocalAmount
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property DenominationColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnDenomination
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property XMLGetBuyQuateColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnXMLGetBuyQuate
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property XMLGetSellQuateColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnXMLGetSellQuate
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Default ReadOnly Property Item(ByVal index As Integer) As ClientRequestSOAPRow
            Get
                Return CType(Me.Rows(index),ClientRequestSOAPRow)
            End Get
        End Property
        
        Public Event ClientRequestSOAPRowChanging As ClientRequestSOAPRowChangeEventHandler
        
        Public Event ClientRequestSOAPRowChanged As ClientRequestSOAPRowChangeEventHandler
        
        Public Event ClientRequestSOAPRowDeleting As ClientRequestSOAPRowChangeEventHandler
        
        Public Event ClientRequestSOAPRowDeleted As ClientRequestSOAPRowChangeEventHandler
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Overloads Sub AddClientRequestSOAPRow(ByVal row As ClientRequestSOAPRow)
            Me.Rows.Add(row)
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Overloads Function AddClientRequestSOAPRow(ByVal BrandID As String, ByVal UserID As String, ByVal CurrencyCode As String, ByVal ForeigAmount As String, ByVal LocalAmount As String, ByVal Denomination As String, ByVal XMLGetBuyQuate As String, ByVal XMLGetSellQuate As String) As ClientRequestSOAPRow
            Dim rowClientRequestSOAPRow As ClientRequestSOAPRow = CType(Me.NewRow,ClientRequestSOAPRow)
            Dim columnValuesArray() As Object = New Object() {BrandID, UserID, CurrencyCode, ForeigAmount, LocalAmount, Denomination, XMLGetBuyQuate, XMLGetSellQuate}
            rowClientRequestSOAPRow.ItemArray = columnValuesArray
            Me.Rows.Add(rowClientRequestSOAPRow)
            Return rowClientRequestSOAPRow
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Overrides Function Clone() As Global.System.Data.DataTable
            Dim cln As ClientRequestSOAPDataTable = CType(MyBase.Clone,ClientRequestSOAPDataTable)
            cln.InitVars
            Return cln
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
            Return New ClientRequestSOAPDataTable
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Friend Sub InitVars()
            Me.columnBrandID = MyBase.Columns("BrandID")
            Me.columnUserID = MyBase.Columns("UserID")
            Me.columnCurrencyCode = MyBase.Columns("CurrencyCode")
            Me.columnForeigAmount = MyBase.Columns("ForeigAmount")
            Me.columnLocalAmount = MyBase.Columns("LocalAmount")
            Me.columnDenomination = MyBase.Columns("Denomination")
            Me.columnXMLGetBuyQuate = MyBase.Columns("XMLGetBuyQuate")
            Me.columnXMLGetSellQuate = MyBase.Columns("XMLGetSellQuate")
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Private Sub InitClass()
            Me.columnBrandID = New Global.System.Data.DataColumn("BrandID", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnBrandID)
            Me.columnUserID = New Global.System.Data.DataColumn("UserID", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnUserID)
            Me.columnCurrencyCode = New Global.System.Data.DataColumn("CurrencyCode", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnCurrencyCode)
            Me.columnForeigAmount = New Global.System.Data.DataColumn("ForeigAmount", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnForeigAmount)
            Me.columnLocalAmount = New Global.System.Data.DataColumn("LocalAmount", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnLocalAmount)
            Me.columnDenomination = New Global.System.Data.DataColumn("Denomination", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnDenomination)
            Me.columnXMLGetBuyQuate = New Global.System.Data.DataColumn("XMLGetBuyQuate", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnXMLGetBuyQuate)
            Me.columnXMLGetSellQuate = New Global.System.Data.DataColumn("XMLGetSellQuate", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnXMLGetSellQuate)
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function NewClientRequestSOAPRow() As ClientRequestSOAPRow
            Return CType(Me.NewRow,ClientRequestSOAPRow)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
            Return New ClientRequestSOAPRow(builder)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Function GetRowType() As Global.System.Type
            Return GetType(ClientRequestSOAPRow)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.ClientRequestSOAPRowChangedEvent) Is Nothing) Then
                RaiseEvent ClientRequestSOAPRowChanged(Me, New ClientRequestSOAPRowChangeEvent(CType(e.Row,ClientRequestSOAPRow), e.Action))
            End If
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.ClientRequestSOAPRowChangingEvent) Is Nothing) Then
                RaiseEvent ClientRequestSOAPRowChanging(Me, New ClientRequestSOAPRowChangeEvent(CType(e.Row,ClientRequestSOAPRow), e.Action))
            End If
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.ClientRequestSOAPRowDeletedEvent) Is Nothing) Then
                RaiseEvent ClientRequestSOAPRowDeleted(Me, New ClientRequestSOAPRowChangeEvent(CType(e.Row,ClientRequestSOAPRow), e.Action))
            End If
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.ClientRequestSOAPRowDeletingEvent) Is Nothing) Then
                RaiseEvent ClientRequestSOAPRowDeleting(Me, New ClientRequestSOAPRowChangeEvent(CType(e.Row,ClientRequestSOAPRow), e.Action))
            End If
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub RemoveClientRequestSOAPRow(ByVal row As ClientRequestSOAPRow)
            Me.Rows.Remove(row)
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
            Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType
            Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence
            Dim ds As DS_Helper = New DS_Helper
            Dim any1 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny
            any1.Namespace = "http://www.w3.org/2001/XMLSchema"
            any1.MinOccurs = New Decimal(0)
            any1.MaxOccurs = Decimal.MaxValue
            any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any1)
            Dim any2 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
            any2.MinOccurs = New Decimal(1)
            any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any2)
            Dim attribute1 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute
            attribute1.Name = "namespace"
            attribute1.FixedValue = ds.Namespace
            type.Attributes.Add(attribute1)
            Dim attribute2 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute
            attribute2.Name = "tableTypeName"
            attribute2.FixedValue = "ClientRequestSOAPDataTable"
            type.Attributes.Add(attribute2)
            type.Particle = sequence
            Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
            If xs.Contains(dsSchema.TargetNamespace) Then
                Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream
                Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream
                Try 
                    Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                    dsSchema.Write(s1)
                    Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                    Do While schemas.MoveNext
                        schema = CType(schemas.Current,Global.System.Xml.Schema.XmlSchema)
                        s2.SetLength(0)
                        schema.Write(s2)
                        If (s1.Length = s2.Length) Then
                            s1.Position = 0
                            s2.Position = 0
                            
                            Do While ((s1.Position <> s1.Length)  _
                                        AndAlso (s1.ReadByte = s2.ReadByte))
                                
                                
                            Loop
                            If (s1.Position = s1.Length) Then
                                Return type
                            End If
                        End If
                        
                    Loop
                Finally
                    If (Not (s1) Is Nothing) Then
                        s1.Close
                    End If
                    If (Not (s2) Is Nothing) Then
                        s2.Close
                    End If
                End Try
            End If
            xs.Add(dsSchema)
            Return type
        End Function
    End Class
    
    '''<summary>
    '''Represents strongly named DataRow class.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")>  _
    Partial Public Class ClientRequestSOAPRow
        Inherits Global.System.Data.DataRow
        
        Private tableClientRequestSOAP As ClientRequestSOAPDataTable
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
            MyBase.New(rb)
            Me.tableClientRequestSOAP = CType(Me.Table,ClientRequestSOAPDataTable)
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property BrandID() As String
            Get
                Try 
                    Return CType(Me(Me.tableClientRequestSOAP.BrandIDColumn),String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'BrandID' in table 'ClientRequestSOAP' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableClientRequestSOAP.BrandIDColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property UserID() As String
            Get
                Try 
                    Return CType(Me(Me.tableClientRequestSOAP.UserIDColumn),String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'UserID' in table 'ClientRequestSOAP' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableClientRequestSOAP.UserIDColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property CurrencyCode() As String
            Get
                Try 
                    Return CType(Me(Me.tableClientRequestSOAP.CurrencyCodeColumn),String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'CurrencyCode' in table 'ClientRequestSOAP' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableClientRequestSOAP.CurrencyCodeColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property ForeigAmount() As String
            Get
                Try 
                    Return CType(Me(Me.tableClientRequestSOAP.ForeigAmountColumn),String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'ForeigAmount' in table 'ClientRequestSOAP' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableClientRequestSOAP.ForeigAmountColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property LocalAmount() As String
            Get
                Try 
                    Return CType(Me(Me.tableClientRequestSOAP.LocalAmountColumn),String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'LocalAmount' in table 'ClientRequestSOAP' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableClientRequestSOAP.LocalAmountColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property Denomination() As String
            Get
                Try 
                    Return CType(Me(Me.tableClientRequestSOAP.DenominationColumn),String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'Denomination' in table 'ClientRequestSOAP' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableClientRequestSOAP.DenominationColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property XMLGetBuyQuate() As String
            Get
                Try 
                    Return CType(Me(Me.tableClientRequestSOAP.XMLGetBuyQuateColumn),String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'XMLGetBuyQuate' in table 'ClientRequestSOAP' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableClientRequestSOAP.XMLGetBuyQuateColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property XMLGetSellQuate() As String
            Get
                Try 
                    Return CType(Me(Me.tableClientRequestSOAP.XMLGetSellQuateColumn),String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'XMLGetSellQuate' in table 'ClientRequestSOAP' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableClientRequestSOAP.XMLGetSellQuateColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function IsBrandIDNull() As Boolean
            Return Me.IsNull(Me.tableClientRequestSOAP.BrandIDColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub SetBrandIDNull()
            Me(Me.tableClientRequestSOAP.BrandIDColumn) = Global.System.Convert.DBNull
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function IsUserIDNull() As Boolean
            Return Me.IsNull(Me.tableClientRequestSOAP.UserIDColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub SetUserIDNull()
            Me(Me.tableClientRequestSOAP.UserIDColumn) = Global.System.Convert.DBNull
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function IsCurrencyCodeNull() As Boolean
            Return Me.IsNull(Me.tableClientRequestSOAP.CurrencyCodeColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub SetCurrencyCodeNull()
            Me(Me.tableClientRequestSOAP.CurrencyCodeColumn) = Global.System.Convert.DBNull
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function IsForeigAmountNull() As Boolean
            Return Me.IsNull(Me.tableClientRequestSOAP.ForeigAmountColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub SetForeigAmountNull()
            Me(Me.tableClientRequestSOAP.ForeigAmountColumn) = Global.System.Convert.DBNull
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function IsLocalAmountNull() As Boolean
            Return Me.IsNull(Me.tableClientRequestSOAP.LocalAmountColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub SetLocalAmountNull()
            Me(Me.tableClientRequestSOAP.LocalAmountColumn) = Global.System.Convert.DBNull
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function IsDenominationNull() As Boolean
            Return Me.IsNull(Me.tableClientRequestSOAP.DenominationColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub SetDenominationNull()
            Me(Me.tableClientRequestSOAP.DenominationColumn) = Global.System.Convert.DBNull
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function IsXMLGetBuyQuateNull() As Boolean
            Return Me.IsNull(Me.tableClientRequestSOAP.XMLGetBuyQuateColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub SetXMLGetBuyQuateNull()
            Me(Me.tableClientRequestSOAP.XMLGetBuyQuateColumn) = Global.System.Convert.DBNull
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function IsXMLGetSellQuateNull() As Boolean
            Return Me.IsNull(Me.tableClientRequestSOAP.XMLGetSellQuateColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub SetXMLGetSellQuateNull()
            Me(Me.tableClientRequestSOAP.XMLGetSellQuateColumn) = Global.System.Convert.DBNull
        End Sub
    End Class
    
    '''<summary>
    '''Row event argument class
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")>  _
    Public Class ClientRequestSOAPRowChangeEvent
        Inherits Global.System.EventArgs
        
        Private eventRow As ClientRequestSOAPRow
        
        Private eventAction As Global.System.Data.DataRowAction
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub New(ByVal row As ClientRequestSOAPRow, ByVal action As Global.System.Data.DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property Row() As ClientRequestSOAPRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property Action() As Global.System.Data.DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
End Class
