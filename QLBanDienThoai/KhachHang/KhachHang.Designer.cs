namespace QLBanDienThoai
{
    partial class KhachHang
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
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.tabPage_khachhang = new System.Windows.Forms.TabPage();
            this.dgv_KH = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_capnhat_KH = new System.Windows.Forms.Button();
            this.btn_luu_KH = new System.Windows.Forms.Button();
            this.btn_xoa_KH = new System.Windows.Forms.Button();
            this.btn_huy_KH = new System.Windows.Forms.Button();
            this.btn_them_KH = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.MTBox_sdt_KH = new System.Windows.Forms.MaskedTextBox();
            this.lb_them_KH = new System.Windows.Forms.Label();
            this.txtBox_tenkh_KH = new System.Windows.Forms.TextBox();
            this.txtBox_diachi_KH = new System.Windows.Forms.TextBox();
            this.txtBox_makh_KH = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl_Main.SuspendLayout();
            this.tabPage_khachhang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KH)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tabPage_khachhang);
            this.tabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Main.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControl_Main.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Main.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(962, 693);
            this.tabControl_Main.TabIndex = 1;
            // 
            // tabPage_khachhang
            // 
            this.tabPage_khachhang.Controls.Add(this.dgv_KH);
            this.tabPage_khachhang.Controls.Add(this.panel6);
            this.tabPage_khachhang.Controls.Add(this.panel5);
            this.tabPage_khachhang.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabPage_khachhang.Location = new System.Drawing.Point(4, 29);
            this.tabPage_khachhang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage_khachhang.Name = "tabPage_khachhang";
            this.tabPage_khachhang.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage_khachhang.Size = new System.Drawing.Size(954, 660);
            this.tabPage_khachhang.TabIndex = 2;
            this.tabPage_khachhang.Text = "   Khách Hàng   ";
            this.tabPage_khachhang.UseVisualStyleBackColor = true;
            // 
            // dgv_KH
            // 
            this.dgv_KH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_KH.Location = new System.Drawing.Point(2, 258);
            this.dgv_KH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_KH.Name = "dgv_KH";
            this.dgv_KH.RowHeadersWidth = 51;
            this.dgv_KH.RowTemplate.Height = 24;
            this.dgv_KH.Size = new System.Drawing.Size(950, 323);
            this.dgv_KH.TabIndex = 2;
            this.dgv_KH.Click += new System.EventHandler(this.dgv_KH_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_capnhat_KH);
            this.panel6.Controls.Add(this.btn_luu_KH);
            this.panel6.Controls.Add(this.btn_xoa_KH);
            this.panel6.Controls.Add(this.btn_huy_KH);
            this.panel6.Controls.Add(this.btn_them_KH);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(2, 581);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(950, 77);
            this.panel6.TabIndex = 1;
            // 
            // btn_capnhat_KH
            // 
            this.btn_capnhat_KH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_capnhat_KH.Location = new System.Drawing.Point(410, 20);
            this.btn_capnhat_KH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_capnhat_KH.Name = "btn_capnhat_KH";
            this.btn_capnhat_KH.Size = new System.Drawing.Size(112, 41);
            this.btn_capnhat_KH.TabIndex = 20;
            this.btn_capnhat_KH.Text = "Cập Nhật";
            this.btn_capnhat_KH.UseVisualStyleBackColor = true;
            this.btn_capnhat_KH.Click += new System.EventHandler(this.btn_capnhat_KH_Click);
            // 
            // btn_luu_KH
            // 
            this.btn_luu_KH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_luu_KH.Location = new System.Drawing.Point(593, 20);
            this.btn_luu_KH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_luu_KH.Name = "btn_luu_KH";
            this.btn_luu_KH.Size = new System.Drawing.Size(112, 41);
            this.btn_luu_KH.TabIndex = 21;
            this.btn_luu_KH.Text = "Lưu";
            this.btn_luu_KH.UseVisualStyleBackColor = true;
            this.btn_luu_KH.Click += new System.EventHandler(this.btn_luu_KH_Click);
            // 
            // btn_xoa_KH
            // 
            this.btn_xoa_KH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xoa_KH.Location = new System.Drawing.Point(227, 20);
            this.btn_xoa_KH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_xoa_KH.Name = "btn_xoa_KH";
            this.btn_xoa_KH.Size = new System.Drawing.Size(112, 41);
            this.btn_xoa_KH.TabIndex = 19;
            this.btn_xoa_KH.Text = "Xóa";
            this.btn_xoa_KH.UseVisualStyleBackColor = true;
            this.btn_xoa_KH.Click += new System.EventHandler(this.btn_xoa_KH_Click);
            // 
            // btn_huy_KH
            // 
            this.btn_huy_KH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_huy_KH.Location = new System.Drawing.Point(776, 20);
            this.btn_huy_KH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_huy_KH.Name = "btn_huy_KH";
            this.btn_huy_KH.Size = new System.Drawing.Size(112, 41);
            this.btn_huy_KH.TabIndex = 22;
            this.btn_huy_KH.Text = "Hủy";
            this.btn_huy_KH.UseVisualStyleBackColor = true;
            this.btn_huy_KH.Click += new System.EventHandler(this.btn_huy_KH_Click);
            // 
            // btn_them_KH
            // 
            this.btn_them_KH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_them_KH.Location = new System.Drawing.Point(44, 20);
            this.btn_them_KH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_them_KH.Name = "btn_them_KH";
            this.btn_them_KH.Size = new System.Drawing.Size(112, 41);
            this.btn_them_KH.TabIndex = 18;
            this.btn_them_KH.Text = "Thêm";
            this.btn_them_KH.UseVisualStyleBackColor = true;
            this.btn_them_KH.Click += new System.EventHandler(this.btn_them_KH_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.MTBox_sdt_KH);
            this.panel5.Controls.Add(this.lb_them_KH);
            this.panel5.Controls.Add(this.txtBox_tenkh_KH);
            this.panel5.Controls.Add(this.txtBox_diachi_KH);
            this.panel5.Controls.Add(this.txtBox_makh_KH);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(2, 2);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(950, 256);
            this.panel5.TabIndex = 0;
            // 
            // MTBox_sdt_KH
            // 
            this.MTBox_sdt_KH.Location = new System.Drawing.Point(587, 91);
            this.MTBox_sdt_KH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MTBox_sdt_KH.Mask = "999 000 0000";
            this.MTBox_sdt_KH.Name = "MTBox_sdt_KH";
            this.MTBox_sdt_KH.Size = new System.Drawing.Size(173, 32);
            this.MTBox_sdt_KH.TabIndex = 10;
            this.MTBox_sdt_KH.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lb_them_KH
            // 
            this.lb_them_KH.AutoSize = true;
            this.lb_them_KH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_them_KH.Location = new System.Drawing.Point(12, 228);
            this.lb_them_KH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_them_KH.Name = "lb_them_KH";
            this.lb_them_KH.Size = new System.Drawing.Size(0, 19);
            this.lb_them_KH.TabIndex = 9;
            // 
            // txtBox_tenkh_KH
            // 
            this.txtBox_tenkh_KH.Location = new System.Drawing.Point(273, 146);
            this.txtBox_tenkh_KH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBox_tenkh_KH.Name = "txtBox_tenkh_KH";
            this.txtBox_tenkh_KH.Size = new System.Drawing.Size(173, 32);
            this.txtBox_tenkh_KH.TabIndex = 8;
            // 
            // txtBox_diachi_KH
            // 
            this.txtBox_diachi_KH.Location = new System.Drawing.Point(587, 138);
            this.txtBox_diachi_KH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBox_diachi_KH.Multiline = true;
            this.txtBox_diachi_KH.Name = "txtBox_diachi_KH";
            this.txtBox_diachi_KH.Size = new System.Drawing.Size(173, 88);
            this.txtBox_diachi_KH.TabIndex = 6;
            // 
            // txtBox_makh_KH
            // 
            this.txtBox_makh_KH.Location = new System.Drawing.Point(273, 91);
            this.txtBox_makh_KH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBox_makh_KH.Name = "txtBox_makh_KH";
            this.txtBox_makh_KH.Size = new System.Drawing.Size(173, 32);
            this.txtBox_makh_KH.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(154, 154);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 19);
            this.label15.TabIndex = 4;
            this.label15.Text = "Tên Khách Hàng";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(478, 91);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 19);
            this.label14.TabIndex = 3;
            this.label14.Text = "Số Điện Thoại";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(518, 146);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 19);
            this.label13.TabIndex = 2;
            this.label13.Text = "Địa Chỉ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(154, 99);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 19);
            this.label12.TabIndex = 1;
            this.label12.Text = "Mã Khách Hàng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(338, 13);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(290, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(776, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 39);
            this.button1.TabIndex = 11;
            this.button1.Text = "In ds Khách hàng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 693);
            this.Controls.Add(this.tabControl_Main);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "KhachHang";
            this.Text = "KhachHang";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            this.tabControl_Main.ResumeLayout(false);
            this.tabPage_khachhang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KH)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TabPage tabPage_khachhang;
        private System.Windows.Forms.DataGridView dgv_KH;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_capnhat_KH;
        private System.Windows.Forms.Button btn_luu_KH;
        private System.Windows.Forms.Button btn_xoa_KH;
        private System.Windows.Forms.Button btn_huy_KH;
        private System.Windows.Forms.Button btn_them_KH;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.MaskedTextBox MTBox_sdt_KH;
        private System.Windows.Forms.Label lb_them_KH;
        private System.Windows.Forms.TextBox txtBox_tenkh_KH;
        private System.Windows.Forms.TextBox txtBox_diachi_KH;
        private System.Windows.Forms.TextBox txtBox_makh_KH;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
    }
}