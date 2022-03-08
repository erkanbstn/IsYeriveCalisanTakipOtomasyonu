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

namespace IsTakipProjesi.Forms
{
    public partial class FYeniGorev : Form
    {
        public FYeniGorev()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        TGorev t = new TGorev();
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            t.GorevVeren = byte.Parse(lookUpEdit2.EditValue.ToString());
            t.GorevAlan = byte.Parse(lookUpEdit1.EditValue.ToString());
            t.Aciklama = textEdit2.Text;
            if (checkEdit1.Checked)
            {
                t.Durum = true;
            }
            else
            {
                t.Durum = false;
            }
            t.Tarih = Convert.ToDateTime(textEdit3.Text);
            ConBag.it.TGorev.Add(t);
            ConBag.it.SaveChanges();
            XtraMessageBox.Show("Yeni Görev Sisteme Tanımlandı","Bilgilendirme Sistemi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void FYeniGorev_Load(object sender, EventArgs e)
        {
            var x = (from c in ConBag.it.TPersonel select new { c.ID, c.Personel }).ToList();
            lookUpEdit1.Properties.DataSource = x;
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "Personel";

            lookUpEdit2.Properties.ValueMember = "ID";
            lookUpEdit2.Properties.DisplayMember = "Personel";
            lookUpEdit2.Properties.DataSource = x;
            checkEdit1.Checked = true;
        }
    }
}
