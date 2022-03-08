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
    public partial class FPersonelIstatistik : Form
    {
        public FPersonelIstatistik()
        {
            InitializeComponent();
        }

        private void FPersonelIstatistik_Load(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Today;

            // Personel Sayısı
            labelControl2.Text = Convert.ToInt32(ConBag.it.TPersonel.Count()).ToString();

            // Departman Sayısı
            labelControl11.Text = Convert.ToInt32(ConBag.it.TDepartman.Count()).ToString();

            // Firma Sayısı 
            labelControl9.Text = Convert.ToInt32(ConBag.it.TFirma.Count()).ToString();

            // Aktif Durumdaki Görevler
            labelControl17.Text = Convert.ToInt32(ConBag.it.TGorev.Where(c => c.Durum == true).Count()).ToString();

            // Pasif Durumdaki Görevler
            labelControl23.Text = Convert.ToInt32(ConBag.it.TGorev.Where(c => c.Durum == false).Count()).ToString();


            // Son Görevin Açıklaması
            labelControl7.Text = ConBag.it.TGorev.OrderByDescending(v => v.ID).Select(c => c.Aciklama).FirstOrDefault();

            // Firmalardaki Sektörler
            labelControl3.Text = Convert.ToInt32(ConBag.it.TFirma.Select(c => c.Sektor).Distinct().Count()).ToString();

            // Şehirlerdeki Firmalar
            labelControl15.Text = Convert.ToInt32(ConBag.it.TFirma.Select(c => c.Il).Distinct().Count()).ToString();

            // Bugünkü Görevler
            labelControl21.Text = Convert.ToInt32(ConBag.it.TGorev.Count(c => c.Tarih == bugun)).ToString();

            // Ayın Personeli
            int a = Convert.ToInt32(ConBag.it.TGorev.GroupBy(c => c.GorevAlan).OrderByDescending(v => v.Count()).Select(y => y.Key).FirstOrDefault().ToString());
            labelControl13.Text = ConBag.it.TPersonel.Where(c => c.ID == a).FirstOrDefault().Personel;

            // Son Görev Tarihi
            labelControl5.Text = labelControl7.Text = ConBag.it.TGorev.OrderByDescending(v => v.ID).Select(c => c.Tarih).FirstOrDefault().ToString();

            // Ayın Departmanı
            labelControl19.Text = ConBag.it.TDepartman.Where(c => c.ID == ConBag.it.TPersonel.Where(b => b.ID == a).Select(z=>z.Departman).FirstOrDefault()).Select(y => y.Ad).FirstOrDefault();
        }
    }
}
