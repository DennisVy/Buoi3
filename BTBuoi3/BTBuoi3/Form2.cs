using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTBuoi3
{
    public partial class Form2 : Form
    {
        public string MSNV
        {
            get { return txtMSNV.Text; }
            set { txtMSNV.Text = value; }
        }

        public string TenNV
        {
            get { return txtTennv.Text; }
            set { txtTennv.Text = value; }
        }

        public string Luong
        {
            get { return txtLuong.Text; }
            set { txtLuong.Text = value; }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

}
