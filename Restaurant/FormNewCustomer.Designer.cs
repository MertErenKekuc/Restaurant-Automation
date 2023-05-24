namespace Restaurant
{
    partial class FormNewCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewCustomer));
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbSurName = new System.Windows.Forms.Label();
            this.tbSurName = new System.Windows.Forms.TextBox();
            this.tbCustomerNo = new System.Windows.Forms.TextBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.tbTelephone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnTurnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbName.Location = new System.Drawing.Point(314, 90);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(256, 29);
            this.tbName.TabIndex = 0;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.Black;
            this.lbName.Location = new System.Drawing.Point(207, 79);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(101, 40);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Name";
            // 
            // lbSurName
            // 
            this.lbSurName.AutoSize = true;
            this.lbSurName.BackColor = System.Drawing.Color.Transparent;
            this.lbSurName.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSurName.Location = new System.Drawing.Point(143, 171);
            this.lbSurName.Name = "lbSurName";
            this.lbSurName.Size = new System.Drawing.Size(165, 40);
            this.lbSurName.TabIndex = 3;
            this.lbSurName.Text = "Telephone";
            // 
            // tbSurName
            // 
            this.tbSurName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSurName.Location = new System.Drawing.Point(314, 135);
            this.tbSurName.Multiline = true;
            this.tbSurName.Name = "tbSurName";
            this.tbSurName.Size = new System.Drawing.Size(256, 29);
            this.tbSurName.TabIndex = 0;
            // 
            // tbCustomerNo
            // 
            this.tbCustomerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbCustomerNo.Location = new System.Drawing.Point(576, 90);
            this.tbCustomerNo.Name = "tbCustomerNo";
            this.tbCustomerNo.Size = new System.Drawing.Size(14, 27);
            this.tbCustomerNo.TabIndex = 10;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.Green;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddCustomer.Location = new System.Drawing.Point(324, 263);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(105, 67);
            this.btnAddCustomer.TabIndex = 11;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // tbTelephone
            // 
            this.tbTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbTelephone.Location = new System.Drawing.Point(314, 182);
            this.tbTelephone.Multiline = true;
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(256, 29);
            this.tbTelephone.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Surname";
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.BackColor = System.Drawing.Color.Teal;
            this.btnUpdateCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateCustomer.Location = new System.Drawing.Point(446, 263);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(115, 69);
            this.btnUpdateCustomer.TabIndex = 13;
            this.btnUpdateCustomer.Text = "Update Customer Info";
            this.btnUpdateCustomer.UseVisualStyleBackColor = false;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnTurnBack
            // 
            this.btnTurnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnTurnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTurnBack.BackgroundImage")));
            this.btnTurnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTurnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTurnBack.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurnBack.Location = new System.Drawing.Point(626, 312);
            this.btnTurnBack.Name = "btnTurnBack";
            this.btnTurnBack.Size = new System.Drawing.Size(72, 60);
            this.btnTurnBack.TabIndex = 9;
            this.btnTurnBack.UseVisualStyleBackColor = false;
            this.btnTurnBack.Click += new System.EventHandler(this.btnTurnBack_Click);
            // 
            // FormNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = global::Restaurant.Properties.Resources.pngegg__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(816, 470);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.tbCustomerNo);
            this.Controls.Add(this.btnTurnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSurName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbTelephone);
            this.Controls.Add(this.tbSurName);
            this.Controls.Add(this.tbName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "FormNewCustomer";
            this.Text = "FormNewCustomer";
            this.Load += new System.EventHandler(this.FormNewCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbSurName;
        private System.Windows.Forms.TextBox tbSurName;
        private System.Windows.Forms.Button btnTurnBack;
        private System.Windows.Forms.TextBox tbCustomerNo;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.TextBox tbTelephone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateCustomer;
    }
}