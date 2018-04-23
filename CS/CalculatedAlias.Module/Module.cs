using System;
using System.Collections.Generic;

using DevExpress.ExpressApp;
using System.Reflection;
using System.Configuration;


namespace CalculatedAlias.Module {
    public sealed partial class CalculatedAliasModule : ModuleBase {
        public CalculatedAliasModule() {
            InitializeComponent();
         
            Product.SetProductNameFormat(    
                ConfigurationManager.AppSettings["ProductNameFormat"],    
                ConfigurationManager.AppSettings["ProductNameAlias"]    
                );   
        }
    }
}
