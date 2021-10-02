
namespace QLNS
{
    partial class FQLSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FQLSP));
            this.lbQLNV = new System.Windows.Forms.Label();
            this.gBSanPham = new System.Windows.Forms.GroupBox();
            this.txtncc = new System.Windows.Forms.TextBox();
            this.lbmaNCC = new System.Windows.Forms.Label();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.lbmasp = new System.Windows.Forms.Label();
            this.cbNCC = new System.Windows.Forms.ComboBox();
            this.cbLoaiSP = new System.Windows.Forms.ComboBox();
            this.lbNhaCC = new System.Windows.Forms.Label();
            this.lbLoaiSP = new System.Windows.Forms.Label();
            this.gBChucNang = new System.Windows.Forms.GroupBox();
            this.btHienThiSP = new System.Windows.Forms.Button();
            this.btDangXuat = new System.Windows.Forms.Button();
            this.btCTSP = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gvQLSP = new System.Windows.Forms.DataGridView();
            this.btTraCuu = new System.Windows.Forms.Button();
            this.ttTraCuu = new System.Windows.Forms.ToolTip(this.components);
            this.ttbtCTSP = new System.Windows.Forms.ToolTip(this.components);
            this.ttbtTCSP = new System.Windows.Forms.ToolTip(this.components);
            this.ttcbLSP = new System.Windows.Forms.ToolTip(this.components);
            this.ttcbNCC = new System.Windows.Forms.ToolTip(this.components);
            this.gBSanPham.SuspendLayout();
            this.gBChucNang.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvQLSP)).BeginInit();
            this.SuspendLayout();
            // 
            // lbQLNV
            // 
            this.lbQLNV.AutoSize = true;
            this.lbQLNV.Font = new System.Drawing.Font("#9Slide03 SFU Futura_05", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQLNV.ForeColor = System.Drawing.Color.DarkRed;
            this.lbQLNV.Location = new System.Drawing.Point(335, 29);
            this.lbQLNV.Name = "lbQLNV";
            this.lbQLNV.Size = new System.Drawing.Size(414, 49);
            this.lbQLNV.TabIndex = 1;
            this.lbQLNV.Text = "QUẢN LÝ SẢN PHẨM";
            this.lbQLNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gBSanPham
            // 
            this.gBSanPham.BackColor = System.Drawing.Color.MistyRose;
            this.gBSanPham.Controls.Add(this.txtncc);
            this.gBSanPham.Controls.Add(this.lbmaNCC);
            this.gBSanPham.Controls.Add(this.txtmasp);
            this.gBSanPham.Controls.Add(this.lbmasp);
            this.gBSanPham.Controls.Add(this.cbNCC);
            this.gBSanPham.Controls.Add(this.cbLoaiSP);
            this.gBSanPham.Controls.Add(this.lbNhaCC);
            this.gBSanPham.Controls.Add(this.lbLoaiSP);
            this.gBSanPham.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBSanPham.Location = new System.Drawing.Point(77, 120);
            this.gBSanPham.Name = "gBSanPham";
            this.gBSanPham.Size = new System.Drawing.Size(922, 153);
            this.gBSanPham.TabIndex = 6;
            this.gBSanPham.TabStop = false;
            this.gBSanPham.Text = "Trà cứu sản phẩm";
            // 
            // txtncc
            // 
            this.txtncc.Location = new System.Drawing.Point(666, 98);
            this.txtncc.Name = "txtncc";
            this.txtncc.Size = new System.Drawing.Size(186, 27);
            this.txtncc.TabIndex = 18;
            // 
            // lbmaNCC
            // 
            this.lbmaNCC.AutoSize = true;
            this.lbmaNCC.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmaNCC.Location = new System.Drawing.Point(514, 101);
            this.lbmaNCC.Name = "lbmaNCC";
            this.lbmaNCC.Size = new System.Drawing.Size(137, 19);
            this.lbmaNCC.TabIndex = 17;
            this.lbmaNCC.Text = "Mã nhà cung cấp:";
            // 
            // txtmasp
            // 
            this.txtmasp.Location = new System.Drawing.Point(666, 45);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(186, 27);
            this.txtmasp.TabIndex = 16;
            // 
            // lbmasp
            // 
            this.lbmasp.AutoSize = true;
            this.lbmasp.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmasp.Location = new System.Drawing.Point(514, 48);
            this.lbmasp.Name = "lbmasp";
            this.lbmasp.Size = new System.Drawing.Size(113, 19);
            this.lbmasp.TabIndex = 15;
            this.lbmasp.Text = "Mã danh mục:";
            // 
            // cbNCC
            // 
            this.cbNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNCC.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNCC.FormattingEnabled = true;
            this.cbNCC.Location = new System.Drawing.Point(199, 98);
            this.cbNCC.Name = "cbNCC";
            this.cbNCC.Size = new System.Drawing.Size(199, 27);
            this.cbNCC.TabIndex = 14;
            this.cbNCC.SelectedIndexChanged += new System.EventHandler(this.cbNCC_SelectedIndexChanged);
            this.cbNCC.MouseHover += new System.EventHandler(this.cbNCC_MouseHover);
            // 
            // cbLoaiSP
            // 
            this.cbLoaiSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiSP.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiSP.FormattingEnabled = true;
            this.cbLoaiSP.Location = new System.Drawing.Point(199, 45);
            this.cbLoaiSP.Name = "cbLoaiSP";
            this.cbLoaiSP.Size = new System.Drawing.Size(199, 27);
            this.cbLoaiSP.TabIndex = 11;
            this.cbLoaiSP.SelectedIndexChanged += new System.EventHandler(this.cbLoaiSP_SelectedIndexChanged);
            this.cbLoaiSP.MouseHover += new System.EventHandler(this.cbLoaiSP_MouseHover);
            // 
            // lbNhaCC
            // 
            this.lbNhaCC.AutoSize = true;
            this.lbNhaCC.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhaCC.Location = new System.Drawing.Point(59, 101);
            this.lbNhaCC.Name = "lbNhaCC";
            this.lbNhaCC.Size = new System.Drawing.Size(112, 19);
            this.lbNhaCC.TabIndex = 3;
            this.lbNhaCC.Text = "Nhà cung cấp:";
            // 
            // lbLoaiSP
            // 
            this.lbLoaiSP.AutoSize = true;
            this.lbLoaiSP.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiSP.Location = new System.Drawing.Point(59, 48);
            this.lbLoaiSP.Name = "lbLoaiSP";
            this.lbLoaiSP.Size = new System.Drawing.Size(121, 19);
            this.lbLoaiSP.TabIndex = 1;
            this.lbLoaiSP.Text = "Loại sản phẩm:";
            // 
            // gBChucNang
            // 
            this.gBChucNang.Controls.Add(this.btHienThiSP);
            this.gBChucNang.Controls.Add(this.btDangXuat);
            this.gBChucNang.Controls.Add(this.btCTSP);
            this.gBChucNang.Location = new System.Drawing.Point(373, 319);
            this.gBChucNang.Name = "gBChucNang";
            this.gBChucNang.Size = new System.Drawing.Size(576, 105);
            this.gBChucNang.TabIndex = 7;
            this.gBChucNang.TabStop = false;
            // 
            // btHienThiSP
            // 
            this.btHienThiSP.AutoSize = true;
            this.btHienThiSP.BackColor = System.Drawing.Color.Firebrick;
            this.btHienThiSP.FlatAppearance.BorderSize = 2;
            this.btHienThiSP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btHienThiSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHienThiSP.ForeColor = System.Drawing.Color.White;
            this.btHienThiSP.Location = new System.Drawing.Point(222, 21);
            this.btHienThiSP.Name = "btHienThiSP";
            this.btHienThiSP.Size = new System.Drawing.Size(167, 70);
            this.btHienThiSP.TabIndex = 4;
            this.btHienThiSP.Text = "Tất Cả Sản Phẩm";
            this.btHienThiSP.UseVisualStyleBackColor = false;
            this.btHienThiSP.Click += new System.EventHandler(this.btHienThiSP_Click);
            this.btHienThiSP.MouseHover += new System.EventHandler(this.btHienThiSP_MouseHover);
            // 
            // btDangXuat
            // 
            this.btDangXuat.AutoSize = true;
            this.btDangXuat.BackColor = System.Drawing.Color.Firebrick;
            this.btDangXuat.FlatAppearance.BorderSize = 2;
            this.btDangXuat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btDangXuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDangXuat.ForeColor = System.Drawing.Color.White;
            this.btDangXuat.Location = new System.Drawing.Point(428, 21);
            this.btDangXuat.Name = "btDangXuat";
            this.btDangXuat.Size = new System.Drawing.Size(137, 70);
            this.btDangXuat.TabIndex = 3;
            this.btDangXuat.Text = "Thoát";
            this.btDangXuat.UseVisualStyleBackColor = false;
            this.btDangXuat.Click += new System.EventHandler(this.btDangXuat_Click);
            // 
            // btCTSP
            // 
            this.btCTSP.AutoSize = true;
            this.btCTSP.BackColor = System.Drawing.Color.Firebrick;
            this.btCTSP.FlatAppearance.BorderSize = 2;
            this.btCTSP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btCTSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCTSP.ForeColor = System.Drawing.Color.White;
            this.btCTSP.Location = new System.Drawing.Point(11, 21);
            this.btCTSP.Name = "btCTSP";
            this.btCTSP.Size = new System.Drawing.Size(177, 70);
            this.btCTSP.TabIndex = 1;
            this.btCTSP.Text = "Chi Tiết Sản Phẩm";
            this.btCTSP.UseVisualStyleBackColor = false;
            this.btCTSP.Click += new System.EventHandler(this.btCTSP_Click);
            this.btCTSP.MouseHover += new System.EventHandler(this.btCTSP_MouseHover);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gvQLSP);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(63, 455);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(942, 363);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chung";
            // 
            // gvQLSP
            // 
            this.gvQLSP.AllowUserToOrderColumns = true;
            this.gvQLSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvQLSP.Location = new System.Drawing.Point(6, 26);
            this.gvQLSP.Name = "gvQLSP";
            this.gvQLSP.RowHeadersWidth = 51;
            this.gvQLSP.RowTemplate.Height = 24;
            this.gvQLSP.Size = new System.Drawing.Size(930, 331);
            this.gvQLSP.TabIndex = 9;
            // 
            // btTraCuu
            // 
            this.btTraCuu.AutoSize = true;
            this.btTraCuu.BackColor = System.Drawing.Color.Firebrick;
            this.btTraCuu.FlatAppearance.BorderSize = 2;
            this.btTraCuu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btTraCuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTraCuu.ForeColor = System.Drawing.Color.White;
            this.btTraCuu.Location = new System.Drawing.Point(111, 340);
            this.btTraCuu.Name = "btTraCuu";
            this.btTraCuu.Size = new System.Drawing.Size(137, 70);
            this.btTraCuu.TabIndex = 5;
            this.btTraCuu.Text = "Tra Cứu";
            this.btTraCuu.UseVisualStyleBackColor = false;
            this.btTraCuu.Click += new System.EventHandler(this.btTraCuu_Click);
            this.btTraCuu.MouseHover += new System.EventHandler(this.btTraCuu_MouseHover);
            // 
            // FQLSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1030, 830);
            this.Controls.Add(this.btTraCuu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gBChucNang);
            this.Controls.Add(this.gBSanPham);
            this.Controls.Add(this.lbQLNV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FQLSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FQLSP";
            this.Load += new System.EventHandler(this.FQLSP_Load);
            this.gBSanPham.ResumeLayout(false);
            this.gBSanPham.PerformLayout();
            this.gBChucNang.ResumeLayout(false);
            this.gBChucNang.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvQLSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbQLNV;
        private System.Windows.Forms.GroupBox gBSanPham;
        private System.Windows.Forms.ComboBox cbLoaiSP;
        private System.Windows.Forms.Label lbNhaCC;
        private System.Windows.Forms.Label lbLoaiSP;
        private System.Windows.Forms.GroupBox gBChucNang;
        private System.Windows.Forms.Button btHienThiSP;
        private System.Windows.Forms.Button btDangXuat;
        private System.Windows.Forms.Button btCTSP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gvQLSP;
        private System.Windows.Forms.ComboBox cbNCC;
        private System.Windows.Forms.TextBox txtncc;
        private System.Windows.Forms.Label lbmaNCC;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.Label lbmasp;
        private System.Windows.Forms.Button btTraCuu;
        private System.Windows.Forms.ToolTip ttTraCuu;
        private System.Windows.Forms.ToolTip ttbtCTSP;
        private System.Windows.Forms.ToolTip ttbtTCSP;
        private System.Windows.Forms.ToolTip ttcbLSP;
        private System.Windows.Forms.ToolTip ttcbNCC;
    }
}