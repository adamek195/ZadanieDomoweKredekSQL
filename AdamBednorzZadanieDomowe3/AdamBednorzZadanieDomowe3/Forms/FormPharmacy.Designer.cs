namespace AdamBednorzZadanieDomowe3.Forms
{
    partial class FormPharmacy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPharmacy));
            this.dataGridViewPharmacies = new System.Windows.Forms.DataGridView();
            this.buttonPharmacy = new System.Windows.Forms.Button();
            this.dataGridViewPurchases = new System.Windows.Forms.DataGridView();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelMedicine = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxMedicine = new System.Windows.Forms.TextBox();
            this.buttonPurchaseMedicine = new System.Windows.Forms.Button();
            this.labelPharmacies = new System.Windows.Forms.Label();
            this.labelPurchases = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPharmacies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchases)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPharmacies
            // 
            this.dataGridViewPharmacies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPharmacies.Location = new System.Drawing.Point(45, 125);
            this.dataGridViewPharmacies.Name = "dataGridViewPharmacies";
            this.dataGridViewPharmacies.Size = new System.Drawing.Size(240, 206);
            this.dataGridViewPharmacies.TabIndex = 0;
            // 
            // buttonPharmacy
            // 
            this.buttonPharmacy.Location = new System.Drawing.Point(71, 391);
            this.buttonPharmacy.Name = "buttonPharmacy";
            this.buttonPharmacy.Size = new System.Drawing.Size(103, 44);
            this.buttonPharmacy.TabIndex = 1;
            this.buttonPharmacy.Text = "Zobacz lekarstwa";
            this.buttonPharmacy.UseVisualStyleBackColor = true;
            this.buttonPharmacy.Click += new System.EventHandler(this.buttonPharmacy_Click);
            // 
            // dataGridViewPurchases
            // 
            this.dataGridViewPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPurchases.Location = new System.Drawing.Point(540, 125);
            this.dataGridViewPurchases.Name = "dataGridViewPurchases";
            this.dataGridViewPurchases.Size = new System.Drawing.Size(263, 206);
            this.dataGridViewPurchases.TabIndex = 2;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFirstName.Location = new System.Drawing.Point(534, 377);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(45, 24);
            this.labelFirstName.TabIndex = 3;
            this.labelFirstName.Text = "Imię";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLastName.Location = new System.Drawing.Point(489, 416);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(90, 24);
            this.labelLastName.TabIndex = 4;
            this.labelLastName.Text = "Nazwisko";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPassword.Location = new System.Drawing.Point(517, 453);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(62, 24);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Hasło";
            // 
            // labelMedicine
            // 
            this.labelMedicine.AutoSize = true;
            this.labelMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMedicine.Location = new System.Drawing.Point(489, 489);
            this.labelMedicine.Name = "labelMedicine";
            this.labelMedicine.Size = new System.Drawing.Size(94, 24);
            this.labelMedicine.TabIndex = 6;
            this.labelMedicine.Text = "Lekarstwo";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(599, 381);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 7;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(599, 419);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 8;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(599, 456);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 9;
            // 
            // textBoxMedicine
            // 
            this.textBoxMedicine.Location = new System.Drawing.Point(599, 489);
            this.textBoxMedicine.Name = "textBoxMedicine";
            this.textBoxMedicine.Size = new System.Drawing.Size(100, 20);
            this.textBoxMedicine.TabIndex = 10;
            // 
            // buttonPurchaseMedicine
            // 
            this.buttonPurchaseMedicine.Location = new System.Drawing.Point(728, 377);
            this.buttonPurchaseMedicine.Name = "buttonPurchaseMedicine";
            this.buttonPurchaseMedicine.Size = new System.Drawing.Size(75, 46);
            this.buttonPurchaseMedicine.TabIndex = 11;
            this.buttonPurchaseMedicine.Text = "Zamów lekarstwo";
            this.buttonPurchaseMedicine.UseVisualStyleBackColor = true;
            this.buttonPurchaseMedicine.Click += new System.EventHandler(this.buttonPurchaseMedicine_Click);
            // 
            // labelPharmacies
            // 
            this.labelPharmacies.AutoSize = true;
            this.labelPharmacies.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPharmacies.Location = new System.Drawing.Point(107, 81);
            this.labelPharmacies.Name = "labelPharmacies";
            this.labelPharmacies.Size = new System.Drawing.Size(122, 29);
            this.labelPharmacies.TabIndex = 12;
            this.labelPharmacies.Text = "Lekarstwa";
            // 
            // labelPurchases
            // 
            this.labelPurchases.AutoSize = true;
            this.labelPurchases.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPurchases.Location = new System.Drawing.Point(615, 81);
            this.labelPurchases.Name = "labelPurchases";
            this.labelPurchases.Size = new System.Drawing.Size(144, 29);
            this.labelPurchases.TabIndex = 13;
            this.labelPurchases.Text = "Zamówienia";
            // 
            // Pharmacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(838, 666);
            this.Controls.Add(this.labelPurchases);
            this.Controls.Add(this.labelPharmacies);
            this.Controls.Add(this.buttonPurchaseMedicine);
            this.Controls.Add(this.textBoxMedicine);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelMedicine);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.dataGridViewPurchases);
            this.Controls.Add(this.buttonPharmacy);
            this.Controls.Add(this.dataGridViewPharmacies);
            this.Name = "Pharmacy";
            this.Text = "Pharmacy";
            this.Load += new System.EventHandler(this.Pharmacy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPharmacies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPharmacies;
        private System.Windows.Forms.Button buttonPharmacy;
        private System.Windows.Forms.DataGridView dataGridViewPurchases;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelMedicine;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxMedicine;
        private System.Windows.Forms.Button buttonPurchaseMedicine;
        private System.Windows.Forms.Label labelPharmacies;
        private System.Windows.Forms.Label labelPurchases;
    }
}