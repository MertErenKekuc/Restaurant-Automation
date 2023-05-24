namespace Restaurant
{
    partial class FormReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReservation));
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.lblNuberPerson = new System.Windows.Forms.Label();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.cbNumberPerson = new System.Windows.Forms.ComboBox();
            this.lvCustomer = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblCustomer = new System.Windows.Forms.Label();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnOpenReservation = new System.Windows.Forms.Button();
            this.btnTurnBack = new System.Windows.Forms.Button();
            this.dtTime = new System.Windows.Forms.DateTimePicker();
            this.tbTableNo = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbNomberPerson = new System.Windows.Forms.TextBox();
            this.tbtable = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(156, 134);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(67, 29);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date";
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.BackColor = System.Drawing.Color.Transparent;
            this.lblTable.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.Location = new System.Drawing.Point(150, 173);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(73, 29);
            this.lblTable.TabIndex = 1;
            this.lblTable.Text = "Table";
            // 
            // lblNuberPerson
            // 
            this.lblNuberPerson.AutoSize = true;
            this.lblNuberPerson.BackColor = System.Drawing.Color.Transparent;
            this.lblNuberPerson.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuberPerson.Location = new System.Drawing.Point(31, 215);
            this.lblNuberPerson.Name = "lblNuberPerson";
            this.lblNuberPerson.Size = new System.Drawing.Size(192, 29);
            this.lblNuberPerson.TabIndex = 2;
            this.lblNuberPerson.Text = "Number Person";
            // 
            // cbTable
            // 
            this.cbTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbTable.FormattingEnabled = true;
            this.cbTable.Location = new System.Drawing.Point(368, 178);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(77, 26);
            this.cbTable.TabIndex = 4;
            this.cbTable.SelectedIndexChanged += new System.EventHandler(this.cbTable_SelectedIndexChanged);
            this.cbTable.MouseEnter += new System.EventHandler(this.cbTable_MouseEnter);
            this.cbTable.MouseLeave += new System.EventHandler(this.cbTable_MouseLeave);
            // 
            // cbNumberPerson
            // 
            this.cbNumberPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbNumberPerson.FormattingEnabled = true;
            this.cbNumberPerson.Location = new System.Drawing.Point(368, 213);
            this.cbNumberPerson.Name = "cbNumberPerson";
            this.cbNumberPerson.Size = new System.Drawing.Size(77, 26);
            this.cbNumberPerson.TabIndex = 5;
            this.cbNumberPerson.SelectedIndexChanged += new System.EventHandler(this.cbNumberPerson_SelectedIndexChanged);
            this.cbNumberPerson.MouseEnter += new System.EventHandler(this.cbNumberPerson_MouseEnter);
            this.cbNumberPerson.MouseLeave += new System.EventHandler(this.cbNumberPerson_MouseLeave);
            // 
            // lvCustomer
            // 
            this.lvCustomer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.ColumnHeader,
            this.columnHeader1});
            this.lvCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvCustomer.FullRowSelect = true;
            this.lvCustomer.GridLines = true;
            this.lvCustomer.HideSelection = false;
            this.lvCustomer.Location = new System.Drawing.Point(644, 99);
            this.lvCustomer.Name = "lvCustomer";
            this.lvCustomer.Size = new System.Drawing.Size(386, 181);
            this.lvCustomer.TabIndex = 6;
            this.lvCustomer.UseCompatibleStateImageBehavior = false;
            this.lvCustomer.View = System.Windows.Forms.View.Details;
            this.lvCustomer.SelectedIndexChanged += new System.EventHandler(this.lvCustomer_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 2;
            this.columnHeader2.Text = "CustomerNo";
            this.columnHeader2.Width = 126;
            // 
            // ColumnHeader
            // 
            this.ColumnHeader.DisplayIndex = 0;
            this.ColumnHeader.Text = "Name";
            this.ColumnHeader.Width = 107;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 1;
            this.columnHeader1.Text = "Surname";
            this.columnHeader1.Width = 124;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomer.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(639, 67);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(123, 29);
            this.lblCustomer.TabIndex = 7;
            this.lblCustomer.Text = "Customer";
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.BackColor = System.Drawing.Color.Green;
            this.btnNewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewCustomer.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCustomer.Location = new System.Drawing.Point(356, 354);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(146, 89);
            this.btnNewCustomer.TabIndex = 9;
            this.btnNewCustomer.Text = "New Customer";
            this.btnNewCustomer.UseVisualStyleBackColor = false;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.BackColor = System.Drawing.Color.Purple;
            this.btnUpdateCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCustomer.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCustomer.Location = new System.Drawing.Point(660, 354);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(146, 89);
            this.btnUpdateCustomer.TabIndex = 11;
            this.btnUpdateCustomer.Text = "Update Customer";
            this.btnUpdateCustomer.UseVisualStyleBackColor = false;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnOpenReservation
            // 
            this.btnOpenReservation.BackColor = System.Drawing.Color.Teal;
            this.btnOpenReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenReservation.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenReservation.Location = new System.Drawing.Point(508, 354);
            this.btnOpenReservation.Name = "btnOpenReservation";
            this.btnOpenReservation.Size = new System.Drawing.Size(146, 89);
            this.btnOpenReservation.TabIndex = 12;
            this.btnOpenReservation.Text = "Open Reservation";
            this.btnOpenReservation.UseVisualStyleBackColor = false;
            this.btnOpenReservation.Click += new System.EventHandler(this.btnOpenReservation_Click);
            // 
            // btnTurnBack
            // 
            this.btnTurnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnTurnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTurnBack.BackgroundImage")));
            this.btnTurnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTurnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTurnBack.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurnBack.Location = new System.Drawing.Point(953, 372);
            this.btnTurnBack.Name = "btnTurnBack";
            this.btnTurnBack.Size = new System.Drawing.Size(72, 60);
            this.btnTurnBack.TabIndex = 13;
            this.btnTurnBack.UseVisualStyleBackColor = false;
            this.btnTurnBack.Click += new System.EventHandler(this.btnTurnBack_Click);
            // 
            // dtTime
            // 
            this.dtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtTime.Location = new System.Drawing.Point(451, 145);
            this.dtTime.Name = "dtTime";
            this.dtTime.Size = new System.Drawing.Size(77, 22);
            this.dtTime.TabIndex = 14;
            this.dtTime.ValueChanged += new System.EventHandler(this.dtTime_ValueChanged);
            this.dtTime.Enter += new System.EventHandler(this.dtTime_Enter);
            this.dtTime.MouseEnter += new System.EventHandler(this.dtTime_MouseEnter);
            this.dtTime.MouseLeave += new System.EventHandler(this.dtTime_MouseLeave);
            // 
            // tbTableNo
            // 
            this.tbTableNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbTableNo.Location = new System.Drawing.Point(241, 180);
            this.tbTableNo.Name = "tbTableNo";
            this.tbTableNo.ReadOnly = true;
            this.tbTableNo.Size = new System.Drawing.Size(121, 24);
            this.tbTableNo.TabIndex = 15;
            // 
            // tbDate
            // 
            this.tbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbDate.Location = new System.Drawing.Point(241, 143);
            this.tbDate.Name = "tbDate";
            this.tbDate.ReadOnly = true;
            this.tbDate.Size = new System.Drawing.Size(204, 24);
            this.tbDate.TabIndex = 15;
            // 
            // tbNomberPerson
            // 
            this.tbNomberPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbNomberPerson.Location = new System.Drawing.Point(241, 215);
            this.tbNomberPerson.Name = "tbNomberPerson";
            this.tbNomberPerson.ReadOnly = true;
            this.tbNomberPerson.Size = new System.Drawing.Size(121, 24);
            this.tbNomberPerson.TabIndex = 15;
            // 
            // tbtable
            // 
            this.tbtable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbtable.Location = new System.Drawing.Point(451, 180);
            this.tbtable.Name = "tbtable";
            this.tbtable.ReadOnly = true;
            this.tbtable.Size = new System.Drawing.Size(27, 24);
            this.tbtable.TabIndex = 15;
            this.tbtable.Visible = false;
            // 
            // FormReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = global::Restaurant.Properties.Resources.pngegg__1_;
            this.ClientSize = new System.Drawing.Size(1146, 526);
            this.Controls.Add(this.tbNomberPerson);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.tbtable);
            this.Controls.Add(this.tbTableNo);
            this.Controls.Add(this.dtTime);
            this.Controls.Add(this.btnTurnBack);
            this.Controls.Add(this.btnOpenReservation);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.btnNewCustomer);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lvCustomer);
            this.Controls.Add(this.cbNumberPerson);
            this.Controls.Add(this.cbTable);
            this.Controls.Add(this.lblNuberPerson);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.lblDate);
            this.Name = "FormReservation";
            this.Text = "FormReservation";
            this.Load += new System.EventHandler(this.FormReservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label lblNuberPerson;
        private System.Windows.Forms.ComboBox cbTable;
        private System.Windows.Forms.ComboBox cbNumberPerson;
        private System.Windows.Forms.ListView lvCustomer;
        private System.Windows.Forms.ColumnHeader ColumnHeader;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnOpenReservation;
        private System.Windows.Forms.Button btnTurnBack;
        private System.Windows.Forms.DateTimePicker dtTime;
        private System.Windows.Forms.TextBox tbTableNo;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.TextBox tbNomberPerson;
        private System.Windows.Forms.TextBox tbtable;
    }
}