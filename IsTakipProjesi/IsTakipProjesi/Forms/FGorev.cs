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
    public partial class FGorev : Form
    {
        public FGorev()
        {
            InitializeComponent();
        }

        private void FGorev_Load(object sender, EventArgs e)
        {

            // Departman Sayısı
            labelControl1.Text = Convert.ToInt32(ConBag.it.TDepartman.Count()).ToString();

            // Aktif Durumdaki Görevler
            labelControl2.Text = Convert.ToInt32(ConBag.it.TGorev.Where(c => c.Durum == true).Count()).ToString();

            // Pasif Durumdaki Görevler
            labelControl4.Text = Convert.ToInt32(ConBag.it.TGorev.Where(c => c.Durum == false).Count()).ToString();


            gridControl1.DataSource = (from x in ConBag.it.TGorev select new { x.TPersonel.Personel, x.Aciklama }).ToList();

            // Chart İşlemleri 

            chartControl1.Series["Durumlar"].Points.AddPoint("Aktif Görevler", int.Parse(labelControl2.Text));
            chartControl1.Series["Durumlar"].Points.AddPoint("Pasif Görevler", int.Parse(labelControl4.Text));
        }
    }
}
