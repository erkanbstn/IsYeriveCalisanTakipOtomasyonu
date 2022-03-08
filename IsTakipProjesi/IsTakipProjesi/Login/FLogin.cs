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

namespace IsTakipProjesi.Login
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var admin = ConBag.it.TPersonel.Where(c => c.Personel == textEdit1.Text && c.Sifre == textEdit2.Text).FirstOrDefault();
            if (admin != null)
            {
                ConBag.ID3 = admin.ID;
                PersonelGorev.FPersonelForm f = new PersonelGorev.FPersonelForm();
                f.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı", "Bilgilendirme Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var admin = ConBag.it.TAdmin.Where(c => c.Admin == textEdit1.Text && c.Sifre == textEdit2.Text).FirstOrDefault();

            if (admin != null)
            {
                Form1 f = new Form1();
                f.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı", "Bilgilendirme Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
