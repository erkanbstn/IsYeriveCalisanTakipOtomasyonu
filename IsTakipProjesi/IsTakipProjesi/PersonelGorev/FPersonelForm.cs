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
    public partial class FPersonelForm : Form
    {
        public FPersonelForm()
        {
            InitializeComponent();
        }
        FAktifGorev f;
        FCagriListe f2;
        FPasifGorev f3;
        private void FPersonelForm_Load(object sender, EventArgs e)
        {
            if (f == null || f.IsDisposed)
            {
                f = new FAktifGorev();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                f.Focus();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f == null || f.IsDisposed)
            {
                f = new FAktifGorev();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                f.Focus();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f2 == null || f2.IsDisposed)
            {
                f2 = new FCagriListe();
                f2.MdiParent = this;
                f2.Show();
            }
            else
            {
                f2.Focus();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f3 == null || f3.IsDisposed)
            {
                f3 = new FPasifGorev();
                f3.MdiParent = this;
                f3.Show();
            }
            else
            {
                f3.Focus();
            }
        }
    }
}
