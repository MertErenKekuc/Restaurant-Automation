namespace Restaurant
{
    partial class FormCheckout
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCheckout));
            Restaurant.dataSet2 dataSet22 = new Restaurant.dataSet2();
            this.dataTable2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Restaurant.DataSet1();
            this.dataTable3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnMonthlyReport = new System.Windows.Forms.Button();
            this.btnDailyReport = new System.Windows.Forms.Button();
            this.rpvMounth = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rpvDay = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnTurnBack = new System.Windows.Forms.Button();
            this.restaurantDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet21 = new Restaurant.DataSet2();
            this.dataTable1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter1 = new Restaurant.DataSet2TableAdapters.DataTable1TableAdapter();
            this.dataTable2BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable2BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable2TableAdapter = new Restaurant.DataSet1TableAdapters.DataTable2TableAdapter();
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new Restaurant.DataSet1TableAdapters.DataTable1TableAdapter();
            this.dataSet1BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable3TableAdapter = new Restaurant.DataSet1TableAdapters.DataTable3TableAdapter();
            this.dataTable1BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable3BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable2BindingSource1
            // 
            this.dataTable2BindingSource1.DataMember = "DataTable2";
            this.dataTable2BindingSource1.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable3BindingSource
            // 
            this.dataTable3BindingSource.DataMember = "DataTable3";
            this.dataTable3BindingSource.DataSource = this.dataSet1;
            // 
            // btnMonthlyReport
            // 
            this.btnMonthlyReport.BackColor = System.Drawing.Color.Purple;
            this.btnMonthlyReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonthlyReport.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonthlyReport.Location = new System.Drawing.Point(46, 200);
            this.btnMonthlyReport.Name = "btnMonthlyReport";
            this.btnMonthlyReport.Size = new System.Drawing.Size(125, 81);
            this.btnMonthlyReport.TabIndex = 1;
            this.btnMonthlyReport.Text = "Mounthly Report";
            this.btnMonthlyReport.UseVisualStyleBackColor = false;
            this.btnMonthlyReport.Click += new System.EventHandler(this.btnMonthlyReport_Click);
            // 
            // btnDailyReport
            // 
            this.btnDailyReport.BackColor = System.Drawing.Color.Purple;
            this.btnDailyReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDailyReport.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDailyReport.Location = new System.Drawing.Point(46, 329);
            this.btnDailyReport.Name = "btnDailyReport";
            this.btnDailyReport.Size = new System.Drawing.Size(125, 81);
            this.btnDailyReport.TabIndex = 1;
            this.btnDailyReport.Text = "Daily Report";
            this.btnDailyReport.UseVisualStyleBackColor = false;
            this.btnDailyReport.Click += new System.EventHandler(this.btnDailyReport_Click);
            // 
            // rpvMounth
            // 
            reportDataSource1.Name = "DataSet12";
            reportDataSource1.Value = this.dataTable1BindingSource3;
            this.rpvMounth.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvMounth.LocalReport.ReportEmbeddedResource = "Restaurant.Report2.rdlc";
            this.rpvMounth.Location = new System.Drawing.Point(230, 12);
            this.rpvMounth.Name = "rpvMounth";
            this.rpvMounth.ServerReport.BearerToken = null;
            this.rpvMounth.Size = new System.Drawing.Size(530, 269);
            this.rpvMounth.TabIndex = 2;
            this.rpvMounth.Load += new System.EventHandler(this.rpvMounth_Load);
            // 
            // rpvDay
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.dataTable3BindingSource1;
            this.rpvDay.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvDay.LocalReport.ReportEmbeddedResource = "Restaurant.Report4.rdlc";
            this.rpvDay.Location = new System.Drawing.Point(230, 329);
            this.rpvDay.Name = "rpvDay";
            this.rpvDay.ServerReport.BearerToken = null;
            this.rpvDay.Size = new System.Drawing.Size(530, 279);
            this.rpvDay.TabIndex = 3;
            this.rpvDay.Load += new System.EventHandler(this.rpvDay_Load);
            // 
            // btnTurnBack
            // 
            this.btnTurnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnTurnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTurnBack.BackgroundImage")));
            this.btnTurnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTurnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTurnBack.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurnBack.Location = new System.Drawing.Point(785, 548);
            this.btnTurnBack.Name = "btnTurnBack";
            this.btnTurnBack.Size = new System.Drawing.Size(72, 60);
            this.btnTurnBack.TabIndex = 9;
            this.btnTurnBack.UseVisualStyleBackColor = false;
            this.btnTurnBack.Click += new System.EventHandler(this.btnTurnBack_Click);
            // 
            // dataSet21
            // 
            this.dataSet21.DataSetName = "DataSet2";
            this.dataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource2
            // 
            this.dataTable1BindingSource2.DataMember = "DataTable1";
            this.dataTable1BindingSource2.DataSource = this.dataSet21;
            // 
            // dataTable1TableAdapter1
            // 
            this.dataTable1TableAdapter1.ClearBeforeFill = true;
            // 
            // dataTable2BindingSource2
            // 
            this.dataTable2BindingSource2.DataMember = "DataTable2";
            this.dataTable2BindingSource2.DataSource = this.dataSet1BindingSource2;
            // 
            // dataSet1BindingSource2
            // 
            this.dataSet1BindingSource2.DataSource = this.dataSet1;
            this.dataSet1BindingSource2.Position = 0;
            // 
            // dataSet2BindingSource
            // 
            this.dataSet2BindingSource.DataSource = dataSet22;
            this.dataSet2BindingSource.Position = 0;
            // 
            // dataTable2BindingSource3
            // 
            this.dataTable2BindingSource3.DataMember = "DataTable2";
            this.dataTable2BindingSource3.DataSource = this.dataSet1;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.dataSet1;
            this.DataTable1BindingSource.CurrentChanged += new System.EventHandler(this.DataTable1BindingSource_CurrentChanged);
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1BindingSource1
            // 
            this.dataSet1BindingSource1.DataSource = this.dataSet1;
            this.dataSet1BindingSource1.Position = 0;
            // 
            // DataTable2BindingSource
            // 
            this.DataTable2BindingSource.DataMember = "DataTable2";
            this.DataTable2BindingSource.DataSource = this.dataSet1;
            // 
            // dataTable2TableAdapter
            // 
            this.dataTable2TableAdapter.ClearBeforeFill = true;
            // 
            // dataTable1BindingSource1
            // 
            this.dataTable1BindingSource1.DataMember = "DataTable1";
            this.dataTable1BindingSource1.DataSource = this.dataSet1;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // dataSet1BindingSource3
            // 
            this.dataSet1BindingSource3.DataSource = this.dataSet1;
            this.dataSet1BindingSource3.Position = 0;
            // 
            // dataSet1BindingSource4
            // 
            this.dataSet1BindingSource4.DataSource = this.dataSet1;
            this.dataSet1BindingSource4.Position = 0;
            // 
            // dataTable3TableAdapter
            // 
            this.dataTable3TableAdapter.ClearBeforeFill = true;
            // 
            // dataTable1BindingSource3
            // 
            this.dataTable1BindingSource3.DataMember = "DataTable1";
            this.dataTable1BindingSource3.DataSource = this.dataSet21;
            // 
            // dataTable3BindingSource1
            // 
            this.dataTable3BindingSource1.DataMember = "DataTable3";
            this.dataTable3BindingSource1.DataSource = this.dataSet1;
            // 
            // FormCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = global::Restaurant.Properties.Resources.pngegg__1_;
            this.ClientSize = new System.Drawing.Size(899, 636);
            this.Controls.Add(this.btnTurnBack);
            this.Controls.Add(this.rpvDay);
            this.Controls.Add(this.rpvMounth);
            this.Controls.Add(this.btnDailyReport);
            this.Controls.Add(this.btnMonthlyReport);
            this.Name = "FormCheckout";
            this.Text = "FormCheckout";
            this.Load += new System.EventHandler(this.FormCheckout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMonthlyReport;
        private System.Windows.Forms.Button btnDailyReport;
        private Microsoft.Reporting.WinForms.ReportViewer rpvMounth;
        private System.Windows.Forms.BindingSource restaurantDataSetBindingSource;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer rpvDay;
        private System.Windows.Forms.BindingSource DataTable2BindingSource;
        private System.Windows.Forms.BindingSource dataSet1BindingSource1;
        private System.Windows.Forms.Button btnTurnBack;
        private System.Windows.Forms.BindingSource dataSet2BindingSource;
        private dataSet2 dataSet2;
        private System.Windows.Forms.BindingSource dataTable2BindingSource1;
        private DataSet1TableAdapters.DataTable2TableAdapter dataTable2TableAdapter;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
        private DataSet1TableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private DataSet2 dataSet21;
        private System.Windows.Forms.BindingSource dataTable1BindingSource2;
        private DataSet2TableAdapters.DataTable1TableAdapter dataTable1TableAdapter1;
        private System.Windows.Forms.BindingSource dataTable2BindingSource3;
        private System.Windows.Forms.BindingSource dataSet1BindingSource2;
        private System.Windows.Forms.BindingSource dataTable2BindingSource2;
        private System.Windows.Forms.BindingSource dataSet1BindingSource3;
        private System.Windows.Forms.BindingSource dataSet1BindingSource4;
        private System.Windows.Forms.BindingSource dataTable3BindingSource;
        private DataSet1TableAdapters.DataTable3TableAdapter dataTable3TableAdapter;
        private System.Windows.Forms.BindingSource dataTable1BindingSource3;
        private System.Windows.Forms.BindingSource dataTable3BindingSource1;
    }
}