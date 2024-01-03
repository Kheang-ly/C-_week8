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
    public partial class EditData : Form
    {
        private DataGridViewRowCollection Rows;
        private Form THIS;
        public EditData()
        {
            InitializeComponent();
        }
        public EditData(DataGridViewRowCollection Rows,Form THIS)
        {
            this.THIS = THIS;
            this.Rows = Rows;
            InitializeComponent();
            foreach (DataGridViewRow r in this.Rows)
            {
                string id = r.Cells[0].Value.ToString();
                string name = r.Cells[1].Value.ToString();
                string gender = r.Cells[2].Value.ToString();
                string address = r.Cells[3].Value.ToString();
                Image im = (Image)r.Cells[4].Value;
                data_gridView.Rows.Add(id,name, gender, address,im);
            }
        }

        private void data_gridView_SelectionChanged(object sender, EventArgs e)
        {
            if (data_gridView.SelectedRows.Count > 0)
            {
                int row = data_gridView.SelectedRows[0].Index;
                txt_id.Text = data_gridView.Rows[row].Cells[0].Value.ToString();
                txt_name.Text = data_gridView.Rows[row].Cells[1].Value.ToString();
                txt_gender.Text = data_gridView.Rows[row].Cells[2].Value.ToString();
                txt_address.Text = data_gridView.Rows[row].Cells[3].Value.ToString();
                pic_box.Image = (Image)data_gridView.Rows[row].Cells[4].Value;
            }
            else
            {
                txt_id.Clear();
                txt_name.Clear();
                txt_address.Clear();
                txt_gender.Clear();
                pic_box.Image = Properties.Resources.noImage;
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (data_gridView.SelectedRows.Count > 0) 
            {
                int row = data_gridView.SelectedRows[0].Index;
                string id = txt_address.Text;
                string name = txt_name.Text;
                string gender = txt_gender.Text;
                string address = txt_address.Text;
                Image img = pic_box.Image;

                data_gridView.Rows[row].Cells[0].Value = id;
                data_gridView.Rows[row].Cells[1].Value = name;
                data_gridView.Rows[row].Cells[2].Value = gender;
                data_gridView.Rows[row].Cells[3].Value = address;
                data_gridView.Rows[row].Cells[4].Value = img;

                Rows[row].Cells[0].Value = id;
                Rows[row].Cells[1].Value = name;
                Rows[row].Cells[2].Value = gender;
                Rows[row].Cells[3].Value = address;
                Rows[row].Cells[4].Value = img;
            }
            
        }

        private void pic_box_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "ImageFile(*.jpg,*.bmp,*.png)|*.jpg;*.bmp;*.png";
            DialogResult result=of.ShowDialog();
            if (result == DialogResult.OK) 
            {
                Image im = Image.FromFile(of.FileName);
                pic_box.Image = im;
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Dispose();
            THIS.Show();
        }
    }
}
