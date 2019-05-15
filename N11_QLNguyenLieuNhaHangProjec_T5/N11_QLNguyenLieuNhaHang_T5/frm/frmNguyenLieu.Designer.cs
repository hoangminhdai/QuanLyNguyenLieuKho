namespace N11_QLNguyenLieuNhaHang_T5.frm
{
    partial class frmNguyenLieu
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
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericSoLuong = new System.Windows.Forms.NumericUpDown();
            this.numeriGiaTien = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_DonVi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_TenNL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.tb_TimKiem = new System.Windows.Forms.TextBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewNguyenLieu = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeriGiaTien)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNguyenLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(575, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 24);
            this.label7.TabIndex = 37;
            this.label7.Text = "Thông Tin Nguyên Liệu";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.numericSoLuong);
            this.panel2.Controls.Add(this.numeriGiaTien);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tb_DonVi);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tb_TenNL);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(579, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 188);
            this.panel2.TabIndex = 36;
            // 
            // numericSoLuong
            // 
            this.numericSoLuong.Location = new System.Drawing.Point(92, 96);
            this.numericSoLuong.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericSoLuong.Name = "numericSoLuong";
            this.numericSoLuong.Size = new System.Drawing.Size(118, 20);
            this.numericSoLuong.TabIndex = 16;
            this.numericSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numeriGiaTien
            // 
            this.numeriGiaTien.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numeriGiaTien.Location = new System.Drawing.Point(92, 55);
            this.numeriGiaTien.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numeriGiaTien.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numeriGiaTien.Name = "numeriGiaTien";
            this.numeriGiaTien.Size = new System.Drawing.Size(118, 20);
            this.numeriGiaTien.TabIndex = 16;
            this.numeriGiaTien.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên nguyên liệu";
            // 
            // tb_DonVi
            // 
            this.tb_DonVi.Location = new System.Drawing.Point(92, 138);
            this.tb_DonVi.Name = "tb_DonVi";
            this.tb_DonVi.Size = new System.Drawing.Size(118, 20);
            this.tb_DonVi.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Đơn Vị";
            // 
            // tb_TenNL
            // 
            this.tb_TenNL.Location = new System.Drawing.Point(92, 20);
            this.tb_TenNL.Name = "tb_TenNL";
            this.tb_TenNL.Size = new System.Drawing.Size(118, 20);
            this.tb_TenNL.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Số Lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 35;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btn_Them);
            this.panel1.Controls.Add(this.btn_Sua);
            this.panel1.Controls.Add(this.btn_Xoa);
            this.panel1.Location = new System.Drawing.Point(576, 331);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 43);
            this.panel1.TabIndex = 34;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(3, 16);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 1;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(79, 16);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 3;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(156, 16);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 4;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // tb_TimKiem
            // 
            this.tb_TimKiem.Location = new System.Drawing.Point(39, 110);
            this.tb_TimKiem.Name = "tb_TimKiem";
            this.tb_TimKiem.Size = new System.Drawing.Size(424, 20);
            this.tb_TimKiem.TabIndex = 32;
            this.tb_TimKiem.Text = "tìm kiếm theo tên nguyên liệu";
            this.tb_TimKiem.Click += new System.EventHandler(this.tb_TimKiem_Click);
            this.tb_TimKiem.TextChanged += new System.EventHandler(this.tb_TimKiem_TextChanged);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.Coral;
            this.btn_Thoat.Location = new System.Drawing.Point(753, 413);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 31;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(211, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 31);
            this.label1.TabIndex = 30;
            this.label1.Text = "Quản Lý Nguyên Liệu Khô";
            // 
            // dataGridViewNguyenLieu
            // 
            this.dataGridViewNguyenLieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNguyenLieu.Location = new System.Drawing.Point(3, 149);
            this.dataGridViewNguyenLieu.Name = "dataGridViewNguyenLieu";
            this.dataGridViewNguyenLieu.Size = new System.Drawing.Size(561, 296);
            this.dataGridViewNguyenLieu.TabIndex = 29;
            this.dataGridViewNguyenLieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNguyenLieu_CellContentClick);
            this.dataGridViewNguyenLieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNguyenLieu_CellContentClick);
            this.dataGridViewNguyenLieu.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridViewNguyenLieu_KeyUp);
            // 
            // frmNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 475);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_TimKiem);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewNguyenLieu);
            this.Name = "frmNguyenLieu";
            this.Text = "frmNguyenLieu";
            this.Load += new System.EventHandler(this.frmNguyenLieu_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeriGiaTien)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNguyenLieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_DonVi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_TenNL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.TextBox tb_TimKiem;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewNguyenLieu;
        private System.Windows.Forms.NumericUpDown numericSoLuong;
        private System.Windows.Forms.NumericUpDown numeriGiaTien;
    }
}