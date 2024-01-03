namespace GridView1
{
    partial class EditData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.data_gridView = new System.Windows.Forms.DataGridView();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pic = new System.Windows.Forms.DataGridViewImageColumn();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_gender = new System.Windows.Forms.TextBox();
            this.pic_box = new System.Windows.Forms.PictureBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box)).BeginInit();
            this.SuspendLayout();
            // 
            // data_gridView
            // 
            this.data_gridView.AllowUserToAddRows = false;
            this.data_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_name,
            this.col_gender,
            this.col_address,
            this.col_pic});
            this.data_gridView.Location = new System.Drawing.Point(12, 325);
            this.data_gridView.Name = "data_gridView";
            this.data_gridView.RowTemplate.Height = 64;
            this.data_gridView.Size = new System.Drawing.Size(1098, 397);
            this.data_gridView.TabIndex = 3;
            this.data_gridView.SelectionChanged += new System.EventHandler(this.data_gridView_SelectionChanged);
            // 
            // col_id
            // 
            this.col_id.HeaderText = "ID";
            this.col_id.Name = "col_id";
            this.col_id.ReadOnly = true;
            this.col_id.Width = 200;
            // 
            // col_name
            // 
            this.col_name.HeaderText = "Name";
            this.col_name.Name = "col_name";
            this.col_name.ReadOnly = true;
            this.col_name.Width = 200;
            // 
            // col_gender
            // 
            this.col_gender.HeaderText = "Gender";
            this.col_gender.Name = "col_gender";
            this.col_gender.ReadOnly = true;
            this.col_gender.Width = 200;
            // 
            // col_address
            // 
            this.col_address.HeaderText = "Address";
            this.col_address.Name = "col_address";
            this.col_address.ReadOnly = true;
            this.col_address.Width = 200;
            // 
            // col_pic
            // 
            this.col_pic.HeaderText = "Photo";
            this.col_pic.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.col_pic.Name = "col_pic";
            this.col_pic.ReadOnly = true;
            this.col_pic.Width = 250;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(12, 284);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(208, 35);
            this.txt_id.TabIndex = 4;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(226, 284);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(208, 35);
            this.txt_name.TabIndex = 4;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(654, 284);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(208, 35);
            this.txt_address.TabIndex = 4;
            // 
            // txt_gender
            // 
            this.txt_gender.Location = new System.Drawing.Point(440, 284);
            this.txt_gender.Name = "txt_gender";
            this.txt_gender.Size = new System.Drawing.Size(208, 35);
            this.txt_gender.TabIndex = 4;
            // 
            // pic_box
            // 
            this.pic_box.Image = global::GridView1.Properties.Resources.noImage;
            this.pic_box.Location = new System.Drawing.Point(12, 12);
            this.pic_box.Name = "pic_box";
            this.pic_box.Size = new System.Drawing.Size(422, 241);
            this.pic_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_box.TabIndex = 5;
            this.pic_box.TabStop = false;
            this.pic_box.Click += new System.EventHandler(this.pic_box_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(868, 282);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(99, 37);
            this.btn_edit.TabIndex = 6;
            this.btn_edit.Text = "Enter";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(22, 686);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(86, 27);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // EditData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 735);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.pic_box);
            this.Controls.Add(this.txt_gender);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.data_gridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "EditData";
            this.Text = "EditData";
            ((System.ComponentModel.ISupportInitialize)(this.data_gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_gridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_address;
        private System.Windows.Forms.DataGridViewImageColumn col_pic;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_gender;
        private System.Windows.Forms.PictureBox pic_box;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_back;
    }
}