Imports Microsoft.VisualBasic
Imports System

Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.BaseImpl

Namespace CalculatedAlias.Module
	Public Class Updater
		Inherits ModuleUpdater
		Public Sub New(ByVal session As Session, ByVal currentDBVersion As Version)
			MyBase.New(session, currentDBVersion)
		End Sub
		Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
			MyBase.UpdateDatabaseAfterUpdateSchema()

			Dim productOne As New Product(Session)
			productOne.Manufacturer = "Company A"
			productOne.Model = "Model One"
			productOne.Revision = "Revision One"
			productOne.Save()

			Dim productTwo As New Product(Session)
			productTwo.Manufacturer = "Company B"
			productTwo.Model = "Model Two"
			productTwo.Revision = "Revision Two"
			productTwo.Save()

			Dim productThree As New Product(Session)
			productThree.Manufacturer = "Company C"
			productThree.Model = "Model Three"
			productThree.Revision = "Revision Three"
			productThree.Save()
		End Sub
	End Class
End Namespace
