using IsTakipProjesi.Baglanti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsTakipProjesi.Forms
{
    public partial class FPersonel : Form
    {
        public FPersonel()
        {
            InitializeComponent();
        }
        void liste()
        {
            SqlDataAdapter adp = new SqlDataAdapter("Select * from TPersonel where Durum=1", ConBag.it2);
            DataTable tb = new DataTable();
            adp.Fill(tb);
            gridControl1.DataSource = tb;
        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            liste();
        }

        private void FPersonel_Load(object sender, EventArgs e)
        {
            liste();
            var departman = (from c in ConBag.it.TDepartman select new { c.ID, c.Ad }).ToList();
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "Ad";
            lookUpEdit1.Properties.DataSource = departman;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow r = gridView1.GetDataRow(e.FocusedRowHandle);
            if (r != null)
            {
                textEdit1.Text = r[0].ToString();
                maskedTextBox1.Text = r[3].ToString();
                textEdit3.Text = r[1].ToString();
                textEdit4.Text = r[2].ToString();
                lookUpEdit1.EditValue = r[5];
            }
        }
        TPersonel t = new TPersonel();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            t.Personel = textEdit3.Text;
            t.Telefon = maskedTextBox1.Text;
            t.Mail = textEdit4.Text;
            t.Departman = byte.Parse(lookUpEdit1.EditValue.ToString());
            ConBag.it.TPersonel.Add(t);
            ConBag.it.SaveChanges();
            liste();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            byte id = byte.Parse(textEdit1.Text);
            var x = ConBag.it.TPersonel.Find(id);
            x.Durum = false;
            ConBag.it.SaveChanges();
            liste();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            byte id = byte.Parse(textEdit1.Text);
            var x = ConBag.it.TPersonel.Find(id);
            x.Personel = textEdit3.Text;
            x.Telefon = maskedTextBox1.Text;
            x.Mail = textEdit4.Text;
            x.Departman = byte.Parse(lookUpEdit1.EditValue.ToString());
            ConBag.it.SaveChanges();
            liste();
        }
    }
}
