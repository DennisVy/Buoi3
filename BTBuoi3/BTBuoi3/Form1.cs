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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                ListViewItem item = new ListViewItem(form2.MSNV);
                item.SubItems.Add(form2.TenNV);
                item.SubItems.Add(form2.Luong);
                listView1.Items.Add(item);

                // Tự động chọn mục vừa thêm
                listView1.Items[listView1.Items.Count - 1].Selected = true;
                listView1.Select();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kích hoạt nút Sửa khi có mục được chọn
            btnSua.Enabled = listView1.SelectedItems.Count > 0;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                Form2 form2 = new Form2();
                form2.MSNV = item.SubItems[0].Text;
                form2.TenNV = item.SubItems[1].Text;
                form2.Luong = item.SubItems[2].Text;

                if (form2.ShowDialog() == DialogResult.OK)
                {
                    item.SubItems[0].Text = form2.MSNV;
                    item.SubItems[1].Text = form2.TenNV;
                    item.SubItems[2].Text = form2.Luong;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để sửa.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để xóa.");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
