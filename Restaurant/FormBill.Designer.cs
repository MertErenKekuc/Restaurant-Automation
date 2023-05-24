namespace Restaurant
{
    partial class FormBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBill));
            this.gbPayementInfo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPay = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.gbPayementType = new System.Windows.Forms.GroupBox();
            this.rbCreditCard = new System.Windows.Forms.RadioButton();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.lvProducts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTurnBack = new System.Windows.Forms.Button();
            this.lbBillID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gbPayementInfo.SuspendLayout();
            this.gbPayementType.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPayementInfo
            // 
            this.gbPayementInfo.BackColor = System.Drawing.Color.Transparent;
            this.gbPayementInfo.Controls.Add(this.label2);
            this.gbPayementInfo.Controls.Add(this.lbPay);
            this.gbPayementInfo.Controls.Add(this.lbTotal);
            this.gbPayementInfo.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPayementInfo.Location = new System.Drawing.Point(103, 293);
            this.gbPayementInfo.Name = "gbPayementInfo";
            this.gbPayementInfo.Size = new System.Drawing.Size(263, 96);
            this.gbPayementInfo.TabIndex = 0;
            this.gbPayementInfo.TabStop = false;
            this.gbPayementInfo.Text = "Payement Info";
            this.gbPayementInfo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "$";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbPay
            // 
            this.lbPay.AutoSize = true;
            this.lbPay.Location = new System.Drawing.Point(114, 43);
            this.lbPay.Name = "lbPay";
            this.lbPay.Size = new System.Drawing.Size(27, 26);
            this.lbPay.TabIndex = 1;
            this.lbPay.Text = "0";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(18, 43);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(67, 26);
            this.lbTotal.TabIndex = 0;
            this.lbTotal.Text = "Total";
            // 
            // gbPayementType
            // 
            this.gbPayementType.BackColor = System.Drawing.Color.Transparent;
            this.gbPayementType.Controls.Add(this.rbCreditCard);
            this.gbPayementType.Controls.Add(this.rbCash);
            this.gbPayementType.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPayementType.Location = new System.Drawing.Point(412, 284);
            this.gbPayementType.Name = "gbPayementType";
            this.gbPayementType.Size = new System.Drawing.Size(242, 135);
            this.gbPayementType.TabIndex = 1;
            this.gbPayementType.TabStop = false;
            this.gbPayementType.Text = "Payement Type";
            // 
            // rbCreditCard
            // 
            this.rbCreditCard.AutoSize = true;
            this.rbCreditCard.Location = new System.Drawing.Point(12, 76);
            this.rbCreditCard.Name = "rbCreditCard";
            this.rbCreditCard.Size = new System.Drawing.Size(154, 30);
            this.rbCreditCard.TabIndex = 1;
            this.rbCreditCard.TabStop = true;
            this.rbCreditCard.Text = "Credit Card";
            this.rbCreditCard.UseVisualStyleBackColor = true;
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Location = new System.Drawing.Point(12, 39);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(78, 30);
            this.rbCash.TabIndex = 0;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Cash";
            this.rbCash.UseVisualStyleBackColor = true;
            // 
            // lvProducts
            // 
            this.lvProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvProducts.FullRowSelect = true;
            this.lvProducts.GridLines = true;
            this.lvProducts.HideSelection = false;
            this.lvProducts.Location = new System.Drawing.Point(126, 67);
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.Size = new System.Drawing.Size(489, 186);
            this.lvProducts.TabIndex = 2;
            this.lvProducts.UseCompatibleStateImageBehavior = false;
            this.lvProducts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product Name";
            this.columnHeader1.Width = 147;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Piece";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ProductID";
            this.columnHeader3.Width = 101;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price";
            this.columnHeader4.Width = 76;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "SalesID";
            this.columnHeader5.Width = 91;
            // 
            // btnTurnBack
            // 
            this.btnTurnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnTurnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTurnBack.BackgroundImage")));
            this.btnTurnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTurnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTurnBack.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurnBack.Location = new System.Drawing.Point(741, 359);
            this.btnTurnBack.Name = "btnTurnBack";
            this.btnTurnBack.Size = new System.Drawing.Size(72, 60);
            this.btnTurnBack.TabIndex = 8;
            this.btnTurnBack.UseVisualStyleBackColor = false;
            this.btnTurnBack.Click += new System.EventHandler(this.btnTurnBack_Click);
            // 
            // lbBillID
            // 
            this.lbBillID.AutoSize = true;
            this.lbBillID.BackColor = System.Drawing.Color.Transparent;
            this.lbBillID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbBillID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbBillID.Location = new System.Drawing.Point(131, 42);
            this.lbBillID.Name = "lbBillID";
            this.lbBillID.Size = new System.Drawing.Size(30, 22);
            this.lbBillID.TabIndex = 9;
            this.lbBillID.Text = "11";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(683, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 82);
            this.button1.TabIndex = 10;
            this.button1.Text = "Close Account";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = global::Restaurant.Properties.Resources.pngegg__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 540);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbBillID);
            this.Controls.Add(this.btnTurnBack);
            this.Controls.Add(this.lvProducts);
            this.Controls.Add(this.gbPayementType);
            this.Controls.Add(this.gbPayementInfo);
            this.Name = "FormBill";
            this.Text = "FormBill";
            this.Load += new System.EventHandler(this.FormBill_Load);
            this.gbPayementInfo.ResumeLayout(false);
            this.gbPayementInfo.PerformLayout();
            this.gbPayementType.ResumeLayout(false);
            this.gbPayementType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPayementInfo;
        private System.Windows.Forms.GroupBox gbPayementType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPay;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.RadioButton rbCreditCard;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.ListView lvProducts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnTurnBack;
        private System.Windows.Forms.Label lbBillID;
        public System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button1;
    }
}