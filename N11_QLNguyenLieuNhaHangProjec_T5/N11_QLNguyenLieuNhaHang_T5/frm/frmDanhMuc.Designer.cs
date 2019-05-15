namespace N11_QLNguyenLieuNhaHang_T5.frm
{
    partial class frmDanhMuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhMuc));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đặtNguyênLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTenNhanVien = new System.Windows.Forms.Label();
            this.labelNV = new System.Windows.Forms.Label();
            this.quảnLýHóaĐơnNhậpNguyêLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1186, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNhàCungCấpToolStripMenuItem,
            this.đặtNguyênLiệuToolStripMenuItem,
            this.quảnLýHóaĐơnNhậpNguyêLiệuToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.danhMụcToolStripMenuItem.Text = "MENU";
            // 
            // quảnLýNhàCungCấpToolStripMenuItem
            // 
            this.quảnLýNhàCungCấpToolStripMenuItem.Name = "quảnLýNhàCungCấpToolStripMenuItem";
            this.quảnLýNhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.quảnLýNhàCungCấpToolStripMenuItem.Text = "Danh mục quản lý nguyên liệu khô";
            this.quảnLýNhàCungCấpToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhàCungCấpToolStripMenuItem_Click);
            // 
            // đặtNguyênLiệuToolStripMenuItem
            // 
            this.đặtNguyênLiệuToolStripMenuItem.Name = "đặtNguyênLiệuToolStripMenuItem";
            this.đặtNguyênLiệuToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.đặtNguyênLiệuToolStripMenuItem.Text = "Nhập nguyên liệu khô";
            this.đặtNguyênLiệuToolStripMenuItem.Click += new System.EventHandler(this.đặtNguyênLiệuToolStripMenuItem_Click);
            // 
            // labelTenNhanVien
            // 
            this.labelTenNhanVien.AutoSize = true;
            this.labelTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenNhanVien.Location = new System.Drawing.Point(675, 549);
            this.labelTenNhanVien.Name = "labelTenNhanVien";
            this.labelTenNhanVien.Size = new System.Drawing.Size(0, 20);
            this.labelTenNhanVien.TabIndex = 13;
            // 
            // labelNV
            // 
            this.labelNV.AutoSize = true;
            this.labelNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNV.Location = new System.Drawing.Point(679, 6);
            this.labelNV.Name = "labelNV";
            this.labelNV.Size = new System.Drawing.Size(0, 18);
            this.labelNV.TabIndex = 14;
            // 
            // quảnLýHóaĐơnNhậpNguyêLiệuToolStripMenuItem
            // 
            this.quảnLýHóaĐơnNhậpNguyêLiệuToolStripMenuItem.Name = "quảnLýHóaĐơnNhậpNguyêLiệuToolStripMenuItem";
            this.quảnLýHóaĐơnNhậpNguyêLiệuToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.quảnLýHóaĐơnNhậpNguyêLiệuToolStripMenuItem.Text = "Quản Lý Hóa Đơn Nhập Nguyê Liệu";
            this.quảnLýHóaĐơnNhậpNguyêLiệuToolStripMenuItem.Click += new System.EventHandler(this.quảnLýHóaĐơnNhậpNguyêLiệuToolStripMenuItem_Click);
            // 
            // frmDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1186, 796);
            this.Controls.Add(this.labelNV);
            this.Controls.Add(this.labelTenNhanVien);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDanhMuc";
            this.Text = "PHẦN MỀM QUẢN LÝ NGUYÊN LIỆU KHÔ";
            this.Load += new System.EventHandler(this.frmDanhMuc_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đặtNguyênLiệuToolStripMenuItem;
        private System.Windows.Forms.Label labelTenNhanVien;
        private System.Windows.Forms.Label labelNV;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHóaĐơnNhậpNguyêLiệuToolStripMenuItem;
    }
}