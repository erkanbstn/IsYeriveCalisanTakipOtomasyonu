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

namespace IsTakipProjesi.Forms
{
    public partial class FAktifCagri : Form
    {
        public FAktifCagri()
        {
            InitializeComponent();
        }

        private void FAktifCagri_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in ConBag.it.TCagri
                                       select new
                                       {
                                           x.ID,
                                           x.TFirma.Firma,
                                           x.TFirma.Telefon,
                                           x.Konu,
                                           x.Aciklama,
                                           x.Durum
                                       }).Where(y => y.Durum
                                       == true).ToList();

            gridView1.Columns["Durum"].Visible = false;
        }
    }
}
