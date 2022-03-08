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
    public partial class FPasifGorev : Form
    {
        public FPasifGorev()
        {
            InitializeComponent();
        }

        private void FPasifGorev_Load(object sender, EventArgs e)
        {
            var r = (from x in ConBag.it.TGorev
                     select new
                     {
                         x.ID,
                         x.Aciklama,
                         x.Tarih,
                         x.GorevAlan,
                         x.Durum
                     }).Where(v => v.GorevAlan == ConBag.ID3 && v.Durum == false).ToList();
            gridControl1.DataSource = r;
            gridView1.Columns["Durum"].Visible = false;
            gridView1.Columns["GorevAlan"].Visible = false;
        }
    }
}
