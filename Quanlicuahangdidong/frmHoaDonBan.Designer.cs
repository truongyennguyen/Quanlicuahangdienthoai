namespace Quanlicuahangdidong
{
    partial class frmHoaDonBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDonBan));
            this.timKiemTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timKiemButton = new DevExpress.XtraEditors.SimpleButton();
            this.chitietButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // timKiemTextBox
            // 
            this.timKiemTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timKiemTextBox.Location = new System.Drawing.Point(715, 112);
            this.timKiemTextBox.Name = "timKiemTextBox";
            this.timKiemTextBox.Size = new System.Drawing.Size(391, 32);
            this.timKiemTextBox.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(376, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1178, 267);
            this.dataGridView1.TabIndex = 22;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã hóa đơn";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên khách hàng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nhân viên";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Thời gian";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // timKiemButton
            // 
            this.timKiemButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("timKiemButton.ImageOptions.Image")));
            this.timKiemButton.Location = new System.Drawing.Point(1138, 112);
            this.timKiemButton.Name = "timKiemButton";
            this.timKiemButton.Size = new System.Drawing.Size(112, 32);
            this.timKiemButton.TabIndex = 25;
            this.timKiemButton.Text = "Tìm kiếm";
            // 
            // chitietButton
            // 
            this.chitietButton.Appearance.ForeColor = System.Drawing.Color.Black;
            this.chitietButton.Appearance.Options.UseForeColor = true;
            this.chitietButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("chitietButton.ImageOptions.Image")));
            this.chitietButton.Location = new System.Drawing.Point(883, 471);
            this.chitietButton.Name = "chitietButton";
            this.chitietButton.Size = new System.Drawing.Size(194, 32);
            this.chitietButton.TabIndex = 23;
            this.chitietButton.Text = "Xem chi tiết hóa đơn";
            this.chitietButton.Click += new System.EventHandler(this.chitietButton_Click);
            // 
            // frmHoaDonBan
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1791, 807);
            this.Controls.Add(this.timKiemButton);
            this.Controls.Add(this.timKiemTextBox);
            this.Controls.Add(this.chitietButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmHoaDonBan";
            this.Text = "Danh sách hóa đơn bán hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton timKiemButton;
        private System.Windows.Forms.TextBox timKiemTextBox;
        private DevExpress.XtraEditors.SimpleButton chitietButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}