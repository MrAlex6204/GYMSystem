using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GYMManager.Controls
{
    class AnimatedButton : System.Windows.Forms.Button
    {



        private System.Drawing.Image _OverImage = null;
        private System.Drawing.Image _NormalImage = null;
        public System.Drawing.Image MouseOverImage
        {
            get { return _OverImage; }
            set { _OverImage = value; }
        }

        public  System.Drawing.Image Image {
            get {
                return _NormalImage;
            }
            set {
                base.Image = value;
                _NormalImage = value;
            }
        }

        public AnimatedButton()
            : base()
        {
            this.MouseHover += new EventHandler(_MouseOver);
            this.MouseLeave += new EventHandler(_MouseLeave);
        }


        private void _MouseOver(object sender, object e) {
            if (_OverImage != null) {
                this.Image = _OverImage;
            }
        }
        private void _MouseLeave(object sender, object e) {
            if (_NormalImage != null) {
                this.Image = _NormalImage;
            }
        }



    }
}
