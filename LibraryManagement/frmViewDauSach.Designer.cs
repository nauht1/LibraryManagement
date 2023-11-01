namespace LibraryManagement
{
    partial class frmViewDauSach
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
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDauSach)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDauSach
            // 
            this.dgvDauSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDauSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDauSach,
            this.TenDauSach});
            this.dgvDauSach.Location = new System.Drawing.Point(12, 12);
            this.dgvDauSach.Name = "dgvDauSach";
            this.dgvDauSach.RowHeadersWidth = 51;
            this.dgvDauSach.RowTemplate.Height = 24;
            this.dgvDauSach.Size = new System.Drawing.Size(956, 361);
            this.dgvDauSach.TabIndex = 0;
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
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.LightGreen;
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(851, 391);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(108, 47);
            this.btnDong.TabIndex = 35;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmViewDauSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 451);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dgvDauSach);
            this.Name = "frmViewDauSach";
            this.Text = "frmViewDauSach";
            this.Load += new System.EventHandler(this.frmViewDauSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDauSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDauSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDauSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDauSach;
        private System.Windows.Forms.Button btnDong;
    }
}