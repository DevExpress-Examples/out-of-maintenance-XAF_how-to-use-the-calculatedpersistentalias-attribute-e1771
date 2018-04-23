using System;
using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;


namespace CalculatedAlias.Module {
    [CalculatedPersistentAlias("ProductName", "ProductNameAlias"), DefaultClassOptions]
    public class Product : BaseObject {
        public Product(Session session) : base(session) { }

        private static string productNameFormat = "{Manufacturer} {Model}";
        private static string productNameAlias = "concat(Manufacturer, Model)";
        
        public string ProductName {
            get { return ObjectFormatter.Format(productNameFormat, this, EmptyEntriesMode.RemoveDelimiterWhenEntryIsEmpty); }
        }
        [Browsable(false)]
        public static string ProductNameAlias {
            get { return productNameAlias; }            
        }

        public static void SetProductNameFormat(string productNameFormat, string productNameAlias) {
            if(!string.IsNullOrEmpty(productNameFormat)) {
                Product.productNameFormat = productNameFormat;
            }
            if(!string.IsNullOrEmpty(productNameAlias)) {
                Product.productNameAlias = productNameAlias;
            }
        }

        public string Manufacturer {
            get { return GetPropertyValue<string>("Manufacturer"); }
            set { SetPropertyValue<string>("Manufacturer", value); }
        }
        public string Model {
            get { return GetPropertyValue<string>("Model"); }
            set { SetPropertyValue<string>("Model", value); }
        }
        public string Revision {
            get { return GetPropertyValue<string>("Revision"); }
            set { SetPropertyValue<string>("Revision", value); }
        }
    }

}
