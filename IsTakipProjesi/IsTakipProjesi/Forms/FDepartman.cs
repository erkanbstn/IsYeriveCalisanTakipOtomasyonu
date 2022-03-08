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
    public partial class FDepartman : Form
    {
        public FDepartman()
        {
            InitializeComponent();
        }
        void liste()
        {
            SqlDataAdapter adp = new SqlDataAdapter("Select * from TDepartman",ConBag.it2);
            DataTable tb = new DataTable();
            adp.Fill(tb);
            gridControl1.DataSource = tb;
        }
        TDepartman t = new TDepartman();
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            byte id = byte.Parse(textEdit1.Text);
            var x = ConBag.it.TDepartman.Find(id);
            x.Ad = textEdit2.Text;
            ConBag.it.SaveChanges();
            liste();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            byte id = byte.Parse(textEdit1.Text);
            var x = ConBag.it.TDepartman.Find(id);
            ConBag.it.TDepartman.Remove(x);
            ConBag.it.SaveChanges();
            liste();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            t.Ad = textEdit2.Text;
            ConBag.it.TDepartman.Add(t);
            ConBag.it.SaveChanges();
            liste();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            liste();
        }

        private void FDepartman_Load(object sender, EventArgs e)
        {
            liste();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow r = gridView1.GetDataRow(e.FocusedRowHandle);
            if (r != null)
            {
                textEdit1.Text = r["ID"].ToString();
                textEdit2.Text = r[1].ToString();
            }
        }
    }
}
