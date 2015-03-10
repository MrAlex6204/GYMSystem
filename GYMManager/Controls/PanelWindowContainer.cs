using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;

public class PanelWindowContainer : System.Windows.Forms.TabControl {

    public PanelWindowContainer() {
        
    }
    public void InitilizeComponents() {
       
        if (!this.DesignMode) {
            this.Appearance = TabAppearance.FlatButtons;
            this.ItemSize = new Size(0, 1);
            this.SizeMode = TabSizeMode.Fixed;
        }
       
    }

}
