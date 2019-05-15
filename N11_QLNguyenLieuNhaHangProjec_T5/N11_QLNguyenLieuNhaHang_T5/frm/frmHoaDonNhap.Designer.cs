namespace N11_QLNguyenLieuNhaHang_T5.frm
{
    partial class frmHoaDonNhap
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
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_NguyenLieu = new System.Windows.Forms.ComboBox();
            this.numericSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.numeriGiaTien = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewHoaDon = new System.Windows.Forms.DataGridView();
            this.comboBox_MaHoaDon = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button_CapNhat = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_XuatHDN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeriGiaTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(12, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 18);
            this.label7.TabIndex = 46;
            this.label7.Text = "Thông Tin hóa đơn";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btn_Xoa);
            this.panel2.Controls.Add(this.btn_Sua);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.comboBox_NguyenLieu);
            this.panel2.Controls.Add(this.numericSoLuong);
            this.panel2.Controls.Add(this.numeriGiaTien);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(839, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 272);
            this.panel2.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(13, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 18);
            this.label9.TabIndex = 48;
            this.label9.Text = "Thông Tin Chi Tiết hóa đơn";
            // 
            // comboBox_NguyenLieu
            // 
            this.comboBox_NguyenLieu.FormattingEnabled = true;
            this.comboBox_NguyenLieu.Location = new System.Drawing.Point(104, 60);
            this.comboBox_NguyenLieu.Name = "comboBox_NguyenLieu";
            this.comboBox_NguyenLieu.Size = new System.Drawing.Size(121, 21);
            this.comboBox_NguyenLieu.TabIndex = 47;
            // 
            // numericSoLuong
            // 
            this.numericSoLuong.Location = new System.Drawing.Point(104, 136);
            this.numericSoLuong.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericSoLuong.Name = "numericSoLuong";
            this.numericSoLuong.Size = new System.Drawing.Size(118, 20);
            this.numericSoLuong.TabIndex = 16;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(89, 175);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 3;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(170, 175);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 4;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // numeriGiaTien
            // 
            this.numeriGiaTien.Location = new System.Drawing.Point(104, 95);
            this.numeriGiaTien.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numeriGiaTien.Name = "numeriGiaTien";
            this.numeriGiaTien.Size = new System.Drawing.Size(118, 20);
            this.numeriGiaTien.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã nguyên liệu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Đơn giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Số Lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 44;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.ForeColor = System.Drawing.Color.Coral;
            this.btn_Thoat.Location = new System.Drawing.Point(1001, 465);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 40;
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
            this.label1.Location = new System.Drawing.Point(265, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 31);
            this.label1.TabIndex = 39;
            this.label1.Text = "Quản Lý hóa đơn nhập nguyên liệu khô";
            // 
            // dataGridViewHoaDon
            // 
            this.dataGridViewHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHoaDon.Location = new System.Drawing.Point(12, 162);
            this.dataGridViewHoaDon.Name = "dataGridViewHoaDon";
            this.dataGridViewHoaDon.Size = new System.Drawing.Size(741, 296);
            this.dataGridViewHoaDon.TabIndex = 38;
            this.dataGridViewHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHoaDon_CellClick);
            // 
            // comboBox_MaHoaDon
            // 
            this.comboBox_MaHoaDon.FormattingEnabled = true;
            this.comboBox_MaHoaDon.Location = new System.Drawing.Point(465, 57);
            this.comboBox_MaHoaDon.Name = "comboBox_MaHoaDon";
            this.comboBox_MaHoaDon.Size = new System.Drawing.Size(58, 21);
            this.comboBox_MaHoaDon.TabIndex = 46;
            this.comboBox_MaHoaDon.SelectedIndexChanged += new System.EventHandler(this.comboBox_MaHoaDon_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(315, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 16);
            this.label8.TabIndex = 47;
            this.label8.Text = "Chọn Mã Hóa Đơn:";
            // 
            // button_CapNhat
            // 
            this.button_CapNhat.Location = new System.Drawing.Point(529, 57);
            this.button_CapNhat.Name = "button_CapNhat";
            this.button_CapNhat.Size = new System.Drawing.Size(107, 23);
            this.button_CapNhat.TabIndex = 48;
            this.button_CapNhat.Text = "Cập nhật hóa đơn";
            this.button_CapNhat.UseVisualStyleBackColor = true;
            this.button_CapNhat.Click += new System.EventHandler(this.button_CapNhat_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Xoa.ForeColor = System.Drawing.Color.Red;
            this.button_Xoa.Location = new System.Drawing.Point(12, 475);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(129, 23);
            this.button_Xoa.TabIndex = 49;
            this.button_Xoa.Text = "Xóa Hóa Đơn Này";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_XuatHDN
            // 
            this.button_XuatHDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_XuatHDN.ForeColor = System.Drawing.Color.Red;
            this.button_XuatHDN.Location = new System.Drawing.Point(303, 475);
            this.button_XuatHDN.Name = "button_XuatHDN";
            this.button_XuatHDN.Size = new System.Drawing.Size(129, 23);
            this.button_XuatHDN.TabIndex = 50;
            this.button_XuatHDN.Text = "Xuất Hóa Đơn";
            this.button_XuatHDN.UseVisualStyleBackColor = true;
            this.button_XuatHDN.Click += new System.EventHandler(this.button_XuatHDN_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(624, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 51;
            this.button1.Text = "Tạo Hóa Đơn Mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 556);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_XuatHDN);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button_CapNhat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox_MaHoaDon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewHoaDon);
            this.Name = "frmHoaDonNhap";
            this.Text = "frmHoaDonNhap";
            this.Load += new System.EventHandler(this.frmHoaDonNhap_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeriGiaTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numericSoLuong;
        private System.Windows.Forms.NumericUpDown numeriGiaTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewHoaDon;
        private System.Windows.Forms.ComboBox comboBox_NguyenLieu;
        private System.Windows.Forms.ComboBox comboBox_MaHoaDon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_CapNhat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_XuatHDN;
        private System.Windows.Forms.Button button1;
    }
}