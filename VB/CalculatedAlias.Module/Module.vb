Imports DevExpress.ExpressApp
Imports System.Reflection
Imports System.Configuration


Namespace CalculatedAlias.Module
    Public NotInheritable Partial Class CalculatedAliasModule
        Inherits ModuleBase

        Public Sub New()
            InitializeComponent()

            Product.SetProductNameFormat(ConfigurationManager.AppSettings("ProductNameFormat"), ConfigurationManager.AppSettings("ProductNameAlias"))
        End Sub
    End Class
End Namespace
