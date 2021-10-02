
namespace QLNS
{
    partial class FSP
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
            this.lbCTSP = new System.Windows.Forms.Label();
            this.gBCTSP = new System.Windows.Forms.GroupBox();
            this.txtMasp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNhaCC = new System.Windows.Forms.ComboBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.lbGiaBan = new System.Windows.Forms.Label();
            this.dPNgayNhapHang = new System.Windows.Forms.DateTimePicker();
            this.lbNgayNhapHang = new System.Windows.Forms.Label();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.cbLoaiSP = new System.Windows.Forms.ComboBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.lbNhaCC = new System.Windows.Forms.Label();
            this.lbLoaiSP = new System.Windows.Forms.Label();
            this.lbTenSP = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gvSP = new System.Windows.Forms.DataGridView();
            this.gBChucNang = new System.Windows.Forms.GroupBox();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btLuuSP = new System.Windows.Forms.Button();
            this.erTenSP = new System.Windows.Forms.ErrorProvider(this.components);
            this.erGiaBan = new System.Windows.Forms.ErrorProvider(this.components);
            this.erSL = new System.Windows.Forms.ErrorProvider(this.components);
            this.gBCTSP.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSP)).BeginInit();
            this.gBChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erTenSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erGiaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erSL)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCTSP
            // 
            this.lbCTSP.AutoSize = true;
            this.lbCTSP.Font = new System.Drawing.Font("Times New Roman", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCTSP.ForeColor = System.Drawing.Color.DarkRed;
            this.lbCTSP.Location = new System.Drawing.Point(331, 24);
            this.lbCTSP.Name = "lbCTSP";
            this.lbCTSP.Size = new System.Drawing.Size(417, 49);
            this.lbCTSP.TabIndex = 3;
            this.lbCTSP.Text = "Thông Tin Sản Phẩm";
            this.lbCTSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gBCTSP
            // 
            this.gBCTSP.Controls.Add(this.txtMasp);
            this.gBCTSP.Controls.Add(this.label1);
            this.gBCTSP.Controls.Add(this.cbNhaCC);
            this.gBCTSP.Controls.Add(this.txtGiaBan);
            this.gBCTSP.Controls.Add(this.txtSL);
            this.gBCTSP.Controls.Add(this.lbGiaBan);
            this.gBCTSP.Controls.Add(this.dPNgayNhapHang);
            this.gBCTSP.Controls.Add(this.lbNgayNhapHang);
            this.gBCTSP.Controls.Add(this.lbSoLuong);
            this.gBCTSP.Controls.Add(this.cbLoaiSP);
            this.gBCTSP.Controls.Add(this.txtTenSP);
            this.gBCTSP.Controls.Add(this.lbNhaCC);
            this.gBCTSP.Controls.Add(this.lbLoaiSP);
            this.gBCTSP.Controls.Add(this.lbTenSP);
            this.gBCTSP.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBCTSP.Location = new System.Drawing.Point(105, 117);
            this.gBCTSP.Name = "gBCTSP";
            this.gBCTSP.Size = new System.Drawing.Size(872, 274);
            this.gBCTSP.TabIndex = 8;
            this.gBCTSP.TabStop = false;
            this.gBCTSP.Text = "Thông tin chi tiết";
            // 
            // txtMasp
            // 
            this.txtMasp.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMasp.Location = new System.Drawing.Point(662, 64);
            this.txtMasp.Name = "txtMasp";
            this.txtMasp.Size = new System.Drawing.Size(142, 27);
            this.txtMasp.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(510, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã sản phẩm:";
            // 
            // cbNhaCC
            // 
            this.cbNhaCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNhaCC.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNhaCC.FormattingEnabled = true;
            this.cbNhaCC.Location = new System.Drawing.Point(662, 115);
            this.cbNhaCC.Name = "cbNhaCC";
            this.cbNhaCC.Size = new System.Drawing.Size(200, 27);
            this.cbNhaCC.TabIndex = 24;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBan.Location = new System.Drawing.Point(216, 169);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(200, 27);
            this.txtGiaBan.TabIndex = 23;
            this.txtGiaBan.TextChanged += new System.EventHandler(this.txtGiaBan_TextChanged);
            this.txtGiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaBan_KeyPress);
            // 
            // txtSL
            // 
            this.txtSL.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSL.Location = new System.Drawing.Point(216, 222);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(200, 27);
            this.txtSL.TabIndex = 22;
            this.txtSL.TextChanged += new System.EventHandler(this.txtSL_TextChanged);
            this.txtSL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSL_KeyPress);
            // 
            // lbGiaBan
            // 
            this.lbGiaBan.AutoSize = true;
            this.lbGiaBan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaBan.Location = new System.Drawing.Point(56, 172);
            this.lbGiaBan.Name = "lbGiaBan";
            this.lbGiaBan.Size = new System.Drawing.Size(73, 19);
            this.lbGiaBan.TabIndex = 20;
            this.lbGiaBan.Text = "Giá bán:";
            // 
            // dPNgayNhapHang
            // 
            this.dPNgayNhapHang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dPNgayNhapHang.Location = new System.Drawing.Point(662, 164);
            this.dPNgayNhapHang.Name = "dPNgayNhapHang";
            this.dPNgayNhapHang.Size = new System.Drawing.Size(200, 27);
            this.dPNgayNhapHang.TabIndex = 18;
            // 
            // lbNgayNhapHang
            // 
            this.lbNgayNhapHang.AutoSize = true;
            this.lbNgayNhapHang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayNhapHang.Location = new System.Drawing.Point(510, 172);
            this.lbNgayNhapHang.Name = "lbNgayNhapHang";
            this.lbNgayNhapHang.Size = new System.Drawing.Size(130, 19);
            this.lbNgayNhapHang.TabIndex = 13;
            this.lbNgayNhapHang.Text = "Ngày nhập hàng:";
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuong.Location = new System.Drawing.Point(56, 222);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(80, 19);
            this.lbSoLuong.TabIndex = 12;
            this.lbSoLuong.Text = "Số lượng:";
            // 
            // cbLoaiSP
            // 
            this.cbLoaiSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiSP.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiSP.FormattingEnabled = true;
            this.cbLoaiSP.Location = new System.Drawing.Point(218, 115);
            this.cbLoaiSP.Name = "cbLoaiSP";
            this.cbLoaiSP.Size = new System.Drawing.Size(200, 27);
            this.cbLoaiSP.TabIndex = 11;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSP.Location = new System.Drawing.Point(216, 61);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(200, 27);
            this.txtTenSP.TabIndex = 7;
            this.txtTenSP.TextChanged += new System.EventHandler(this.txtTenSP_TextChanged);
            // 
            // lbNhaCC
            // 
            this.lbNhaCC.AutoSize = true;
            this.lbNhaCC.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhaCC.Location = new System.Drawing.Point(510, 115);
            this.lbNhaCC.Name = "lbNhaCC";
            this.lbNhaCC.Size = new System.Drawing.Size(112, 19);
            this.lbNhaCC.TabIndex = 3;
            this.lbNhaCC.Text = "Nhà cung cấp:";
            // 
            // lbLoaiSP
            // 
            this.lbLoaiSP.AutoSize = true;
            this.lbLoaiSP.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiSP.Location = new System.Drawing.Point(56, 115);
            this.lbLoaiSP.Name = "lbLoaiSP";
            this.lbLoaiSP.Size = new System.Drawing.Size(121, 19);
            this.lbLoaiSP.TabIndex = 1;
            this.lbLoaiSP.Text = "Loại sản phẩm:";
            // 
            // lbTenSP
            // 
            this.lbTenSP.AutoSize = true;
            this.lbTenSP.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenSP.Location = new System.Drawing.Point(56, 67);
            this.lbTenSP.Name = "lbTenSP";
            this.lbTenSP.Size = new System.Drawing.Size(114, 19);
            this.lbTenSP.TabIndex = 0;
            this.lbTenSP.Text = "Tên sản phẩm:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gvSP);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(59, 548);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(942, 280);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chung";
            // 
            // gvSP
            // 
            this.gvSP.AllowUserToOrderColumns = true;
            this.gvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSP.Location = new System.Drawing.Point(6, 21);
            this.gvSP.Name = "gvSP";
            this.gvSP.RowHeadersWidth = 51;
            this.gvSP.RowTemplate.Height = 24;
            this.gvSP.Size = new System.Drawing.Size(930, 253);
            this.gvSP.TabIndex = 9;
            this.gvSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSP_CellClick);
            // 
            // gBChucNang
            // 
            this.gBChucNang.Controls.Add(this.btXoa);
            this.gBChucNang.Controls.Add(this.btSua);
            this.gBChucNang.Controls.Add(this.btThoat);
            this.gBChucNang.Controls.Add(this.btLuuSP);
            this.gBChucNang.Location = new System.Drawing.Point(368, 419);
            this.gBChucNang.Name = "gBChucNang";
            this.gBChucNang.Size = new System.Drawing.Size(599, 105);
            this.gBChucNang.TabIndex = 13;
            this.gBChucNang.TabStop = false;
            // 
            // btXoa
            // 
            this.btXoa.AutoSize = true;
            this.btXoa.BackColor = System.Drawing.Color.Firebrick;
            this.btXoa.FlatAppearance.BorderSize = 2;
            this.btXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.White;
            this.btXoa.Location = new System.Drawing.Point(324, 21);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(103, 70);
            this.btXoa.TabIndex = 5;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.AutoSize = true;
            this.btSua.BackColor = System.Drawing.Color.Firebrick;
            this.btSua.FlatAppearance.BorderSize = 2;
            this.btSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.ForeColor = System.Drawing.Color.White;
            this.btSua.Location = new System.Drawing.Point(174, 21);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(103, 70);
            this.btSua.TabIndex = 4;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThoat
            // 
            this.btThoat.AutoSize = true;
            this.btThoat.BackColor = System.Drawing.Color.Firebrick;
            this.btThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btThoat.FlatAppearance.BorderSize = 2;
            this.btThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.ForeColor = System.Drawing.Color.White;
            this.btThoat.Location = new System.Drawing.Point(470, 21);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(119, 70);
            this.btThoat.TabIndex = 3;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btLuuSP
            // 
            this.btLuuSP.AutoSize = true;
            this.btLuuSP.BackColor = System.Drawing.Color.Firebrick;
            this.btLuuSP.FlatAppearance.BorderSize = 2;
            this.btLuuSP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btLuuSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuuSP.ForeColor = System.Drawing.Color.White;
            this.btLuuSP.Location = new System.Drawing.Point(29, 21);
            this.btLuuSP.Name = "btLuuSP";
            this.btLuuSP.Size = new System.Drawing.Size(103, 70);
            this.btLuuSP.TabIndex = 1;
            this.btLuuSP.Text = "Lưu";
            this.btLuuSP.UseVisualStyleBackColor = false;
            this.btLuuSP.Click += new System.EventHandler(this.btLuuSP_Click);
            // 
            // erTenSP
            // 
            this.erTenSP.ContainerControl = this;
            this.erTenSP.RightToLeftChanged += new System.EventHandler(this.btLuuSP_Click);
            // 
            // erGiaBan
            // 
            this.erGiaBan.ContainerControl = this;
            this.erGiaBan.RightToLeftChanged += new System.EventHandler(this.btLuuSP_Click);
            // 
            // erSL
            // 
            this.erSL.ContainerControl = this;
            this.erSL.RightToLeftChanged += new System.EventHandler(this.btLuuSP_Click);
            // 
            // FSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1030, 840);
            this.Controls.Add(this.gBChucNang);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gBCTSP);
            this.Controls.Add(this.lbCTSP);
            this.Name = "FSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FSP";
            this.Load += new System.EventHandler(this.FSP_Load);
            this.gBCTSP.ResumeLayout(false);
            this.gBCTSP.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvSP)).EndInit();
            this.gBChucNang.ResumeLayout(false);
            this.gBChucNang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erTenSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erGiaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erSL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCTSP;
        private System.Windows.Forms.GroupBox gBCTSP;
        private System.Windows.Forms.ComboBox cbNhaCC;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label lbGiaBan;
        private System.Windows.Forms.DateTimePicker dPNgayNhapHang;
        private System.Windows.Forms.Label lbNgayNhapHang;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.ComboBox cbLoaiSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label lbNhaCC;
        private System.Windows.Forms.Label lbLoaiSP;
        private System.Windows.Forms.Label lbTenSP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gvSP;
        private System.Windows.Forms.GroupBox gBChucNang;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btLuuSP;
        private System.Windows.Forms.ErrorProvider erTenSP;
        private System.Windows.Forms.ErrorProvider erGiaBan;
        private System.Windows.Forms.ErrorProvider erSL;
        private System.Windows.Forms.TextBox txtMasp;
        private System.Windows.Forms.Label label1;
    }
}