Imports System
Imports System.Collections.Generic
Imports System.Reflection
Imports System.Configuration
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Xpo
Imports DevExpress.ExpressApp.DC

Namespace CalculatedAlias.Module
    Public NotInheritable Partial Class CalculatedAliasModule
        Inherits ModuleBase

        Public Sub New()
            InitializeComponent()
            Product.SetProductNameFormat(ConfigurationManager.AppSettings("ProductNameFormat"), ConfigurationManager.AppSettings("ProductNameAlias"))
        End Sub
        Public Overrides Sub CustomizeTypesInfo(ByVal typesInfo As ITypesInfo)
    MyBase.CustomizeTypesInfo(typesInfo)
    CalculatedPersistentAliasHelper.CustomizeTypesInfo(typesInfo)
        End Sub
    End Class
End Namespace