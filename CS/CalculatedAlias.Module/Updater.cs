using System;

using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.BaseImpl;

namespace CalculatedAlias.Module {
    public class Updater : ModuleUpdater {
        public Updater(Session session, Version currentDBVersion) : base(session, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();

            Product productOne = new Product(Session);
            productOne.Manufacturer = "Company A";
            productOne.Model = "Model One";
            productOne.Revision = "Revision One";
            productOne.Save();

            Product productTwo = new Product(Session);
            productTwo.Manufacturer = "Company B";
            productTwo.Model = "Model Two";
            productTwo.Revision = "Revision Two";
            productTwo.Save();
          
            Product productThree = new Product(Session);
            productThree.Manufacturer = "Company C";
            productThree.Model = "Model Three";
            productThree.Revision = "Revision Three";
            productThree.Save();     
        }
    }
}
