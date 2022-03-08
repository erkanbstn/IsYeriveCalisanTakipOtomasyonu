using DevExpress.XtraEditors;
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
    public partial class FCagriDetay : Form
    {

        public FCagriDetay()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string saat, detay;

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            TCagriDetay t = new TCagriDetay();
            t.Cagri = byte.Parse(textEdit1.Text);
            t.Saat = textEdit4.Text;
            t.Tarih = DateTime.Parse(textEdit3.Text);
            t.Aciklama = textEdit2.Text;
            ConBag.it.TCagriDetay.Add(t);
            ConBag.it.SaveChanges();
            XtraMessageBox.Show("Çağrı Başarıyla Oluşturuldu", "Bilgilendirme Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FCagriDetay_Load(object sender, EventArgs e)
        {
            textEdit1.Text = ConBag.ID.ToString();
            textEdit1.Enabled = false;
            saat = DateTime.Now.ToShortTimeString();
            detay = DateTime.Now.ToShortDateString();
            textEdit4.Text = saat.ToString();
            textEdit3.Text = detay.ToString();
        }
    }
}
