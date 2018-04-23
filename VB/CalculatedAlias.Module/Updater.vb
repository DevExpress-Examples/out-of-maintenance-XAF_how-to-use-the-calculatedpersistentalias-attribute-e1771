Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.BaseImpl

Namespace CalculatedAlias.Module
    Public Class Updater
        Inherits ModuleUpdater

        Public Sub New(ByVal objectSpace As IObjectSpace, ByVal currentDBVersion As Version)
            MyBase.New(objectSpace, currentDBVersion)
        End Sub
        Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
            MyBase.UpdateDatabaseAfterUpdateSchema()

            Dim productOne As Product = ObjectSpace.CreateObject(Of Product)()
            productOne.Manufacturer = "Company A"
            productOne.Model = "Model One"
            productOne.Revision = "Revision One"
            productOne.Save()

            Dim productTwo As Product = ObjectSpace.CreateObject(Of Product)()
            productTwo.Manufacturer = "Company B"
            productTwo.Model = "Model Two"
            productTwo.Revision = "Revision Two"
            productTwo.Save()

            Dim productThree As Product = ObjectSpace.CreateObject(Of Product)()
            productThree.Manufacturer = "Company C"
            productThree.Model = "Model Three"
            productThree.Revision = "Revision Three"
            productThree.Save()
        End Sub
    End Class
End Namespace
