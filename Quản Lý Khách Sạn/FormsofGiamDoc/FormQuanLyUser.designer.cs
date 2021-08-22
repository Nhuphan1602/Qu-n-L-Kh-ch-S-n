
namespace Quản_Lý_Khách_Sạn.FormsofGiamDoc
{
    partial class FormQuanLyUser
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
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_lammoinv = new System.Windows.Forms.Button();
            this.comboBox_timnv = new System.Windows.Forms.ComboBox();
            this.tb_timkiemnv = new System.Windows.Forms.TextBox();
            this.dataGridView_quanlynv = new System.Windows.Forms.DataGridView();
            this.btn_chonnv = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_tennv = new System.Windows.Forms.TextBox();
            this.tb_manv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_luutaikhoan = new System.Windows.Forms.Button();
            this.groupBox_timkiemthongtinnhanvien = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_quanlynv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox_timkiemthongtinnhanvien.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(787, 122);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(306, 30);
            this.tb_password.TabIndex = 93;
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(787, 48);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(306, 30);
            this.tb_username.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(656, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 91;
            this.label1.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(652, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 90;
            this.label3.Text = "Username:";
            // 
            // btn_lammoinv
            // 
            this.btn_lammoinv.BackColor = System.Drawing.Color.White;
            this.btn_lammoinv.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_lammoinv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lammoinv.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lammoinv.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btn_lammoinv.Location = new System.Drawing.Point(998, 47);
            this.btn_lammoinv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_lammoinv.Name = "btn_lammoinv";
            this.btn_lammoinv.Size = new System.Drawing.Size(139, 37);
            this.btn_lammoinv.TabIndex = 97;
            this.btn_lammoinv.Text = "Làm mới";
            this.btn_lammoinv.UseVisualStyleBackColor = false;
            this.btn_lammoinv.Click += new System.EventHandler(this.btn_lammoinv_Click);
            // 
            // comboBox_timnv
            // 
            this.comboBox_timnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_timnv.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox_timnv.FormattingEnabled = true;
            this.comboBox_timnv.Items.AddRange(new object[] {
            "Có tài khoản",
            "Không có tài khoản"});
            this.comboBox_timnv.Location = new System.Drawing.Point(310, 49);
            this.comboBox_timnv.Name = "comboBox_timnv";
            this.comboBox_timnv.Size = new System.Drawing.Size(210, 33);
            this.comboBox_timnv.TabIndex = 95;
            this.comboBox_timnv.SelectedIndexChanged += new System.EventHandler(this.comboBox_timnv_SelectedIndexChanged);
            // 
            // tb_timkiemnv
            // 
            this.tb_timkiemnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_timkiemnv.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_timkiemnv.Location = new System.Drawing.Point(541, 49);
            this.tb_timkiemnv.Name = "tb_timkiemnv";
            this.tb_timkiemnv.Size = new System.Drawing.Size(440, 32);
            this.tb_timkiemnv.TabIndex = 94;
            this.tb_timkiemnv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_timkiemnv_KeyDown);
            // 
            // dataGridView_quanlynv
            // 
            this.dataGridView_quanlynv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_quanlynv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_quanlynv.Location = new System.Drawing.Point(65, 117);
            this.dataGridView_quanlynv.Name = "dataGridView_quanlynv";
            this.dataGridView_quanlynv.RowHeadersWidth = 51;
            this.dataGridView_quanlynv.RowTemplate.Height = 24;
            this.dataGridView_quanlynv.Size = new System.Drawing.Size(1345, 401);
            this.dataGridView_quanlynv.TabIndex = 98;
            // 
            // btn_chonnv
            // 
            this.btn_chonnv.BackColor = System.Drawing.Color.White;
            this.btn_chonnv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chonnv.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chonnv.Location = new System.Drawing.Point(1214, 38);
            this.btn_chonnv.Name = "btn_chonnv";
            this.btn_chonnv.Size = new System.Drawing.Size(123, 46);
            this.btn_chonnv.TabIndex = 99;
            this.btn_chonnv.Text = "Chọn NV";
            this.btn_chonnv.UseVisualStyleBackColor = false;
            this.btn_chonnv.Click += new System.EventHandler(this.btn_chonnv_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_tennv);
            this.groupBox1.Controls.Add(this.tb_manv);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_chonnv);
            this.groupBox1.Controls.Add(this.btn_luutaikhoan);
            this.groupBox1.Controls.Add(this.tb_password);
            this.groupBox1.Controls.Add(this.tb_username);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(143, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1479, 214);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tạo tài khoản";
            // 
            // tb_tennv
            // 
            this.tb_tennv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tennv.Location = new System.Drawing.Point(295, 122);
            this.tb_tennv.Name = "tb_tennv";
            this.tb_tennv.Size = new System.Drawing.Size(306, 30);
            this.tb_tennv.TabIndex = 104;
            // 
            // tb_manv
            // 
            this.tb_manv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_manv.Location = new System.Drawing.Point(295, 48);
            this.tb_manv.Name = "tb_manv";
            this.tb_manv.Size = new System.Drawing.Size(306, 30);
            this.tb_manv.TabIndex = 103;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 102;
            this.label2.Text = "Tên nhân viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(138, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 25);
            this.label4.TabIndex = 101;
            this.label4.Text = "Mã nhân viên:";
            // 
            // btn_luutaikhoan
            // 
            this.btn_luutaikhoan.BackColor = System.Drawing.Color.White;
            this.btn_luutaikhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_luutaikhoan.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luutaikhoan.Location = new System.Drawing.Point(1214, 114);
            this.btn_luutaikhoan.Name = "btn_luutaikhoan";
            this.btn_luutaikhoan.Size = new System.Drawing.Size(123, 46);
            this.btn_luutaikhoan.TabIndex = 100;
            this.btn_luutaikhoan.Text = "Lưu";
            this.btn_luutaikhoan.UseVisualStyleBackColor = false;
            this.btn_luutaikhoan.Click += new System.EventHandler(this.btn_luutaikhoan_Click);
            // 
            // groupBox_timkiemthongtinnhanvien
            // 
            this.groupBox_timkiemthongtinnhanvien.Controls.Add(this.comboBox_timnv);
            this.groupBox_timkiemthongtinnhanvien.Controls.Add(this.tb_timkiemnv);
            this.groupBox_timkiemthongtinnhanvien.Controls.Add(this.btn_lammoinv);
            this.groupBox_timkiemthongtinnhanvien.Controls.Add(this.dataGridView_quanlynv);
            this.groupBox_timkiemthongtinnhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_timkiemthongtinnhanvien.Location = new System.Drawing.Point(143, 253);
            this.groupBox_timkiemthongtinnhanvien.Name = "groupBox_timkiemthongtinnhanvien";
            this.groupBox_timkiemthongtinnhanvien.Size = new System.Drawing.Size(1479, 537);
            this.groupBox_timkiemthongtinnhanvien.TabIndex = 102;
            this.groupBox_timkiemthongtinnhanvien.TabStop = false;
            this.groupBox_timkiemthongtinnhanvien.Text = "Tìm kiếm thông tin nhân viên";
            // 
            // FormQuanLyUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 811);
            this.Controls.Add(this.groupBox_timkiemthongtinnhanvien);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormQuanLyUser";
            this.Text = "Quản lý người dùng";
            this.Load += new System.EventHandler(this.FormQuanLyUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_quanlynv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_timkiemthongtinnhanvien.ResumeLayout(false);
            this.groupBox_timkiemthongtinnhanvien.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_lammoinv;
        private System.Windows.Forms.ComboBox comboBox_timnv;
        private System.Windows.Forms.TextBox tb_timkiemnv;
        private System.Windows.Forms.DataGridView dataGridView_quanlynv;
        private System.Windows.Forms.Button btn_chonnv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_luutaikhoan;
        private System.Windows.Forms.GroupBox groupBox_timkiemthongtinnhanvien;
        private System.Windows.Forms.TextBox tb_tennv;
        private System.Windows.Forms.TextBox tb_manv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}