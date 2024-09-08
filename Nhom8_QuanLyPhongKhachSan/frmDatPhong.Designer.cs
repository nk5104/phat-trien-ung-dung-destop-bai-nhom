namespace WDF
{
    partial class frmDatPhong
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
            this.grbDatPhong = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDatCoc = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTenDoan = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cboLoaiKhach = new System.Windows.Forms.ComboBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker6 = new System.Windows.Forms.DateTimePicker();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.grbDatPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDatPhong
            // 
            this.grbDatPhong.Controls.Add(this.button4);
            this.grbDatPhong.Controls.Add(this.button3);
            this.grbDatPhong.Controls.Add(this.dataGridView1);
            this.grbDatPhong.Controls.Add(this.txtDatCoc);
            this.grbDatPhong.Controls.Add(this.label15);
            this.grbDatPhong.Controls.Add(this.txtTenDoan);
            this.grbDatPhong.Controls.Add(this.label16);
            this.grbDatPhong.Controls.Add(this.cboLoaiKhach);
            this.grbDatPhong.Controls.Add(this.txtGhiChu);
            this.grbDatPhong.Controls.Add(this.label17);
            this.grbDatPhong.Controls.Add(this.label18);
            this.grbDatPhong.Controls.Add(this.label19);
            this.grbDatPhong.Controls.Add(this.label20);
            this.grbDatPhong.Controls.Add(this.dateTimePicker5);
            this.grbDatPhong.Controls.Add(this.dateTimePicker6);
            this.grbDatPhong.Controls.Add(this.textBox11);
            this.grbDatPhong.Controls.Add(this.label21);
            this.grbDatPhong.Controls.Add(this.txtTenKhach);
            this.grbDatPhong.Controls.Add(this.label22);
            this.grbDatPhong.Controls.Add(this.label23);
            this.grbDatPhong.Controls.Add(this.txtSoDienThoai);
            this.grbDatPhong.Controls.Add(this.label24);
            this.grbDatPhong.Location = new System.Drawing.Point(12, 12);
            this.grbDatPhong.Name = "grbDatPhong";
            this.grbDatPhong.Size = new System.Drawing.Size(552, 836);
            this.grbDatPhong.TabIndex = 0;
            this.grbDatPhong.TabStop = false;
            this.grbDatPhong.Text = "Đặt Phòng ";
            this.grbDatPhong.Enter += new System.EventHandler(this.grbDatPhong_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(36, 307);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(470, 158);
            this.dataGridView1.TabIndex = 45;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Phòng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Loại phòng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số ngày ở";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Xóa";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // txtDatCoc
            // 
            this.txtDatCoc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDatCoc.Location = new System.Drawing.Point(359, 166);
            this.txtDatCoc.Name = "txtDatCoc";
            this.txtDatCoc.ReadOnly = true;
            this.txtDatCoc.Size = new System.Drawing.Size(167, 22);
            this.txtDatCoc.TabIndex = 44;
            this.txtDatCoc.Text = "tiền đặt trước";
            this.txtDatCoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDatCoc.WordWrap = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(282, 172);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 16);
            this.label15.TabIndex = 43;
            this.label15.Text = "Đặt trước";
            // 
            // txtTenDoan
            // 
            this.txtTenDoan.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTenDoan.Location = new System.Drawing.Point(359, 126);
            this.txtTenDoan.Name = "txtTenDoan";
            this.txtTenDoan.ReadOnly = true;
            this.txtTenDoan.Size = new System.Drawing.Size(167, 22);
            this.txtTenDoan.TabIndex = 42;
            this.txtTenDoan.WordWrap = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(282, 132);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 16);
            this.label16.TabIndex = 41;
            this.label16.Text = "Tên đoàn";
            // 
            // cboLoaiKhach
            // 
            this.cboLoaiKhach.FormattingEnabled = true;
            this.cboLoaiKhach.Items.AddRange(new object[] {
            "Khách lẻ",
            "Khách đoàn"});
            this.cboLoaiKhach.Location = new System.Drawing.Point(434, 77);
            this.cboLoaiKhach.Name = "cboLoaiKhach";
            this.cboLoaiKhach.Size = new System.Drawing.Size(92, 24);
            this.cboLoaiKhach.TabIndex = 40;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtGhiChu.Location = new System.Drawing.Point(36, 518);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(470, 127);
            this.txtGhiChu.TabIndex = 39;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(33, 499);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 16);
            this.label17.TabIndex = 38;
            this.label17.Text = "Ghi chú";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(33, 287);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(112, 16);
            this.label18.TabIndex = 37;
            this.label18.Text = "Danh sách phòng";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(292, 227);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 16);
            this.label19.TabIndex = 34;
            this.label19.Text = "Ngày Đi";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(27, 227);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 16);
            this.label20.TabIndex = 33;
            this.label20.Text = "Ngày Đến";
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.CustomFormat = "dd/mm/yyyy/hh:ss";
            this.dateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker5.Location = new System.Drawing.Point(353, 222);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(173, 22);
            this.dateTimePicker5.TabIndex = 32;
            // 
            // dateTimePicker6
            // 
            this.dateTimePicker6.CustomFormat = "dd/mm/yyyy/hh:ss";
            this.dateTimePicker6.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker6.Location = new System.Drawing.Point(100, 222);
            this.dateTimePicker6.Name = "dateTimePicker6";
            this.dateTimePicker6.Size = new System.Drawing.Size(172, 22);
            this.dateTimePicker6.TabIndex = 31;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox11.Location = new System.Drawing.Point(129, 169);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(124, 22);
            this.textBox11.TabIndex = 30;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(27, 175);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(64, 16);
            this.label21.TabIndex = 29;
            this.label21.Text = "Số CCCD";
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTenKhach.Location = new System.Drawing.Point(129, 79);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.ReadOnly = true;
            this.txtTenKhach.Size = new System.Drawing.Size(200, 22);
            this.txtTenKhach.TabIndex = 28;
            this.txtTenKhach.TabStop = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(350, 85);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(72, 16);
            this.label22.TabIndex = 27;
            this.label22.Text = "Loại khách";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(27, 85);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(70, 16);
            this.label23.TabIndex = 26;
            this.label23.Text = "Tên khách";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSoDienThoai.Location = new System.Drawing.Point(129, 123);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.ReadOnly = true;
            this.txtSoDienThoai.Size = new System.Drawing.Size(124, 22);
            this.txtSoDienThoai.TabIndex = 25;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(27, 129);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(85, 16);
            this.label24.TabIndex = 24;
            this.label24.Text = "Số điện thoại";
            // 
            // button3
            // 
            this.button3.Image = global::WDF.Properties.Resources.accept;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(129, 691);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 42);
            this.button3.TabIndex = 44;
            this.button3.Text = "Đặt Phòng";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = global::WDF.Properties.Resources.refresh1;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(321, 691);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 42);
            this.button4.TabIndex = 44;
            this.button4.Text = "Làm Mới";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // frmDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 860);
            this.Controls.Add(this.grbDatPhong);
            this.Name = "frmDatPhong";
            this.Text = "Đặt Phòng";
            this.grbDatPhong.ResumeLayout(false);
            this.grbDatPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatPhong;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox txtDatCoc;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTenDoan;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboLoaiKhach;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.DateTimePicker dateTimePicker6;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}