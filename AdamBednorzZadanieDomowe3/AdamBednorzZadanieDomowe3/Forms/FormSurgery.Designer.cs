namespace AdamBednorzZadanieDomowe3.Forms
{
    partial class FormSurgery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSurgery));
            this.dataGridViewDoctors = new System.Windows.Forms.DataGridView();
            this.buttonDoctors = new System.Windows.Forms.Button();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelTypeDoctor = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxTypeDoctor = new System.Windows.Forms.TextBox();
            this.dataGridViewVisits = new System.Windows.Forms.DataGridView();
            this.buttonVisits = new System.Windows.Forms.Button();
            this.labelDoctors = new System.Windows.Forms.Label();
            this.labelVisits = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisits)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDoctors
            // 
            this.dataGridViewDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctors.Location = new System.Drawing.Point(12, 41);
            this.dataGridViewDoctors.Name = "dataGridViewDoctors";
            this.dataGridViewDoctors.Size = new System.Drawing.Size(325, 178);
            this.dataGridViewDoctors.TabIndex = 0;
            // 
            // buttonDoctors
            // 
            this.buttonDoctors.Location = new System.Drawing.Point(12, 225);
            this.buttonDoctors.Name = "buttonDoctors";
            this.buttonDoctors.Size = new System.Drawing.Size(109, 49);
            this.buttonDoctors.TabIndex = 1;
            this.buttonDoctors.Text = "Pokaż dostępność lekarzy";
            this.buttonDoctors.UseVisualStyleBackColor = true;
            this.buttonDoctors.Click += new System.EventHandler(this.buttonDoctors_Click);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFirstName.Location = new System.Drawing.Point(593, 218);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(39, 20);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "Imię";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLastName.Location = new System.Drawing.Point(556, 249);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(76, 20);
            this.labelLastName.TabIndex = 3;
            this.labelLastName.Text = "Nazwisko";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPassword.Location = new System.Drawing.Point(581, 274);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(51, 20);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Hasło";
            // 
            // labelTypeDoctor
            // 
            this.labelTypeDoctor.AutoSize = true;
            this.labelTypeDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTypeDoctor.Location = new System.Drawing.Point(474, 310);
            this.labelTypeDoctor.Name = "labelTypeDoctor";
            this.labelTypeDoctor.Size = new System.Drawing.Size(158, 20);
            this.labelTypeDoctor.TabIndex = 5;
            this.labelTypeDoctor.Text = "Specjalność lekarska";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(659, 218);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 6;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(659, 249);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 7;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(659, 276);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 8;
            // 
            // textBoxTypeDoctor
            // 
            this.textBoxTypeDoctor.Location = new System.Drawing.Point(659, 310);
            this.textBoxTypeDoctor.Name = "textBoxTypeDoctor";
            this.textBoxTypeDoctor.Size = new System.Drawing.Size(100, 20);
            this.textBoxTypeDoctor.TabIndex = 9;
            // 
            // dataGridViewVisits
            // 
            this.dataGridViewVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVisits.Location = new System.Drawing.Point(585, 46);
            this.dataGridViewVisits.Name = "dataGridViewVisits";
            this.dataGridViewVisits.Size = new System.Drawing.Size(353, 169);
            this.dataGridViewVisits.TabIndex = 10;
            // 
            // buttonVisits
            // 
            this.buttonVisits.Location = new System.Drawing.Point(795, 236);
            this.buttonVisits.Name = "buttonVisits";
            this.buttonVisits.Size = new System.Drawing.Size(95, 60);
            this.buttonVisits.TabIndex = 11;
            this.buttonVisits.Text = "Umów się na wizytę";
            this.buttonVisits.UseVisualStyleBackColor = true;
            this.buttonVisits.Click += new System.EventHandler(this.buttonVisits_Click);
            // 
            // labelDoctors
            // 
            this.labelDoctors.AutoSize = true;
            this.labelDoctors.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDoctors.Location = new System.Drawing.Point(12, 9);
            this.labelDoctors.Name = "labelDoctors";
            this.labelDoctors.Size = new System.Drawing.Size(222, 29);
            this.labelDoctors.TabIndex = 12;
            this.labelDoctors.Text = "Dostępność lekarzy";
            // 
            // labelVisits
            // 
            this.labelVisits.AutoSize = true;
            this.labelVisits.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVisits.Location = new System.Drawing.Point(585, 9);
            this.labelVisits.Name = "labelVisits";
            this.labelVisits.Size = new System.Drawing.Size(198, 29);
            this.labelVisits.TabIndex = 13;
            this.labelVisits.Text = "Umówione wizyty";
            // 
            // Surgery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1010, 350);
            this.Controls.Add(this.labelVisits);
            this.Controls.Add(this.labelDoctors);
            this.Controls.Add(this.buttonVisits);
            this.Controls.Add(this.dataGridViewVisits);
            this.Controls.Add(this.textBoxTypeDoctor);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelTypeDoctor);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.buttonDoctors);
            this.Controls.Add(this.dataGridViewDoctors);
            this.Name = "Surgery";
            this.Text = "Surgery";
            this.Load += new System.EventHandler(this.Surgery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDoctors;
        private System.Windows.Forms.Button buttonDoctors;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelTypeDoctor;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxTypeDoctor;
        private System.Windows.Forms.DataGridView dataGridViewVisits;
        private System.Windows.Forms.Button buttonVisits;
        private System.Windows.Forms.Label labelDoctors;
        private System.Windows.Forms.Label labelVisits;
    }
}