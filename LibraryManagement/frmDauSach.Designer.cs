namespace LibraryManagement
{
    partial class frmDauSach
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
            this.dgvDauSach = new System.Windows.Forms.DataGridView();
            this.MaDauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clbTheLoai = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaDauSach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenDauSach = new System.Windows.Forms.TextBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDauSach)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDauSach
            // 
            this.dgvDauSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDauSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDauSach,
            this.TenDauSach});
            this.dgvDauSach.Location = new System.Drawing.Point(12, 156);
            this.dgvDauSach.Name = "dgvDauSach";
            this.dgvDauSach.RowHeadersWidth = 51;
            this.dgvDauSach.RowTemplate.Height = 24;
            this.dgvDauSach.Size = new System.Drawing.Size(589, 495);
            this.dgvDauSach.TabIndex = 0;
            this.dgvDauSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDauSach_CellClick);
            // 
            // MaDauSach
            // 
            this.MaDauSach.DataPropertyName = "MaDauSach";
            this.MaDauSach.HeaderText = "Mã đầu sách";
            this.MaDauSach.MinimumWidth = 6;
            this.MaDauSach.Name = "MaDauSach";
            this.MaDauSach.Width = 125;
            // 
            // TenDauSach
            // 
            this.TenDauSach.DataPropertyName = "TenDauSach";
            this.TenDauSach.HeaderText = "Tên đầu sách";
            this.TenDauSach.MinimumWidth = 6;
            this.TenDauSach.Name = "TenDauSach";
            this.TenDauSach.Width = 125;
            // 
            // clbTheLoai
            // 
            this.clbTheLoai.FormattingEnabled = true;
            this.clbTheLoai.Location = new System.Drawing.Point(820, 167);
            this.clbTheLoai.Name = "clbTheLoai";
            this.clbTheLoai.Size = new System.Drawing.Size(230, 361);
            this.clbTheLoai.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(37, 2);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "Thông tin";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtMaDauSach);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTenDauSach);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 136);
            this.panel1.TabIndex = 23;
            // 
            // txtMaDauSach
            // 
            this.txtMaDauSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaDauSach.Enabled = false;
            this.txtMaDauSach.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDauSach.Location = new System.Drawing.Point(192, 24);
            this.txtMaDauSach.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaDauSach.Name = "txtMaDauSach";
            this.txtMaDauSach.Size = new System.Drawing.Size(390, 32);
            this.txtMaDauSach.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã đầu sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên đầu sách";
            // 
            // txtTenDauSach
            // 
            this.txtTenDauSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenDauSach.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDauSach.Location = new System.Drawing.Point(192, 73);
            this.txtTenDauSach.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDauSach.Name = "txtTenDauSach";
            this.txtTenDauSach.Size = new System.Drawing.Size(390, 32);
            this.txtTenDauSach.TabIndex = 3;
            // 
            // btnChon
            // 
            this.btnChon.BackColor = System.Drawing.Color.LightGreen;
            this.btnChon.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.Location = new System.Drawing.Point(820, 603);
            this.btnChon.Margin = new System.Windows.Forms.Padding(4);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(108, 47);
            this.btnChon.TabIndex = 33;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = false;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Aqua;
            this.btnView.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(632, 13);
            this.btnView.Margin = new System.Windows.Forms.Padding(4);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(187, 47);
            this.btnView.TabIndex = 34;
            this.btnView.Text = "view đầu sách";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.LightGreen;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(942, 603);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(108, 47);
            this.btnHuy.TabIndex = 35;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmDauSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 663);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clbTheLoai);
            this.Controls.Add(this.dgvDauSach);
            this.Name = "frmDauSach";
            this.Text = "frmDauSach";
            this.Load += new System.EventHandler(this.frmDauSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDauSach)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDauSach;
        private System.Windows.Forms.CheckedListBox clbTheLoai;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMaDauSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenDauSach;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDauSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDauSach;
        private System.Windows.Forms.Button btnHuy;
    }
}