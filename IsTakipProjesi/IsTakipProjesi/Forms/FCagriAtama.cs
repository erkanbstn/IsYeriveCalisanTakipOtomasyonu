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
    public partial class FCagriAtama : Form
    {
        public FCagriAtama()
        {
            InitializeComponent();
        }

        private void FCagriAtama_Load(object sender, EventArgs e)
        {
            textEdit4.Text = ConBag.ID2.ToString();
            var x = ConBag.it.TCagri.Find(ConBag.ID2);
            textEdit2.Text = x.Aciklama;
            textEdit3.Text = x.Tarih.ToString();
            textEdit1.Text = x.Konu;

            var x2 = (from c in ConBag.it.TPersonel select new { c.ID, c.Personel }).ToList();
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "Personel";
            lookUpEdit1.Properties.DataSource = x2;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var x = ConBag.it.TCagri.Find(ConBag.ID2);
            x.Konu = textEdit1.Text;
            x.Tarih = Convert.ToDateTime(textEdit3.Text);
            x.Aciklama = textEdit2.Text;
            x.CagriPersonel = byte.Parse(lookUpEdit1.EditValue.ToString());
            ConBag.it.SaveChanges();
        }
    }
}
