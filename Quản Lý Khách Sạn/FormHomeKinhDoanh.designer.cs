
namespace Quản_Lý_Khách_Sạn
{
    partial class FormHomeKinhDoanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHomeKinhDoanh));
            this.panel_menu = new System.Windows.Forms.Panel();
            this.btn_nhansu = new System.Windows.Forms.Button();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.panel_Desktop = new System.Windows.Forms.Panel();
            this.panel_picture = new System.Windows.Forms.Panel();
            this.panel_titlebar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pn_dangxuat = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btn_CloseChildForm = new System.Windows.Forms.Button();
            this.lbl_home = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_menu.SuspendLayout();
            this.panel_logo.SuspendLayout();
            this.panel_titlebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel_menu.Controls.Add(this.btn_nhansu);
            this.panel_menu.Controls.Add(this.panel_logo);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(295, 754);
            this.panel_menu.TabIndex = 0;
            // 
            // btn_nhansu
            // 
            this.btn_nhansu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_nhansu.FlatAppearance.BorderSize = 0;
            this.btn_nhansu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nhansu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhansu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_nhansu.Image = ((System.Drawing.Image)(resources.GetObject("btn_nhansu.Image")));
            this.btn_nhansu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nhansu.Location = new System.Drawing.Point(0, 99);
            this.btn_nhansu.Name = "btn_nhansu";
            this.btn_nhansu.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_nhansu.Size = new System.Drawing.Size(295, 73);
            this.btn_nhansu.TabIndex = 1;
            this.btn_nhansu.Text = "   Biểu đồ kinh doanh";
            this.btn_nhansu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nhansu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_nhansu.UseVisualStyleBackColor = true;
            this.btn_nhansu.Click += new System.EventHandler(this.btn_nhansu_Click);
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel_logo.Controls.Add(this.panel_Desktop);
            this.panel_logo.Controls.Add(this.panel_picture);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.ForeColor = System.Drawing.Color.White;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(295, 99);
            this.panel_logo.TabIndex = 0;
            // 
            // panel_Desktop
            // 
            this.panel_Desktop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_Desktop.ForeColor = System.Drawing.Color.Black;
            this.panel_Desktop.Location = new System.Drawing.Point(280, 99);
            this.panel_Desktop.Name = "panel_Desktop";
            this.panel_Desktop.Size = new System.Drawing.Size(1324, 645);
            this.panel_Desktop.TabIndex = 2;
            // 
            // panel_picture
            // 
            this.panel_picture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_picture.BackgroundImage")));
            this.panel_picture.Location = new System.Drawing.Point(67, 3);
            this.panel_picture.Name = "panel_picture";
            this.panel_picture.Size = new System.Drawing.Size(107, 84);
            this.panel_picture.TabIndex = 0;
            // 
            // panel_titlebar
            // 
            this.panel_titlebar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel_titlebar.Controls.Add(this.panel2);
            this.panel_titlebar.Controls.Add(this.pn_dangxuat);
            this.panel_titlebar.Controls.Add(this.btnMinimize);
            this.panel_titlebar.Controls.Add(this.btnMaximize);
            this.panel_titlebar.Controls.Add(this.btnClose);
            this.panel_titlebar.Controls.Add(this.btn_CloseChildForm);
            this.panel_titlebar.Controls.Add(this.lbl_home);
            this.panel_titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_titlebar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.panel_titlebar.Location = new System.Drawing.Point(295, 0);
            this.panel_titlebar.Name = "panel_titlebar";
            this.panel_titlebar.Size = new System.Drawing.Size(1056, 99);
            this.panel_titlebar.TabIndex = 1;
            this.panel_titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_titlebar_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(1055, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(31, 32);
            this.panel2.TabIndex = 7;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // pn_dangxuat
            // 
            this.pn_dangxuat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_dangxuat.BackgroundImage")));
            this.pn_dangxuat.Location = new System.Drawing.Point(1120, 55);
            this.pn_dangxuat.Name = "pn_dangxuat";
            this.pn_dangxuat.Size = new System.Drawing.Size(31, 32);
            this.pn_dangxuat.TabIndex = 6;
            this.pn_dangxuat.Click += new System.EventHandler(this.pb_dangxuat_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(939, 3);
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
            this.btnMaximize.Location = new System.Drawing.Point(980, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(35, 35);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.Text = "O";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1021, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btn_CloseChildForm
            // 
            this.btn_CloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_CloseChildForm.FlatAppearance.BorderSize = 0;
            this.btn_CloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CloseChildForm.Image = ((System.Drawing.Image)(resources.GetObject("btn_CloseChildForm.Image")));
            this.btn_CloseChildForm.Location = new System.Drawing.Point(0, 0);
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
            this.lbl_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home.ForeColor = System.Drawing.Color.White;
            this.lbl_home.Location = new System.Drawing.Point(463, 28);
            this.lbl_home.Name = "lbl_home";
            this.lbl_home.Size = new System.Drawing.Size(103, 32);
            this.lbl_home.TabIndex = 0;
            this.lbl_home.Text = "HOME";
            this.lbl_home.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(295, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1130, 762);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(169, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(764, 464);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormHomeKinhDoanh
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1351, 754);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_titlebar);
            this.Controls.Add(this.panel_menu);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHomeKinhDoanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel_menu.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            this.panel_titlebar.ResumeLayout(false);
            this.panel_titlebar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Button btn_nhansu;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Panel panel_titlebar;
        private System.Windows.Forms.Label lbl_home;
        private System.Windows.Forms.Panel panel_picture;
        private System.Windows.Forms.Button btn_CloseChildForm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Panel panel_Desktop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pn_dangxuat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
    }
}