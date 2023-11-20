namespace LibraryManagement
{
    partial class frmQuanLySach
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
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cboTenKeSach = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnChuyen = new System.Windows.Forms.Button();
            this.cboChuyen = new System.Windows.Forms.ComboBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.dgvMaSach = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaSach)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSach
            // 
            this.dgvSach.AllowUserToAddRows = false;
            this.dgvSach.AllowUserToDeleteRows = false;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach});
            this.dgvSach.Location = new System.Drawing.Point(10, 54);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.ReadOnly = true;
            this.dgvSach.RowHeadersWidth = 43;
            this.dgvSach.Size = new System.Drawing.Size(608, 521);
            this.dgvSach.TabIndex = 1;
            this.dgvSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_CellContentClick);
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            this.MaSach.Width = 125;
            // 
            // cboTenKeSach
            // 
            this.cboTenKeSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenKeSach.FormattingEnabled = true;
            this.cboTenKeSach.Location = new System.Drawing.Point(84, 15);
            this.cboTenKeSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTenKeSach.Name = "cboTenKeSach";
            this.cboTenKeSach.Size = new System.Drawing.Size(182, 28);
            this.cboTenKeSach.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Heading", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên kệ";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(298, 9);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(90, 35);
            this.btnTimKiem.TabIndex = 90;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(406, 9);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(90, 35);
            this.btnReload.TabIndex = 89;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(719, 127);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(90, 35);
            this.btnHuy.TabIndex = 93;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnChuyen
            // 
            this.btnChuyen.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyen.Location = new System.Drawing.Point(719, 54);
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.Size = new System.Drawing.Size(90, 35);
            this.btnChuyen.TabIndex = 94;
            this.btnChuyen.Text = "Chuyển";
            this.btnChuyen.UseVisualStyleBackColor = true;
            this.btnChuyen.Click += new System.EventHandler(this.btnChuyen_Click);
            // 
            // cboChuyen
            // 
            this.cboChuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChuyen.FormattingEnabled = true;
            this.cboChuyen.Location = new System.Drawing.Point(625, 94);
            this.cboChuyen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboChuyen.Name = "cboChuyen";
            this.cboChuyen.Size = new System.Drawing.Size(181, 28);
            this.cboChuyen.TabIndex = 95;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(623, 127);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(90, 35);
            this.btnXacNhan.TabIndex = 96;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // dgvMaSach
            // 
            this.dgvMaSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaSach.Location = new System.Drawing.Point(625, 167);
            this.dgvMaSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMaSach.Name = "dgvMaSach";
            this.dgvMaSach.RowHeadersWidth = 51;
            this.dgvMaSach.RowTemplate.Height = 24;
            this.dgvMaSach.Size = new System.Drawing.Size(184, 407);
            this.dgvMaSach.TabIndex = 98;
            // 
            // frmQuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 585);
            this.Controls.Add(this.dgvMaSach);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.cboChuyen);
            this.Controls.Add(this.btnChuyen);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboTenKeSach);
            this.Controls.Add(this.dgvSach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuanLySach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuanLySach";
            this.Load += new System.EventHandler(this.frmQuanLySach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.ComboBox cboTenKeSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnChuyen;
        private System.Windows.Forms.ComboBox cboChuyen;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.DataGridView dgvMaSach;
        private System.Windows.Forms.DataGridViewButtonColumn MaSach;
    }
}