using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridView1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void pic_box_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            DialogResult result = of.ShowDialog();
            if (result == DialogResult.OK)
            {
                Image im = Image.FromFile(of.FileName);
                pic_box.Image = im;
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            string id=txt_id.Text.Trim();
            string name=txt_name.Text.Trim();
            string sex;
            string address = txt_address.Text.Trim();
            if (r_male.Checked)
                sex = "Male";
            else if (r_female.Checked)
                sex = "Female";
            else
                sex = "Other";
            Image im=pic_box.Image;
            data_gridView.Rows.Add(id, name, sex, address, im);
            txt_id.Clear();
            txt_name.Clear();
            txt_address.Clear();
            r_male.Checked = true;
            pic_box.Image = Properties.Resources.noImage;

            txt_id.Focus();
        }

        private void data_gridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4) 
            {
                OpenFileDialog of = new OpenFileDialog();
                of.Filter = "ImageFile(*.jpg,*.bmp,*.png)|*.jpg;*.bmp;*.png";
                DialogResult result = of.ShowDialog();
                if (result == DialogResult.OK) 
                {
                    Image im = Image.FromFile(of.FileName);
                    int row = e.RowIndex;
                    data_gridView.Rows[row].Cells[4].Value = im;
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EditData(data_gridView.Rows,this).Show();
        }
    }
}
