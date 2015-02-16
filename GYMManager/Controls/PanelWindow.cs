using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class PanelWindow:System.Windows.Forms.Panel
{

    private System.Windows.Forms.Button _ButtonOwner;
    private bool _IsVisible = false;
        

    public System.Windows.Forms.Button OwnerButton { 
        get{ 
            return _ButtonOwner;
        }
        set{
            _ButtonOwner = value;
            if (value != null) {
                if (!this.DesignMode){
                    this.Visible = _IsVisible = false;
                }
                _ButtonOwner.Click += new EventHandler(_OwnerClick);                
            }
        }
    
    }
       
    private void _OwnerClick(object sender, object e) {
        
            if (!this.DesignMode)
            {
                _IsVisible = !_IsVisible;
                this.Visible = _IsVisible;
            }
        
    }



}

