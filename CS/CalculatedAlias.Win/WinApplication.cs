using System;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.ExpressApp.Win;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp;

namespace CalculatedAlias.Win {
    public partial class CalculatedAliasWindowsFormsApplication : WinApplication {
        public CalculatedAliasWindowsFormsApplication() {
            InitializeComponent();
        }

        private void CalculatedAliasWindowsFormsApplication_DatabaseVersionMismatch(object sender, DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs e) {
            e.Updater.Update();
            e.Handled = true;
        }
    }
}
