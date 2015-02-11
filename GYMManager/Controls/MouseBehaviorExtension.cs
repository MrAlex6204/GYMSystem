using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
namespace GYMManager.Controls
{

    [TypeConverter(typeof(ExpandableObjectConverter) )]
    class MouseBehaviorExtension
    {

        private string _HoverTex = null,_LeaveText=null;   

        [Category("Hover")]        
        public string HoverText
        {
            get{return _HoverTex;}
            set{_HoverTex = value;}
        }
        [Category("Leave")]       
        public string LeaveText
        {
            get{return _LeaveText;}
            set{_LeaveText = value;}
        }


        private System.Drawing.Color _HoverColor = null,_LeaveColor = null;
        [Category("Hover")]        
        public System.Drawing.Color HoverColor
        {
            get;
            set;
        }
        [Category("Leave")]
       
        public System.Drawing.Color LeaveColor
        {
            get;
            set;
        }
        [Category("Hover")]
       
        public System.Drawing.Color HoverForecolor
        
            get;
            set;
        }
        [Category("Leave")]
       
        public System.Drawing.Color LeaveForecolor
        {
            get;
            set;
        }
        [Category("Hover")]
       
        public System.Drawing.Image HoverImage
        {
            get;
            set;
        }
        [Category("Leave")]
       
        public System.Drawing.Image LeaveImage
        {
            get;
            set;
        }

        public override string ToString()
        {
            return "Mouse Common Behavior";
        }
    }
}
