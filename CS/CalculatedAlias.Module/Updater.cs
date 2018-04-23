using System;

using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.Persistent.BaseImpl;

namespace CalculatedAlias.Module {
    public class Updater : ModuleUpdater {
        public Updater(ObjectSpace objectSpace, Version currentDBVersion) : base(objectSpace, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();

            Product productOne = ObjectSpace.CreateObject<Product>();
            productOne.Manufacturer = "Company A";
            productOne.Model = "Model One";
            productOne.Revision = "Revision One";
            productOne.Save();

            Product productTwo = ObjectSpace.CreateObject<Product>();
            productTwo.Manufacturer = "Company B";
            productTwo.Model = "Model Two";
            productTwo.Revision = "Revision Two";
            productTwo.Save();
          
            Product productThree = ObjectSpace.CreateObject<Product>();
            productThree.Manufacturer = "Company C";
            productThree.Model = "Model Three";
            productThree.Revision = "Revision Three";
            productThree.Save();     
        }
    }
}
