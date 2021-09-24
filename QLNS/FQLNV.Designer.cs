
namespace QLNS
{
    partial class FQLNV
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
            this.lbQLNV = new System.Windows.Forms.Label();
            this.btTaoNV = new System.Windows.Forms.Button();
            this.btSuaNV = new System.Windows.Forms.Button();
            this.btDangXuat = new System.Windows.Forms.Button();
            this.gBChucNang = new System.Windows.Forms.GroupBox();
            this.btTraCuu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTenNV = new System.Windows.Forms.ComboBox();
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lbMail = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.lbChucVu = new System.Windows.Forms.Label();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gvNV = new System.Windows.Forms.DataGridView();
            this.gBChucNang.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvNV)).BeginInit();
            this.SuspendLayout();
            // 
            // lbQLNV
            // 
            this.lbQLNV.AutoSize = true;
            this.lbQLNV.Font = new System.Drawing.Font("Georgia", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQLNV.ForeColor = System.Drawing.Color.Red;
            this.lbQLNV.Location = new System.Drawing.Point(291, 26);
            this.lbQLNV.Name = "lbQLNV";
            this.lbQLNV.Size = new System.Drawing.Size(440, 48);
            this.lbQLNV.TabIndex = 0;
            this.lbQLNV.Text = "Quản Lý Nhân Viên";
            this.lbQLNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btTaoNV
            // 
            this.btTaoNV.AutoSize = true;
            this.btTaoNV.FlatAppearance.BorderSize = 2;
            this.btTaoNV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btTaoNV.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTaoNV.Location = new System.Drawing.Point(32, 21);
            this.btTaoNV.Name = "btTaoNV";
            this.btTaoNV.Size = new System.Drawing.Size(153, 70);
            this.btTaoNV.TabIndex = 1;
            this.btTaoNV.Text = "Tạo Nhân Viên";
            this.btTaoNV.UseVisualStyleBackColor = true;
            // 
            // btSuaNV
            // 
            this.btSuaNV.AutoSize = true;
            this.btSuaNV.FlatAppearance.BorderSize = 2;
            this.btSuaNV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btSuaNV.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuaNV.Location = new System.Drawing.Point(209, 21);
            this.btSuaNV.Name = "btSuaNV";
            this.btSuaNV.Size = new System.Drawing.Size(112, 70);
            this.btSuaNV.TabIndex = 2;
            this.btSuaNV.Text = "Sửa ";
            this.btSuaNV.UseVisualStyleBackColor = true;
            // 
            // btDangXuat
            // 
            this.btDangXuat.AutoSize = true;
            this.btDangXuat.FlatAppearance.BorderSize = 2;
            this.btDangXuat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btDangXuat.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDangXuat.Location = new System.Drawing.Point(492, 21);
            this.btDangXuat.Name = "btDangXuat";
            this.btDangXuat.Size = new System.Drawing.Size(137, 70);
            this.btDangXuat.TabIndex = 3;
            this.btDangXuat.Text = "Đăng xuất";
            this.btDangXuat.UseVisualStyleBackColor = true;
            this.btDangXuat.Click += new System.EventHandler(this.btDangXuat_Click);
            // 
            // gBChucNang
            // 
            this.gBChucNang.Controls.Add(this.btTraCuu);
            this.gBChucNang.Controls.Add(this.btDangXuat);
            this.gBChucNang.Controls.Add(this.btTaoNV);
            this.gBChucNang.Controls.Add(this.btSuaNV);
            this.gBChucNang.Location = new System.Drawing.Point(299, 348);
            this.gBChucNang.Name = "gBChucNang";
            this.gBChucNang.Size = new System.Drawing.Size(657, 105);
            this.gBChucNang.TabIndex = 4;
            this.gBChucNang.TabStop = false;
            // 
            // btTraCuu
            // 
            this.btTraCuu.AutoSize = true;
            this.btTraCuu.FlatAppearance.BorderSize = 2;
            this.btTraCuu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btTraCuu.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTraCuu.Location = new System.Drawing.Point(352, 21);
            this.btTraCuu.Name = "btTraCuu";
            this.btTraCuu.Size = new System.Drawing.Size(112, 70);
            this.btTraCuu.TabIndex = 4;
            this.btTraCuu.Text = "Tra Cứu";
            this.btTraCuu.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTenNV);
            this.groupBox1.Controls.Add(this.cbChucVu);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.lbMail);
            this.groupBox1.Controls.Add(this.lbSDT);
            this.groupBox1.Controls.Add(this.lbDiaChi);
            this.groupBox1.Controls.Add(this.lbMaNV);
            this.groupBox1.Controls.Add(this.lbChucVu);
            this.groupBox1.Controls.Add(this.lbTenNV);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(98, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 187);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // cbTenNV
            // 
            this.cbTenNV.FormattingEnabled = true;
            this.cbTenNV.Location = new System.Drawing.Point(218, 94);
            this.cbTenNV.Name = "cbTenNV";
            this.cbTenNV.Size = new System.Drawing.Size(199, 24);
            this.cbTenNV.TabIndex = 12;
            // 
            // cbChucVu
            // 
            this.cbChucVu.FormattingEnabled = true;
            this.cbChucVu.Location = new System.Drawing.Point(218, 143);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(199, 24);
            this.cbChucVu.TabIndex = 11;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(654, 143);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(190, 23);
            this.txtMail.TabIndex = 10;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(654, 95);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(190, 23);
            this.txtSDT.TabIndex = 9;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(654, 46);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(190, 23);
            this.txtDiaChi.TabIndex = 8;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(218, 46);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(121, 23);
            this.txtMaNV.TabIndex = 6;
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMail.Location = new System.Drawing.Point(503, 146);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(61, 17);
            this.lbMail.TabIndex = 5;
            this.lbMail.Text = "E-mail:";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDT.Location = new System.Drawing.Point(503, 98);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(111, 17);
            this.lbSDT.TabIndex = 4;
            this.lbSDT.Text = "Số điện thoại:";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.Location = new System.Drawing.Point(503, 52);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(62, 17);
            this.lbDiaChi.TabIndex = 3;
            this.lbDiaChi.Text = "Địa chỉ:";
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNV.Location = new System.Drawing.Point(56, 52);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(113, 17);
            this.lbMaNV.TabIndex = 2;
            this.lbMaNV.Text = "Mã nhân viên:";
            // 
            // lbChucVu
            // 
            this.lbChucVu.AutoSize = true;
            this.lbChucVu.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChucVu.Location = new System.Drawing.Point(56, 146);
            this.lbChucVu.Name = "lbChucVu";
            this.lbChucVu.Size = new System.Drawing.Size(72, 17);
            this.lbChucVu.TabIndex = 1;
            this.lbChucVu.Text = "Chức vụ:";
            // 
            // lbTenNV
            // 
            this.lbTenNV.AutoSize = true;
            this.lbTenNV.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNV.Location = new System.Drawing.Point(56, 98);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(120, 17);
            this.lbTenNV.TabIndex = 0;
            this.lbTenNV.Text = "Tên nhân viên:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gvNV);
            this.groupBox2.Location = new System.Drawing.Point(65, 485);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(942, 330);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chung";
            // 
            // gvNV
            // 
            this.gvNV.AllowUserToOrderColumns = true;
            this.gvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvNV.Location = new System.Drawing.Point(6, 21);
            this.gvNV.Name = "gvNV";
            this.gvNV.RowHeadersWidth = 51;
            this.gvNV.RowTemplate.Height = 24;
            this.gvNV.Size = new System.Drawing.Size(930, 303);
            this.gvNV.TabIndex = 9;
            // 
            // FQLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 840);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gBChucNang);
            this.Controls.Add(this.lbQLNV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FQLNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FQLNV";
            this.gBChucNang.ResumeLayout(false);
            this.gBChucNang.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbQLNV;
        private System.Windows.Forms.Button btTaoNV;
        private System.Windows.Forms.Button btSuaNV;
        private System.Windows.Forms.Button btDangXuat;
        private System.Windows.Forms.GroupBox gBChucNang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Label lbChucVu;
        private System.Windows.Forms.Label lbTenNV;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.ComboBox cbChucVu;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.ComboBox cbTenNV;
        private System.Windows.Forms.Button btTraCuu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gvNV;
    }
}

