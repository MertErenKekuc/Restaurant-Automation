namespace Restaurant
{
    partial class FormKitchen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKitchen));
            this.lvCategory = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.pnlProduct = new System.Windows.Forms.Panel();
            this.tbCategoryID2 = new System.Windows.Forms.TextBox();
            this.tbProductID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbProductCategory = new System.Windows.Forms.ComboBox();
            this.tbProductPrice = new System.Windows.Forms.TextBox();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.pnlCategory = new System.Windows.Forms.Panel();
            this.tbCategoryID = new System.Windows.Forms.TextBox();
            this.lbCategoryName = new System.Windows.Forms.Label();
            this.tbCategoryName = new System.Windows.Forms.TextBox();
            this.lvProductList = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rbProduct = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTurnBack = new System.Windows.Forms.Button();
            this.pnlProduct.SuspendLayout();
            this.pnlCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvCategory
            // 
            this.lvCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvCategory.FullRowSelect = true;
            this.lvCategory.GridLines = true;
            this.lvCategory.HideSelection = false;
            this.lvCategory.Location = new System.Drawing.Point(574, 440);
            this.lvCategory.Name = "lvCategory";
            this.lvCategory.Size = new System.Drawing.Size(310, 144);
            this.lvCategory.TabIndex = 0;
            this.lvCategory.UseCompatibleStateImageBehavior = false;
            this.lvCategory.View = System.Windows.Forms.View.Details;
            this.lvCategory.SelectedIndexChanged += new System.EventHandler(this.lvCategory_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CategoryID";
            this.columnHeader1.Width = 126;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "CategoryName";
            this.columnHeader2.Width = 184;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(339, 345);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 66);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(557, 345);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 66);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.Yellow;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(448, 345);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(103, 66);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // pnlProduct
            // 
            this.pnlProduct.BackColor = System.Drawing.Color.Transparent;
            this.pnlProduct.Controls.Add(this.tbCategoryID2);
            this.pnlProduct.Controls.Add(this.tbProductID);
            this.pnlProduct.Controls.Add(this.label2);
            this.pnlProduct.Controls.Add(this.label4);
            this.pnlProduct.Controls.Add(this.label3);
            this.pnlProduct.Controls.Add(this.label1);
            this.pnlProduct.Controls.Add(this.cbProductCategory);
            this.pnlProduct.Controls.Add(this.tbProductPrice);
            this.pnlProduct.Controls.Add(this.tbProductName);
            this.pnlProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlProduct.Location = new System.Drawing.Point(37, 159);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(426, 154);
            this.pnlProduct.TabIndex = 2;
            // 
            // tbCategoryID2
            // 
            this.tbCategoryID2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbCategoryID2.Location = new System.Drawing.Point(399, 18);
            this.tbCategoryID2.Name = "tbCategoryID2";
            this.tbCategoryID2.Size = new System.Drawing.Size(24, 24);
            this.tbCategoryID2.TabIndex = 4;
            // 
            // tbProductID
            // 
            this.tbProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbProductID.Location = new System.Drawing.Point(234, 109);
            this.tbProductID.Name = "tbProductID";
            this.tbProductID.Size = new System.Drawing.Size(30, 24);
            this.tbProductID.TabIndex = 4;
            this.tbProductID.TextChanged += new System.EventHandler(this.tbProductID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Product Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Product Name";
            // 
            // cbProductCategory
            // 
            this.cbProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbProductCategory.FormattingEnabled = true;
            this.cbProductCategory.Location = new System.Drawing.Point(234, 16);
            this.cbProductCategory.Name = "cbProductCategory";
            this.cbProductCategory.Size = new System.Drawing.Size(159, 26);
            this.cbProductCategory.TabIndex = 2;
            this.cbProductCategory.SelectedIndexChanged += new System.EventHandler(this.cbProductCategory_SelectedIndexChanged);
            // 
            // tbProductPrice
            // 
            this.tbProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbProductPrice.Location = new System.Drawing.Point(234, 75);
            this.tbProductPrice.Name = "tbProductPrice";
            this.tbProductPrice.Size = new System.Drawing.Size(159, 24);
            this.tbProductPrice.TabIndex = 1;
            // 
            // tbProductName
            // 
            this.tbProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbProductName.Location = new System.Drawing.Point(234, 47);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(159, 24);
            this.tbProductName.TabIndex = 0;
            // 
            // pnlCategory
            // 
            this.pnlCategory.BackColor = System.Drawing.Color.Transparent;
            this.pnlCategory.Controls.Add(this.tbCategoryID);
            this.pnlCategory.Controls.Add(this.lbCategoryName);
            this.pnlCategory.Controls.Add(this.tbCategoryName);
            this.pnlCategory.Location = new System.Drawing.Point(514, 172);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(370, 120);
            this.pnlCategory.TabIndex = 2;
            this.pnlCategory.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCategory_Paint);
            // 
            // tbCategoryID
            // 
            this.tbCategoryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbCategoryID.Location = new System.Drawing.Point(344, 46);
            this.tbCategoryID.Name = "tbCategoryID";
            this.tbCategoryID.Size = new System.Drawing.Size(13, 24);
            this.tbCategoryID.TabIndex = 4;
            // 
            // lbCategoryName
            // 
            this.lbCategoryName.AutoSize = true;
            this.lbCategoryName.BackColor = System.Drawing.Color.Transparent;
            this.lbCategoryName.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoryName.Location = new System.Drawing.Point(13, 46);
            this.lbCategoryName.Name = "lbCategoryName";
            this.lbCategoryName.Size = new System.Drawing.Size(155, 23);
            this.lbCategoryName.TabIndex = 3;
            this.lbCategoryName.Text = "Category Name";
            this.lbCategoryName.Click += new System.EventHandler(this.lbCategoryName_Click);
            // 
            // tbCategoryName
            // 
            this.tbCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbCategoryName.Location = new System.Drawing.Point(187, 46);
            this.tbCategoryName.Name = "tbCategoryName";
            this.tbCategoryName.Size = new System.Drawing.Size(151, 24);
            this.tbCategoryName.TabIndex = 0;
            // 
            // lvProductList
            // 
            this.lvProductList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvProductList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvProductList.FullRowSelect = true;
            this.lvProductList.GridLines = true;
            this.lvProductList.HideSelection = false;
            this.lvProductList.Location = new System.Drawing.Point(39, 440);
            this.lvProductList.Name = "lvProductList";
            this.lvProductList.Size = new System.Drawing.Size(469, 144);
            this.lvProductList.TabIndex = 10;
            this.lvProductList.UseCompatibleStateImageBehavior = false;
            this.lvProductList.View = System.Windows.Forms.View.Details;
            this.lvProductList.SelectedIndexChanged += new System.EventHandler(this.lvProductList_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ProductID";
            this.columnHeader6.Width = 86;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "CategoryID";
            this.columnHeader7.Width = 95;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ProductName";
            this.columnHeader8.Width = 146;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Price";
            this.columnHeader9.Width = 137;
            // 
            // rbProduct
            // 
            this.rbProduct.AutoSize = true;
            this.rbProduct.BackColor = System.Drawing.Color.Transparent;
            this.rbProduct.Font = new System.Drawing.Font("MV Boli", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProduct.Location = new System.Drawing.Point(714, 82);
            this.rbProduct.Name = "rbProduct";
            this.rbProduct.Size = new System.Drawing.Size(126, 33);
            this.rbProduct.TabIndex = 11;
            this.rbProduct.TabStop = true;
            this.rbProduct.Text = "Product";
            this.rbProduct.UseVisualStyleBackColor = false;
            this.rbProduct.CheckedChanged += new System.EventHandler(this.rbProduct_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(237, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(603, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "If you want to access the products select the button";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(510, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(262, 37);
            this.label6.TabIndex = 12;
            this.label6.Text = "Category Options";
            this.label6.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(262, 37);
            this.label7.TabIndex = 12;
            this.label7.Text = "Products Options";
            this.label7.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnTurnBack
            // 
            this.btnTurnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnTurnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTurnBack.BackgroundImage")));
            this.btnTurnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTurnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTurnBack.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurnBack.Location = new System.Drawing.Point(858, 597);
            this.btnTurnBack.Name = "btnTurnBack";
            this.btnTurnBack.Size = new System.Drawing.Size(72, 60);
            this.btnTurnBack.TabIndex = 9;
            this.btnTurnBack.UseVisualStyleBackColor = false;
            this.btnTurnBack.Click += new System.EventHandler(this.btnTurnBack_Click);
            // 
            // FormKitchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = global::Restaurant.Properties.Resources.pngegg__1_;
            this.ClientSize = new System.Drawing.Size(946, 699);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbProduct);
            this.Controls.Add(this.lvProductList);
            this.Controls.Add(this.btnTurnBack);
            this.Controls.Add(this.pnlCategory);
            this.Controls.Add(this.pnlProduct);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvCategory);
            this.Name = "FormKitchen";
            this.Text = "FormKitchen";
            this.Load += new System.EventHandler(this.FormKitchen_Load);
            this.pnlProduct.ResumeLayout(false);
            this.pnlProduct.PerformLayout();
            this.pnlCategory.ResumeLayout(false);
            this.pnlCategory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvCategory;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Panel pnlProduct;
        private System.Windows.Forms.TextBox tbProductPrice;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProductCategory;
        private System.Windows.Forms.Panel pnlCategory;
        private System.Windows.Forms.Label lbCategoryName;
        private System.Windows.Forms.TextBox tbCategoryName;
        private System.Windows.Forms.TextBox tbProductID;
        private System.Windows.Forms.TextBox tbCategoryID;
        private System.Windows.Forms.Button btnTurnBack;
        private System.Windows.Forms.ListView lvProductList;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.RadioButton rbProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCategoryID2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}