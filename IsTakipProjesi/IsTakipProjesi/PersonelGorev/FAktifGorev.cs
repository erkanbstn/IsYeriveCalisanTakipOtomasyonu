using IsTakipProjesi.Baglanti;
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
    public partial class FAktifGorev : Form
    {
        public FAktifGorev()
        {
            InitializeComponent();
        }

        private void FAktifGorev_Load(object sender, EventArgs e)
        {
            var r = (from x in ConBag.it.TGorev
                     select new
                     {
                         x.ID,
                         x.Aciklama,
                         x.Tarih,
                         x.GorevAlan,
                         x.Durum
                     }).Where(v => v.GorevAlan == ConBag.ID3 && v.Durum == true).ToList();
            gridControl1.DataSource = r;
            gridView1.Columns["Durum"].Visible = false;
            gridView1.Columns["GorevAlan"].Visible = false;

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            ConBag.ID = byte.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            FCagriDetay f = new FCagriDetay();
            f.Show();
        }
    }
}
