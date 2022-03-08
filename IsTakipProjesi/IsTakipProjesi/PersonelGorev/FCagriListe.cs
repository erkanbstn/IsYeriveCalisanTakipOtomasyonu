using IsTakipProjesi.Baglanti;
using IsTakipProjesi.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsTakipProjesi.PersonelGorev
{
    public partial class FCagriListe : Form
    {
        public FCagriListe()
        {
            InitializeComponent();
        }

        private void FCagriListe_Load(object sender, EventArgs e)
        {
            var r = (from x in ConBag.it.TCagri
                     select new
                     {
                         x.ID,
                         x.TFirma.Firma,
                         x.TFirma.Telefon,
                         x.TFirma.Mail,
                         x.TPersonel.Personel,
                         x.Aciklama,
                         x.CagriPersonel,
                         x.Durum
                     }).Where(v => v.Durum == true && v.CagriPersonel == ConBag.ID3).ToList();
            gridControl1.DataSource = r;
            gridView1.Columns["Durum"].Visible = false;
            gridView1.Columns["CagriPersonel"].Visible = false;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            ConBag.ID2 = byte.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            FCagriAtama f = new FCagriAtama();
            f.Show();
        }
    }
}
