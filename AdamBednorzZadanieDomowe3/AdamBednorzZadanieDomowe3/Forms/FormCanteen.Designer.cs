namespace AdamBednorzZadanieDomowe3.Forms
{
    partial class FormCanteen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCanteen));
            this.dataGridViewCanteen = new System.Windows.Forms.DataGridView();
            this.buttonCanteen = new System.Windows.Forms.Button();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.labelMenu = new System.Windows.Forms.Label();
            this.labelOrder = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelDish = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxDish = new System.Windows.Forms.TextBox();
            this.buttonOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCanteen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCanteen
            // 
            this.dataGridViewCanteen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCanteen.Location = new System.Drawing.Point(28, 138);
            this.dataGridViewCanteen.Name = "dataGridViewCanteen";
            this.dataGridViewCanteen.Size = new System.Drawing.Size(240, 212);
            this.dataGridViewCanteen.TabIndex = 0;
            // 
            // buttonCanteen
            // 
            this.buttonCanteen.Location = new System.Drawing.Point(95, 368);
            this.buttonCanteen.Name = "buttonCanteen";
            this.buttonCanteen.Size = new System.Drawing.Size(86, 44);
            this.buttonCanteen.TabIndex = 1;
            this.buttonCanteen.Text = "Pokaż menu";
            this.buttonCanteen.UseVisualStyleBackColor = true;
            this.buttonCanteen.Click += new System.EventHandler(this.buttonCanteen_Click);
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(643, 138);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.Size = new System.Drawing.Size(240, 212);
            this.dataGridViewOrders.TabIndex = 2;
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMenu.Location = new System.Drawing.Point(108, 106);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(73, 29);
            this.labelMenu.TabIndex = 3;
            this.labelMenu.Text = "Menu";
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOrder.Location = new System.Drawing.Point(700, 96);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(144, 29);
            this.labelOrder.TabIndex = 4;
            this.labelOrder.Text = "Zamówienia";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFirstName.Location = new System.Drawing.Point(640, 368);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(45, 24);
            this.labelFirstName.TabIndex = 5;
            this.labelFirstName.Text = "Imię";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLastName.Location = new System.Drawing.Point(595, 405);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(90, 24);
            this.labelLastName.TabIndex = 6;
            this.labelLastName.Text = "Nazwisko";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPassword.Location = new System.Drawing.Point(623, 447);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(62, 24);
            this.labelPassword.TabIndex = 7;
            this.labelPassword.Text = "Hasło";
            // 
            // labelDish
            // 
            this.labelDish.AutoSize = true;
            this.labelDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDish.Location = new System.Drawing.Point(623, 484);
            this.labelDish.Name = "labelDish";
            this.labelDish.Size = new System.Drawing.Size(59, 24);
            this.labelDish.TabIndex = 8;
            this.labelDish.Text = "Danie";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(705, 371);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 9;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(705, 405);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 10;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(705, 450);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 11;
            // 
            // textBoxDish
            // 
            this.textBoxDish.Location = new System.Drawing.Point(705, 487);
            this.textBoxDish.Name = "textBoxDish";
            this.textBoxDish.Size = new System.Drawing.Size(100, 20);
            this.textBoxDish.TabIndex = 12;
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(870, 368);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(75, 50);
            this.buttonOrder.TabIndex = 13;
            this.buttonOrder.Text = "Zamów danie";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // Canteen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1005, 542);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.textBoxDish);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelDish);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelOrder);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.dataGridViewOrders);
            this.Controls.Add(this.buttonCanteen);
            this.Controls.Add(this.dataGridViewCanteen);
            this.Name = "Canteen";
            this.Text = "Canteen";
            this.Load += new System.EventHandler(this.Canteen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCanteen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCanteen;
        private System.Windows.Forms.Button buttonCanteen;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelDish;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxDish;
        private System.Windows.Forms.Button buttonOrder;
    }
}