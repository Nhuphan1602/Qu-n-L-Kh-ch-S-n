
namespace Quản_Lý_Khách_Sạn
{
    partial class FormHomeGiamDoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHomeGiamDoc));
            this.panel_titlebar = new System.Windows.Forms.Panel();
            this.pn_dangxuat = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.panel_picture = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btn_CloseChildForm = new System.Windows.Forms.Button();
            this.lbl_home = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox_thongtincuochop = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_lichhop = new System.Windows.Forms.DateTimePicker();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sửa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.lbl_thoigian = new System.Windows.Forms.Label();
            this.tb_noidung = new System.Windows.Forms.TextBox();
            this.lbl_noidung = new System.Windows.Forms.Label();
            this.tb_stt = new System.Windows.Forms.TextBox();
            this.lbl_stt = new System.Windows.Forms.Label();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_timkiemlichhoptheongay = new System.Windows.Forms.Label();
            this.btn_doanhthu = new System.Windows.Forms.Button();
            this.btn_sluser = new System.Windows.Forms.Button();
            this.btn_slkh = new System.Windows.Forms.Button();
            this.btn_bddanhthu = new System.Windows.Forms.Button();
            this.btn_sldv = new System.Windows.Forms.Button();
            this.btn_slnv = new System.Windows.Forms.Button();
            this.panel_titlebar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox_thongtincuochop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_titlebar
            // 
            this.panel_titlebar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel_titlebar.Controls.Add(this.pn_dangxuat);
            this.panel_titlebar.Controls.Add(this.btnMinimize);
            this.panel_titlebar.Controls.Add(this.btnMaximize);
            this.panel_titlebar.Controls.Add(this.panel_picture);
            this.panel_titlebar.Controls.Add(this.btnClose);
            this.panel_titlebar.Controls.Add(this.btn_CloseChildForm);
            this.panel_titlebar.Controls.Add(this.lbl_home);
            this.panel_titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_titlebar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.panel_titlebar.Location = new System.Drawing.Point(0, 0);
            this.panel_titlebar.Name = "panel_titlebar";
            this.panel_titlebar.Size = new System.Drawing.Size(1351, 99);
            this.panel_titlebar.TabIndex = 1;
            // 
            // pn_dangxuat
            // 
            this.pn_dangxuat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_dangxuat.BackgroundImage")));
            this.pn_dangxuat.Location = new System.Drawing.Point(1308, 58);
            this.pn_dangxuat.Name = "pn_dangxuat";
            this.pn_dangxuat.Size = new System.Drawing.Size(31, 32);
            this.pn_dangxuat.TabIndex = 17;
            this.pn_dangxuat.Click += new System.EventHandler(this.pn_dangxuat_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(1234, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 35);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(1275, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(35, 35);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.Text = "O";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // panel_picture
            // 
            this.panel_picture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_picture.BackgroundImage")));
            this.panel_picture.Location = new System.Drawing.Point(0, 3);
            this.panel_picture.Name = "panel_picture";
            this.panel_picture.Size = new System.Drawing.Size(106, 98);
            this.panel_picture.TabIndex = 16;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1316, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btn_CloseChildForm
            // 
            this.btn_CloseChildForm.FlatAppearance.BorderSize = 0;
            this.btn_CloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CloseChildForm.Image = ((System.Drawing.Image)(resources.GetObject("btn_CloseChildForm.Image")));
            this.btn_CloseChildForm.Location = new System.Drawing.Point(102, 3);
            this.btn_CloseChildForm.Name = "btn_CloseChildForm";
            this.btn_CloseChildForm.Size = new System.Drawing.Size(75, 99);
            this.btn_CloseChildForm.TabIndex = 1;
            this.btn_CloseChildForm.UseVisualStyleBackColor = true;
            this.btn_CloseChildForm.Click += new System.EventHandler(this.btn_CloseChildForm_Click);
            // 
            // lbl_home
            // 
            this.lbl_home.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_home.AutoSize = true;
            this.lbl_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home.ForeColor = System.Drawing.Color.White;
            this.lbl_home.Location = new System.Drawing.Point(545, 35);
            this.lbl_home.Name = "lbl_home";
            this.lbl_home.Size = new System.Drawing.Size(448, 38);
            this.lbl_home.TabIndex = 0;
            this.lbl_home.Text = "Hệ thống quản lý khách sạn";
            this.lbl_home.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btn_doanhthu);
            this.panel1.Controls.Add(this.btn_sluser);
            this.panel1.Controls.Add(this.btn_slkh);
            this.panel1.Controls.Add(this.btn_bddanhthu);
            this.panel1.Controls.Add(this.btn_sldv);
            this.panel1.Controls.Add(this.btn_slnv);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1351, 657);
            this.panel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.LightYellow;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.Controls.Add(this.groupBox_thongtincuochop);
            this.panel4.Location = new System.Drawing.Point(29, 246);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1281, 401);
            this.panel4.TabIndex = 17;
            // 
            // groupBox_thongtincuochop
            // 
            this.groupBox_thongtincuochop.Controls.Add(this.dateTimePicker_lichhop);
            this.groupBox_thongtincuochop.Controls.Add(this.btn_timkiem);
            this.groupBox_thongtincuochop.Controls.Add(this.btn_xoa);
            this.groupBox_thongtincuochop.Controls.Add(this.btn_sửa);
            this.groupBox_thongtincuochop.Controls.Add(this.btn_them);
            this.groupBox_thongtincuochop.Controls.Add(this.lbl_thoigian);
            this.groupBox_thongtincuochop.Controls.Add(this.tb_noidung);
            this.groupBox_thongtincuochop.Controls.Add(this.lbl_noidung);
            this.groupBox_thongtincuochop.Controls.Add(this.tb_stt);
            this.groupBox_thongtincuochop.Controls.Add(this.lbl_stt);
            this.groupBox_thongtincuochop.Controls.Add(this.tb_timkiem);
            this.groupBox_thongtincuochop.Controls.Add(this.dataGridView1);
            this.groupBox_thongtincuochop.Controls.Add(this.lbl_timkiemlichhoptheongay);
            this.groupBox_thongtincuochop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_thongtincuochop.Location = new System.Drawing.Point(20, 17);
            this.groupBox_thongtincuochop.Name = "groupBox_thongtincuochop";
            this.groupBox_thongtincuochop.Size = new System.Drawing.Size(1243, 401);
            this.groupBox_thongtincuochop.TabIndex = 16;
            this.groupBox_thongtincuochop.TabStop = false;
            this.groupBox_thongtincuochop.Text = "Thông tin cuộc họp";
            // 
            // dateTimePicker_lichhop
            // 
            this.dateTimePicker_lichhop.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateTimePicker_lichhop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_lichhop.Location = new System.Drawing.Point(190, 211);
            this.dateTimePicker_lichhop.Name = "dateTimePicker_lichhop";
            this.dateTimePicker_lichhop.Size = new System.Drawing.Size(219, 27);
            this.dateTimePicker_lichhop.TabIndex = 30;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timkiem.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.Location = new System.Drawing.Point(1075, 28);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(145, 46);
            this.btn_timkiem.TabIndex = 29;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(362, 325);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(145, 47);
            this.btn_xoa.TabIndex = 28;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sửa
            // 
            this.btn_sửa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sửa.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sửa.Location = new System.Drawing.Point(190, 325);
            this.btn_sửa.Name = "btn_sửa";
            this.btn_sửa.Size = new System.Drawing.Size(145, 47);
            this.btn_sửa.TabIndex = 27;
            this.btn_sửa.Text = "Sửa";
            this.btn_sửa.UseVisualStyleBackColor = true;
            this.btn_sửa.Click += new System.EventHandler(this.btn_sửa_Click);
            // 
            // btn_them
            // 
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(15, 325);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(145, 47);
            this.btn_them.TabIndex = 26;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // lbl_thoigian
            // 
            this.lbl_thoigian.AutoSize = true;
            this.lbl_thoigian.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_thoigian.Location = new System.Drawing.Point(24, 212);
            this.lbl_thoigian.Name = "lbl_thoigian";
            this.lbl_thoigian.Size = new System.Drawing.Size(114, 29);
            this.lbl_thoigian.TabIndex = 24;
            this.lbl_thoigian.Text = "Thời gian";
            // 
            // tb_noidung
            // 
            this.tb_noidung.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_noidung.Location = new System.Drawing.Point(190, 133);
            this.tb_noidung.Name = "tb_noidung";
            this.tb_noidung.Size = new System.Drawing.Size(219, 34);
            this.tb_noidung.TabIndex = 23;
            // 
            // lbl_noidung
            // 
            this.lbl_noidung.AutoSize = true;
            this.lbl_noidung.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noidung.Location = new System.Drawing.Point(24, 136);
            this.lbl_noidung.Name = "lbl_noidung";
            this.lbl_noidung.Size = new System.Drawing.Size(117, 29);
            this.lbl_noidung.TabIndex = 22;
            this.lbl_noidung.Text = "Nội dung:";
            // 
            // tb_stt
            // 
            this.tb_stt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_stt.Location = new System.Drawing.Point(190, 67);
            this.tb_stt.Name = "tb_stt";
            this.tb_stt.Size = new System.Drawing.Size(219, 34);
            this.tb_stt.TabIndex = 21;
            // 
            // lbl_stt
            // 
            this.lbl_stt.AutoSize = true;
            this.lbl_stt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stt.Location = new System.Drawing.Point(24, 67);
            this.lbl_stt.Name = "lbl_stt";
            this.lbl_stt.Size = new System.Drawing.Size(67, 29);
            this.lbl_stt.TabIndex = 20;
            this.lbl_stt.Text = "STT:";
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_timkiem.Location = new System.Drawing.Point(785, 36);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(262, 30);
            this.tb_timkiem.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(533, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(687, 286);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // lbl_timkiemlichhoptheongay
            // 
            this.lbl_timkiemlichhoptheongay.AutoSize = true;
            this.lbl_timkiemlichhoptheongay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timkiemlichhoptheongay.Location = new System.Drawing.Point(570, 36);
            this.lbl_timkiemlichhoptheongay.Name = "lbl_timkiemlichhoptheongay";
            this.lbl_timkiemlichhoptheongay.Size = new System.Drawing.Size(209, 29);
            this.lbl_timkiemlichhoptheongay.TabIndex = 14;
            this.lbl_timkiemlichhoptheongay.Text = "Tìm kiếm lịch họp:";
            // 
            // btn_doanhthu
            // 
            this.btn_doanhthu.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_doanhthu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_doanhthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doanhthu.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_doanhthu.Location = new System.Drawing.Point(143, 140);
            this.btn_doanhthu.Name = "btn_doanhthu";
            this.btn_doanhthu.Size = new System.Drawing.Size(292, 96);
            this.btn_doanhthu.TabIndex = 11;
            this.btn_doanhthu.Text = "HĐ và lương nhân viên";
            this.btn_doanhthu.UseVisualStyleBackColor = false;
            this.btn_doanhthu.Click += new System.EventHandler(this.btn_doanhthu_Click);
            // 
            // btn_sluser
            // 
            this.btn_sluser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_sluser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sluser.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_sluser.Location = new System.Drawing.Point(143, 11);
            this.btn_sluser.Name = "btn_sluser";
            this.btn_sluser.Size = new System.Drawing.Size(292, 96);
            this.btn_sluser.TabIndex = 8;
            this.btn_sluser.Text = "Số lượng người quản lý: ";
            this.btn_sluser.UseVisualStyleBackColor = false;
            this.btn_sluser.Click += new System.EventHandler(this.btn_sluser_Click);
            // 
            // btn_slkh
            // 
            this.btn_slkh.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_slkh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_slkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_slkh.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_slkh.Location = new System.Drawing.Point(923, 11);
            this.btn_slkh.Name = "btn_slkh";
            this.btn_slkh.Size = new System.Drawing.Size(292, 96);
            this.btn_slkh.TabIndex = 13;
            this.btn_slkh.Text = "Số lượng khách hàng: ";
            this.btn_slkh.UseVisualStyleBackColor = false;
            this.btn_slkh.Click += new System.EventHandler(this.btn_slkh_Click);
            // 
            // btn_bddanhthu
            // 
            this.btn_bddanhthu.BackColor = System.Drawing.Color.Coral;
            this.btn_bddanhthu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bddanhthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bddanhthu.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_bddanhthu.Location = new System.Drawing.Point(923, 140);
            this.btn_bddanhthu.Name = "btn_bddanhthu";
            this.btn_bddanhthu.Size = new System.Drawing.Size(292, 96);
            this.btn_bddanhthu.TabIndex = 12;
            this.btn_bddanhthu.Text = "Biểu đồ doanh thu";
            this.btn_bddanhthu.UseVisualStyleBackColor = false;
            this.btn_bddanhthu.Click += new System.EventHandler(this.btn_bddoanhthu_Click);
            // 
            // btn_sldv
            // 
            this.btn_sldv.BackColor = System.Drawing.Color.Plum;
            this.btn_sldv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sldv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sldv.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_sldv.Location = new System.Drawing.Point(536, 144);
            this.btn_sldv.Name = "btn_sldv";
            this.btn_sldv.Size = new System.Drawing.Size(292, 96);
            this.btn_sldv.TabIndex = 10;
            this.btn_sldv.Text = "Số lượng dịch vụ: ";
            this.btn_sldv.UseVisualStyleBackColor = false;
            this.btn_sldv.Click += new System.EventHandler(this.btn_sldv_Click);
            // 
            // btn_slnv
            // 
            this.btn_slnv.BackColor = System.Drawing.Color.Thistle;
            this.btn_slnv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_slnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_slnv.ForeColor = System.Drawing.Color.Black;
            this.btn_slnv.Location = new System.Drawing.Point(536, 11);
            this.btn_slnv.Name = "btn_slnv";
            this.btn_slnv.Size = new System.Drawing.Size(292, 96);
            this.btn_slnv.TabIndex = 9;
            this.btn_slnv.Text = "Số lượng nhân viên: ";
            this.btn_slnv.UseVisualStyleBackColor = false;
            this.btn_slnv.Click += new System.EventHandler(this.btn_slnv_Click);
            // 
            // FormHomeGiamDoc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1351, 754);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_titlebar);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHomeGiamDoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.FormHomeGiamDoc_Load);
            this.panel_titlebar.ResumeLayout(false);
            this.panel_titlebar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox_thongtincuochop.ResumeLayout(false);
            this.groupBox_thongtincuochop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_titlebar;
        private System.Windows.Forms.Label lbl_home;
        private System.Windows.Forms.Button btn_CloseChildForm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_slkh;
        private System.Windows.Forms.Button btn_bddanhthu;
        private System.Windows.Forms.Button btn_doanhthu;
        private System.Windows.Forms.Button btn_sldv;
        private System.Windows.Forms.Button btn_slnv;
        private System.Windows.Forms.Button btn_sluser;
        private System.Windows.Forms.Panel panel_picture;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox_thongtincuochop;
        private System.Windows.Forms.Label lbl_timkiemlichhoptheongay;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sửa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label lbl_thoigian;
        private System.Windows.Forms.TextBox tb_noidung;
        private System.Windows.Forms.Label lbl_noidung;
        private System.Windows.Forms.TextBox tb_stt;
        private System.Windows.Forms.Label lbl_stt;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.DateTimePicker dateTimePicker_lichhop;
        private System.Windows.Forms.Panel pn_dangxuat;
    }
}