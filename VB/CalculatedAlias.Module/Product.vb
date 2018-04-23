Imports System.ComponentModel

Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Xpo
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation


Namespace CalculatedAlias.Module
    <CalculatedPersistentAlias("ProductName", "ProductNameAlias"), DefaultClassOptions> _
    Public Class Product
        Inherits BaseObject

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Private Shared productNameFormat As String = "{Manufacturer} {Model}"
        Private Shared _productNameAlias As String = "concat(Manufacturer, Model)"

        Public ReadOnly Property ProductName() As String
            Get
                Return ObjectFormatter.Format(productNameFormat, Me, EmptyEntriesMode.RemoveDelimeterWhenEntryIsEmpty)
            End Get
        End Property
        <Browsable(False)> _
        Public Shared ReadOnly Property ProductNameAlias() As String
            Get
                Return _productNameAlias
            End Get
        End Property

        Public Shared Sub SetProductNameFormat(ByVal productNameFormat As String, ByVal productNameAlias As String)
            If Not String.IsNullOrEmpty(productNameFormat) Then
                Product.productNameFormat = productNameFormat
            End If
            If Not String.IsNullOrEmpty(productNameAlias) Then
                Product._productNameAlias = productNameAlias
            End If
        End Sub

        Public Property Manufacturer() As String
            Get
                Return GetPropertyValue(Of String)("Manufacturer")
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Manufacturer", value)
            End Set
        End Property
        Public Property Model() As String
            Get
                Return GetPropertyValue(Of String)("Model")
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Model", value)
            End Set
        End Property
        Public Property Revision() As String
            Get
                Return GetPropertyValue(Of String)("Revision")
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Revision", value)
            End Set
        End Property
    End Class

End Namespace
