
namespace Quản_Lý_Khách_Sạn.Report
{
    partial class FormInHoaDon
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable_HoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new Quản_Lý_Khách_Sạn.Report.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tb_makh = new System.Windows.Forms.TextBox();
            this.btn_inhd = new System.Windows.Forms.Button();
            this.dateTimePicker_NgayTT = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_HoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable_HoaDonBindingSource
            // 
            this.DataTable_HoaDonBindingSource.DataMember = "DataTable_HoaDon";
            this.DataTable_HoaDonBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet_Report";
            reportDataSource2.Value = this.DataTable_HoaDonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Quản_Lý_Khách_Sạn.Report.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(317, 180);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(764, 500);
            this.reportViewer1.TabIndex = 0;
            // 
            // tb_makh
            // 
            this.tb_makh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_makh.Location = new System.Drawing.Point(518, 127);
            this.tb_makh.Name = "tb_makh";
            this.tb_makh.Size = new System.Drawing.Size(297, 34);
            this.tb_makh.TabIndex = 1;
            this.tb_makh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_makh_KeyDown);
            // 
            // btn_inhd
            // 
            this.btn_inhd.BackColor = System.Drawing.Color.White;
            this.btn_inhd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inhd.Location = new System.Drawing.Point(317, 127);
            this.btn_inhd.Name = "btn_inhd";
            this.btn_inhd.Size = new System.Drawing.Size(184, 34);
            this.btn_inhd.TabIndex = 2;
            this.btn_inhd.Text = "Nhập mã KH";
            this.btn_inhd.UseVisualStyleBackColor = false;
            this.btn_inhd.Click += new System.EventHandler(this.btn_inhd_Click);
            // 
            // dateTimePicker_NgayTT
            // 
            this.dateTimePicker_NgayTT.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_NgayTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_NgayTT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_NgayTT.Location = new System.Drawing.Point(831, 127);
            this.dateTimePicker_NgayTT.Name = "dateTimePicker_NgayTT";
            this.dateTimePicker_NgayTT.Size = new System.Drawing.Size(250, 34);
            this.dateTimePicker_NgayTT.TabIndex = 15;
            this.dateTimePicker_NgayTT.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // FormInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1221, 741);
            this.Controls.Add(this.dateTimePicker_NgayTT);
            this.Controls.Add(this.btn_inhd);
            this.Controls.Add(this.tb_makh);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormInHoaDon";
            this.Text = "In hóa đơn";
            this.Load += new System.EventHandler(this.FormInHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_HoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TextBox tb_makh;
        private System.Windows.Forms.Button btn_inhd;
        private System.Windows.Forms.BindingSource DataTable_HoaDonBindingSource;
        private DataSet1 DataSet1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayTT;
    }
}