using IsTakipProjesi.Baglanti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsTakipProjesi.Forms
{
    public partial class FGorevDetay : Form
    {
        public FGorevDetay()
        {
            InitializeComponent();
        }

        private void FGorevDetay_Load(object sender, EventArgs e)
        {
            ConBag.it.TGorevDetay.Load();
            bindingSource1.DataSource = ConBag.it.TGorevDetay.Local;
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            ConBag.it.SaveChanges();
        }

        private void görevDetaySilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            ConBag.it.SaveChanges();
        }
    }
}
