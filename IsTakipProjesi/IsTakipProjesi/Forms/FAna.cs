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
    public partial class FAna : Form
    {
        public FAna()
        {
            InitializeComponent();
        }

        private void FAna_Load(object sender, EventArgs e)
        {
            // Bugün Tarihi

            DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());


            gridControl1.DataSource = (from x in ConBag.it.TGorev.Where(v => v.Durum == true) select new { x.Aciklama, x.TPersonel.Personel }).ToList();

            // Durum Sütununu Kapat

            //gridView1.Columns["Durum"].Visible = false;

            // Bugün Yapılan Görevler


            gridControl2.DataSource = (from x in ConBag.it.TGorevDetay
                                       select new
                                       {
                                           Gorev = x.TGorev.Aciklama,
                                           x.Aciklama,
                                           x.Tarih

                                       }).Where(c => c.Tarih == bugun).ToList();



            // Çağrı Firması Ve Konular 

            gridControl3.DataSource = (from x in ConBag.it.TCagri
                                       select new
                                       {
                                           x.TFirma.Firma,
                                           x.Konu,
                                           x.Tarih,
                                           x.Durum
                                       }).Where(c => c.Durum == true).ToList();

            // Durum Sütununu Kapat

            gridView3.Columns["Durum"].Visible = false;


            // Fihrist Komutları

            gridControl4.DataSource = (from x in ConBag.it.TFirma
                                       select new
                                       {
                                           x.Firma,
                                           x.Telefon,
                                           x.Adres
                                       }).ToList();


            // Aktif Durumdaki Görevler
            int a = Convert.ToInt32(ConBag.it.TCagri.Where(c => c.Durum == true).Count());

            // Pasif Durumdaki Görevler
            int b = Convert.ToInt32(ConBag.it.TCagri.Where(c => c.Durum == false).Count());

            // Chart İşlemleri 

            chartControl1.Series["Cagrilar"].Points.AddPoint("Aktif Görevler", a);
            chartControl1.Series["Cagrilar"].Points.AddPoint("Pasif Görevler", b);
        }
    }
}
