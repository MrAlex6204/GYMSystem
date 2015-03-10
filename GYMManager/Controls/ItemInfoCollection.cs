using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

class ItemInfoCollection : System.Windows.Forms.Panel {

    private PanelPartner pnlPartner;
    public ItemInfoCollection() {
        this.AutoScroll = true;
        this.pnlPartner = new PanelPartner();
        pnlPartner.Dock = DockStyle.Fill;
        this.Controls.Add(pnlPartner);
    }

    public void LoadSocios() {
        List<SocioInfo> LstSocios = new List<SocioInfo>();

        LstSocios = SocioInfo.GetSocios();
        this.Controls.Clear();
        foreach (SocioInfo iSocio in LstSocios) {
            ItemInfo item = new ItemInfo(iSocio);
            Panel itemContainer = new Panel();

            item.Delete += new ItemInfo.DeleteEventHandler(Delete);
            item.Dock = DockStyle.Fill;
            itemContainer.Dock = DockStyle.Top;
            itemContainer.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            item.SendToBack();
            itemContainer.Controls.Add(item);
            this.Controls.Add(itemContainer);
        }

        this.pnlPartner.BringToFront();
        this.Controls.Add(this.pnlPartner);
    }
    private void Delete(object sender, SocioInfo Item) {
        if (MessageBox.Show("Desea borrar este cliente ?", "Borrar", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) {
            if (Item.Delete()) {
                MessageBox.Show("Eliminado!", "Se elimino!");
            }
        }
    }

}

