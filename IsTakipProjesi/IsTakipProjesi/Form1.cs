using IsTakipProjesi.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsTakipProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void acilis()
        {
            splashScreenManager1.ShowWaitForm();
            Thread.Sleep(300);
            splashScreenManager1.CloseWaitForm();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (f7 == null || f7.IsDisposed)
            {
                f7 = new FAna();
                f7.MdiParent = this;
                f7.Show();
            }
            else
            {
                f7.Focus();
            }
            acilis();
        }
        FAna f7;
        FDepartman f;
        FPersonel f2;
        FPersonelIstatistik f3;
        FGorev f4;
        FYeniGorev f5;
        FGorevDetay f6;
        FAktifCagri f8;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f == null || f.IsDisposed)
            {
                acilis();
                f = new FDepartman();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f2 == null || f2.IsDisposed)
            {
                acilis();
                f2 = new FPersonel();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f3 == null || f3.IsDisposed)
            {
                acilis();
                f3 = new FPersonelIstatistik();
                f3.MdiParent = this;
                f3.Show();
            }
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f4 == null || f4.IsDisposed)
            {
                acilis();
                f4 = new FGorev();
                f4.MdiParent = this;
                f4.Show();
            }
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f5 == null || f5.IsDisposed)
            {
                acilis();
                f5 = new FYeniGorev();
                f5.Show();
            }
            else
            {
                f5.Focus();
            }
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f6 == null || f6.IsDisposed)
            {
                acilis();
                f6 = new FGorevDetay();
                f6.Show();
            }
            else
            {
                f6.Focus();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f7 == null || f7.IsDisposed)
            {
                acilis();
                f7 = new FAna();
                f7.MdiParent = this;
                f7.Show();
            }
            else
            {
                f7.Focus();
            }
        }

        private void barButtonItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f8 == null || f8.IsDisposed)
            {
                acilis();
                f8 = new FAktifCagri();
                f8.MdiParent = this;
                f8.Show();
            }
            else
            {
                f8.Focus();
            }
        }
    }
}
