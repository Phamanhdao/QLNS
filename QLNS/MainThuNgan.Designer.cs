
namespace QLNS
{
    partial class MainThuNgan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainThuNgan));
            this.Ql = new System.Windows.Forms.GroupBox();
            this.btQLDH = new System.Windows.Forms.Button();
            this.btQlSp = new System.Windows.Forms.GroupBox();
            this.btQLSanPham = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.Ql.SuspendLayout();
            this.btQlSp.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ql
            // 
            this.Ql.BackColor = System.Drawing.Color.SeaShell;
            this.Ql.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Ql.BackgroundImage")));
            this.Ql.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Ql.Controls.Add(this.btQLDH);
            this.Ql.Location = new System.Drawing.Point(410, 103);
            this.Ql.Name = "Ql";
            this.Ql.Size = new System.Drawing.Size(326, 280);
            this.Ql.TabIndex = 2;
            this.Ql.TabStop = false;
            // 
            // btQLDH
            // 
            this.btQLDH.BackColor = System.Drawing.Color.Tomato;
            this.btQLDH.Font = new System.Drawing.Font("#9Slide03 SFU Futura_01", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQLDH.ForeColor = System.Drawing.Color.Snow;
            this.btQLDH.Location = new System.Drawing.Point(0, 241);
            this.btQLDH.Name = "btQLDH";
            this.btQLDH.Size = new System.Drawing.Size(326, 39);
            this.btQLDH.TabIndex = 2;
            this.btQLDH.Text = " QUẢN LÝ ĐƠN HÀNG";
            this.btQLDH.UseVisualStyleBackColor = false;
            this.btQLDH.Click += new System.EventHandler(this.btQLDH_Click);
            // 
            // btQlSp
            // 
            this.btQlSp.BackColor = System.Drawing.Color.SeaShell;
            this.btQlSp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btQlSp.BackgroundImage")));
            this.btQlSp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btQlSp.Controls.Add(this.btQLSanPham);
            this.btQlSp.Location = new System.Drawing.Point(60, 103);
            this.btQlSp.Name = "btQlSp";
            this.btQlSp.Size = new System.Drawing.Size(326, 280);
            this.btQlSp.TabIndex = 2;
            this.btQlSp.TabStop = false;
            // 
            // btQLSanPham
            // 
            this.btQLSanPham.BackColor = System.Drawing.Color.Tomato;
            this.btQLSanPham.Font = new System.Drawing.Font("#9Slide03 SFU Futura_01", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQLSanPham.ForeColor = System.Drawing.Color.Snow;
            this.btQLSanPham.Location = new System.Drawing.Point(0, 241);
            this.btQLSanPham.Name = "btQLSanPham";
            this.btQLSanPham.Size = new System.Drawing.Size(326, 39);
            this.btQLSanPham.TabIndex = 2;
            this.btQLSanPham.Text = " QUẢN LÝ SẢN PHẨM";
            this.btQLSanPham.UseVisualStyleBackColor = false;
            this.btQLSanPham.Click += new System.EventHandler(this.btQLSanPham_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("#9Slide03 SFU Futura_05", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(279, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 49);
            this.label1.TabIndex = 6;
            this.label1.Text = "THU NGÂN";
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.Firebrick;
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btThoat.Location = new System.Drawing.Point(738, 12);
            this.btThoat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(49, 38);
            this.btThoat.TabIndex = 5;
            this.btThoat.Text = "X";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // MainThuNgan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btQlSp);
            this.Controls.Add(this.Ql);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainThuNgan";
            this.Text = "Thu  Ngân";
            this.Ql.ResumeLayout(false);
            this.btQlSp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Ql;
        private System.Windows.Forms.Button btQLDH;
        private System.Windows.Forms.GroupBox btQlSp;
        private System.Windows.Forms.Button btQLSanPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btThoat;
    }
}