namespace GridView1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.data_gridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.r_male = new System.Windows.Forms.RadioButton();
            this.r_female = new System.Windows.Forms.RadioButton();
            this.r_other = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.pic_box = new System.Windows.Forms.PictureBox();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pic = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_gridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(123, 21);
            this.txt_id.Multiline = true;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(320, 41);
            this.txt_id.TabIndex = 1;
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
            this.data_gridView.Location = new System.Drawing.Point(21, 324);
            this.data_gridView.Name = "data_gridView";
            this.data_gridView.RowTemplate.Height = 64;
            this.data_gridView.Size = new System.Drawing.Size(1090, 397);
            this.data_gridView.TabIndex = 2;
            this.data_gridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_gridView_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(123, 82);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(320, 41);
            this.txt_name.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Address";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(123, 275);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(320, 41);
            this.txt_address.TabIndex = 1;
            // 
            // r_male
            // 
            this.r_male.AutoSize = true;
            this.r_male.Checked = true;
            this.r_male.Location = new System.Drawing.Point(6, 45);
            this.r_male.Name = "r_male";
            this.r_male.Size = new System.Drawing.Size(84, 33);
            this.r_male.TabIndex = 3;
            this.r_male.TabStop = true;
            this.r_male.Text = "Male";
            this.r_male.UseVisualStyleBackColor = true;
            // 
            // r_female
            // 
            this.r_female.AutoSize = true;
            this.r_female.Location = new System.Drawing.Point(138, 45);
            this.r_female.Name = "r_female";
            this.r_female.Size = new System.Drawing.Size(113, 33);
            this.r_female.TabIndex = 3;
            this.r_female.Text = "Female";
            this.r_female.UseVisualStyleBackColor = true;
            // 
            // r_other
            // 
            this.r_other.AutoSize = true;
            this.r_other.Location = new System.Drawing.Point(306, 45);
            this.r_other.Name = "r_other";
            this.r_other.Size = new System.Drawing.Size(91, 33);
            this.r_other.TabIndex = 3;
            this.r_other.Text = "Other";
            this.r_other.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.r_male);
            this.groupBox1.Controls.Add(this.r_other);
            this.groupBox1.Controls.Add(this.r_female);
            this.groupBox1.Location = new System.Drawing.Point(4, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(861, 174);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(147, 46);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // pic_box
            // 
            this.pic_box.Image = ((System.Drawing.Image)(resources.GetObject("pic_box.Image")));
            this.pic_box.Location = new System.Drawing.Point(520, 21);
            this.pic_box.Name = "pic_box";
            this.pic_box.Size = new System.Drawing.Size(265, 295);
            this.pic_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_box.TabIndex = 7;
            this.pic_box.TabStop = false;
            this.pic_box.Click += new System.EventHandler(this.pic_box_Click_1);
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
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(1000, 675);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(101, 23);
            this.btn_edit.TabIndex = 8;
            this.btn_edit.Text = "Go To Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 733);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.pic_box);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.data_gridView);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form1";
            this.Text = "mainForm";
            ((System.ComponentModel.ISupportInitialize)(this.data_gridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.DataGridView data_gridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.RadioButton r_male;
        private System.Windows.Forms.RadioButton r_female;
        private System.Windows.Forms.RadioButton r_other;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.PictureBox pic_box;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_address;
        private System.Windows.Forms.DataGridViewImageColumn col_pic;
        private System.Windows.Forms.Button btn_edit;
    }
}

