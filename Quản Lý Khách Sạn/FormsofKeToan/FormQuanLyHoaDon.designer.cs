
namespace Quản_Lý_Khách_Sạn.FormsofKeToan
{
    partial class FormQuanLyHoaDon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_lammoi_hd = new System.Windows.Forms.Button();
            this.tb_timhdtheotenvama = new System.Windows.Forms.TextBox();
            this.dataGridView_tonghophd = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_lammoinv = new System.Windows.Forms.Button();
            this.comboBox_maBP_KeToan_timkiemthongtinnhanvien = new System.Windows.Forms.ComboBox();
            this.tb_timkiemnvtheoten = new System.Windows.Forms.TextBox();
            this.dataGridView_luongnv = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tonghophd)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_luongnv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_lammoi_hd);
            this.groupBox1.Controls.Add(this.tb_timhdtheotenvama);
            this.groupBox1.Controls.Add(this.dataGridView_tonghophd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 712);
            this.groupBox1.TabIndex = 89;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tổng hợp hóa đơn";
            // 
            // btn_lammoi_hd
            // 
            this.btn_lammoi_hd.BackColor = System.Drawing.Color.White;
            this.btn_lammoi_hd.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_lammoi_hd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lammoi_hd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lammoi_hd.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btn_lammoi_hd.Location = new System.Drawing.Point(504, 58);
            this.btn_lammoi_hd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_lammoi_hd.Name = "btn_lammoi_hd";
            this.btn_lammoi_hd.Size = new System.Drawing.Size(146, 37);
            this.btn_lammoi_hd.TabIndex = 92;
            this.btn_lammoi_hd.Text = "Làm mới";
            this.btn_lammoi_hd.UseVisualStyleBackColor = false;
            this.btn_lammoi_hd.Click += new System.EventHandler(this.btn_lammoi_hd_Click);
            // 
            // tb_timhdtheotenvama
            // 
            this.tb_timhdtheotenvama.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_timhdtheotenvama.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_timhdtheotenvama.Location = new System.Drawing.Point(22, 60);
            this.tb_timhdtheotenvama.Name = "tb_timhdtheotenvama";
            this.tb_timhdtheotenvama.Size = new System.Drawing.Size(457, 32);
            this.tb_timhdtheotenvama.TabIndex = 89;
            this.tb_timhdtheotenvama.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_timhdtheotenvama_KeyDown);
            // 
            // dataGridView_tonghophd
            // 
            this.dataGridView_tonghophd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_tonghophd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_tonghophd.Location = new System.Drawing.Point(22, 121);
            this.dataGridView_tonghophd.Name = "dataGridView_tonghophd";
            this.dataGridView_tonghophd.RowHeadersWidth = 51;
            this.dataGridView_tonghophd.RowTemplate.Height = 24;
            this.dataGridView_tonghophd.Size = new System.Drawing.Size(628, 569);
            this.dataGridView_tonghophd.TabIndex = 88;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_lammoinv);
            this.groupBox2.Controls.Add(this.comboBox_maBP_KeToan_timkiemthongtinnhanvien);
            this.groupBox2.Controls.Add(this.tb_timkiemnvtheoten);
            this.groupBox2.Controls.Add(this.dataGridView_luongnv);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(747, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(678, 712);
            this.groupBox2.TabIndex = 93;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lương nhân viên";
            // 
            // btn_lammoinv
            // 
            this.btn_lammoinv.BackColor = System.Drawing.Color.White;
            this.btn_lammoinv.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_lammoinv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lammoinv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lammoinv.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btn_lammoinv.Location = new System.Drawing.Point(518, 28);
            this.btn_lammoinv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_lammoinv.Name = "btn_lammoinv";
            this.btn_lammoinv.Size = new System.Drawing.Size(134, 37);
            this.btn_lammoinv.TabIndex = 92;
            this.btn_lammoinv.Text = "Làm mới";
            this.btn_lammoinv.UseVisualStyleBackColor = false;
            this.btn_lammoinv.Click += new System.EventHandler(this.btn_lammoinv_Click);
            // 
            // comboBox_maBP_KeToan_timkiemthongtinnhanvien
            // 
            this.comboBox_maBP_KeToan_timkiemthongtinnhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_maBP_KeToan_timkiemthongtinnhanvien.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox_maBP_KeToan_timkiemthongtinnhanvien.FormattingEnabled = true;
            this.comboBox_maBP_KeToan_timkiemthongtinnhanvien.Items.AddRange(new object[] {
            "NS",
            "KT",
            "DT",
            "DV",
            "GD"});
            this.comboBox_maBP_KeToan_timkiemthongtinnhanvien.Location = new System.Drawing.Point(22, 72);
            this.comboBox_maBP_KeToan_timkiemthongtinnhanvien.Name = "comboBox_maBP_KeToan_timkiemthongtinnhanvien";
            this.comboBox_maBP_KeToan_timkiemthongtinnhanvien.Size = new System.Drawing.Size(134, 33);
            this.comboBox_maBP_KeToan_timkiemthongtinnhanvien.TabIndex = 90;
            this.comboBox_maBP_KeToan_timkiemthongtinnhanvien.SelectedIndexChanged += new System.EventHandler(this.comboBox_maBP_KeToan_timkiemthongtinnhanvien_SelectedIndexChanged);
            // 
            // tb_timkiemnvtheoten
            // 
            this.tb_timkiemnvtheoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_timkiemnvtheoten.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_timkiemnvtheoten.Location = new System.Drawing.Point(175, 71);
            this.tb_timkiemnvtheoten.Name = "tb_timkiemnvtheoten";
            this.tb_timkiemnvtheoten.Size = new System.Drawing.Size(477, 32);
            this.tb_timkiemnvtheoten.TabIndex = 89;
            this.tb_timkiemnvtheoten.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_timkiemnvtheoten_KeyDown);
            // 
            // dataGridView_luongnv
            // 
            this.dataGridView_luongnv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_luongnv.Location = new System.Drawing.Point(22, 121);
            this.dataGridView_luongnv.Name = "dataGridView_luongnv";
            this.dataGridView_luongnv.RowHeadersWidth = 51;
            this.dataGridView_luongnv.RowTemplate.Height = 24;
            this.dataGridView_luongnv.Size = new System.Drawing.Size(630, 569);
            this.dataGridView_luongnv.TabIndex = 88;
            // 
            // FormQuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 794);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormQuanLyHoaDon";
            this.Text = "Quản lý hóa đơn";
            this.Load += new System.EventHandler(this.tb_timkiemnvtheotenvama_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tonghophd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_luongnv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_lammoi_hd;
        private System.Windows.Forms.TextBox tb_timhdtheotenvama;
        private System.Windows.Forms.DataGridView dataGridView_tonghophd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_lammoinv;
        private System.Windows.Forms.ComboBox comboBox_maBP_KeToan_timkiemthongtinnhanvien;
        private System.Windows.Forms.TextBox tb_timkiemnvtheoten;
        private System.Windows.Forms.DataGridView dataGridView_luongnv;
    }
}