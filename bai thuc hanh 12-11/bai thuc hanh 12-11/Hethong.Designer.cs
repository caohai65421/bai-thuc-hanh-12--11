namespace bai_thuc_hanh_12_11
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hethong = new System.Windows.Forms.ToolStripMenuItem();
            this.quanlysach = new System.Windows.Forms.ToolStripMenuItem();
            this.dangnhap = new System.Windows.Forms.ToolStripMenuItem();
            this.thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.loaisach = new System.Windows.Forms.ToolStripMenuItem();
            this.sach = new System.Windows.Forms.ToolStripMenuItem();
            this.quanlyhoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.hoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.trogiup = new System.Windows.Forms.ToolStripMenuItem();
            this.gioithieu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hethong,
            this.quanlysach,
            this.quanlyhoadon,
            this.trogiup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // hethong
            // 
            this.hethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dangnhap,
            this.thoat});
            this.hethong.Name = "hethong";
            this.hethong.Size = new System.Drawing.Size(85, 24);
            this.hethong.Text = "Hệ thống";
            this.hethong.Click += new System.EventHandler(this.hethong_Click);
            // 
            // quanlysach
            // 
            this.quanlysach.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loaisach,
            this.sach});
            this.quanlysach.Name = "quanlysach";
            this.quanlysach.Size = new System.Drawing.Size(110, 24);
            this.quanlysach.Text = "Quản Lý Sách";
            // 
            // dangnhap
            // 
            this.dangnhap.Name = "dangnhap";
            this.dangnhap.Size = new System.Drawing.Size(224, 26);
            this.dangnhap.Text = "Đăng nhập";
            this.dangnhap.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
            // 
            // thoat
            // 
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(224, 26);
            this.thoat.Text = "Thoát";
            this.thoat.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // loaisach
            // 
            this.loaisach.Name = "loaisach";
            this.loaisach.Size = new System.Drawing.Size(224, 26);
            this.loaisach.Text = "Loại Sách";
            this.loaisach.Click += new System.EventHandler(this.loạiSáchToolStripMenuItem_Click);
            // 
            // sach
            // 
            this.sach.Name = "sach";
            this.sach.Size = new System.Drawing.Size(224, 26);
            this.sach.Text = "Sách";
            this.sach.Click += new System.EventHandler(this.sáchToolStripMenuItem_Click);
            // 
            // quanlyhoadon
            // 
            this.quanlyhoadon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hoadon});
            this.quanlyhoadon.Name = "quanlyhoadon";
            this.quanlyhoadon.Size = new System.Drawing.Size(139, 24);
            this.quanlyhoadon.Text = "Quản Lý Hóa Đơn";
            // 
            // hoadon
            // 
            this.hoadon.Name = "hoadon";
            this.hoadon.Size = new System.Drawing.Size(224, 26);
            this.hoadon.Text = " Hóa Đơn";
            this.hoadon.Click += new System.EventHandler(this.hóaĐơnToolStripMenuItem_Click);
            // 
            // trogiup
            // 
            this.trogiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gioithieu});
            this.trogiup.Name = "trogiup";
            this.trogiup.Size = new System.Drawing.Size(79, 24);
            this.trogiup.Text = "Trợ Giúp";
            // 
            // gioithieu
            // 
            this.gioithieu.Name = "gioithieu";
            this.gioithieu.Size = new System.Drawing.Size(224, 26);
            this.gioithieu.Text = " Giới Thiệu";
            this.gioithieu.Click += new System.EventHandler(this.giớiThiệuToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Hệ thống";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hethong;
        private System.Windows.Forms.ToolStripMenuItem quanlysach;
        private System.Windows.Forms.ToolStripMenuItem dangnhap;
        private System.Windows.Forms.ToolStripMenuItem thoat;
        private System.Windows.Forms.ToolStripMenuItem loaisach;
        private System.Windows.Forms.ToolStripMenuItem sach;
        private System.Windows.Forms.ToolStripMenuItem quanlyhoadon;
        private System.Windows.Forms.ToolStripMenuItem hoadon;
        private System.Windows.Forms.ToolStripMenuItem trogiup;
        private System.Windows.Forms.ToolStripMenuItem gioithieu;
    }
}

