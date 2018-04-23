using System;
using System.Collections.Generic;
using System.Reflection;
using System.Configuration;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Xpo;
using DevExpress.ExpressApp.DC;

namespace CalculatedAlias.Module {
    public sealed partial class CalculatedAliasModule : ModuleBase {
        public CalculatedAliasModule() {
            InitializeComponent();
            Product.SetProductNameFormat(    
                ConfigurationManager.AppSettings["ProductNameFormat"],    
                ConfigurationManager.AppSettings["ProductNameAlias"]    
                );   
        }
        public override void CustomizeTypesInfo(ITypesInfo typesInfo) {
	base.CustomizeTypesInfo(typesInfo);
	CalculatedPersistentAliasHelper.CustomizeTypesInfo(typesInfo);
        }
    }
}
