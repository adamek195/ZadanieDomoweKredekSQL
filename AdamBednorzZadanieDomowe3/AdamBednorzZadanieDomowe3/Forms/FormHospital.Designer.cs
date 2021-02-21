namespace AdamBednorzZadanieDomowe3
{
    partial class Hospital
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hospital));
            this.labelReception = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.buttonAddPatient = new System.Windows.Forms.Button();
            this.buttonDeletePatient = new System.Windows.Forms.Button();
            this.buttonSetPassword = new System.Windows.Forms.Button();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.pictureBoxPharmacy = new System.Windows.Forms.PictureBox();
            this.buttonPharmacy = new System.Windows.Forms.Button();
            this.pictureBoxCanteen = new System.Windows.Forms.PictureBox();
            this.buttonCanteen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPharmacy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanteen)).BeginInit();
            this.SuspendLayout();
            // 
            // labelReception
            // 
            this.labelReception.AutoSize = true;
            this.labelReception.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelReception.Location = new System.Drawing.Point(717, 40);
            this.labelReception.Name = "labelReception";
            this.labelReception.Size = new System.Drawing.Size(173, 39);
            this.labelReception.TabIndex = 0;
            this.labelReception.Text = "Reception";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFirstName.Location = new System.Drawing.Point(608, 230);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(39, 20);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "Imię";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(675, 230);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(111, 20);
            this.textBoxFirstName.TabIndex = 2;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(675, 263);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(111, 20);
            this.textBoxLastName.TabIndex = 3;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLastName.Location = new System.Drawing.Point(571, 261);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(76, 20);
            this.labelLastName.TabIndex = 4;
            this.labelLastName.Text = "Nazwisko";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPassword.Location = new System.Drawing.Point(596, 292);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(51, 20);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Hasło";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(675, 294);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(111, 20);
            this.textBoxPassword.TabIndex = 6;
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.Location = new System.Drawing.Point(539, 361);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(108, 43);
            this.buttonSignIn.TabIndex = 8;
            this.buttonSignIn.Text = "Zaloguj się";
            this.buttonSignIn.UseVisualStyleBackColor = true;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // buttonAddPatient
            // 
            this.buttonAddPatient.Location = new System.Drawing.Point(659, 361);
            this.buttonAddPatient.Name = "buttonAddPatient";
            this.buttonAddPatient.Size = new System.Drawing.Size(75, 42);
            this.buttonAddPatient.TabIndex = 9;
            this.buttonAddPatient.Text = "Utwórz konto";
            this.buttonAddPatient.UseVisualStyleBackColor = true;
            this.buttonAddPatient.Click += new System.EventHandler(this.buttonAddPatient_Click);
            // 
            // buttonDeletePatient
            // 
            this.buttonDeletePatient.Location = new System.Drawing.Point(741, 361);
            this.buttonDeletePatient.Name = "buttonDeletePatient";
            this.buttonDeletePatient.Size = new System.Drawing.Size(75, 42);
            this.buttonDeletePatient.TabIndex = 10;
            this.buttonDeletePatient.Text = "Usuń konto";
            this.buttonDeletePatient.UseVisualStyleBackColor = true;
            this.buttonDeletePatient.Click += new System.EventHandler(this.buttonDeletePatient_Click);
            // 
            // buttonSetPassword
            // 
            this.buttonSetPassword.Location = new System.Drawing.Point(832, 361);
            this.buttonSetPassword.Name = "buttonSetPassword";
            this.buttonSetPassword.Size = new System.Drawing.Size(84, 42);
            this.buttonSetPassword.TabIndex = 11;
            this.buttonSetPassword.Text = "Zmień hasło";
            this.buttonSetPassword.UseVisualStyleBackColor = true;
            this.buttonSetPassword.Click += new System.EventHandler(this.buttonSetPassword_Click);
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNewPassword.Location = new System.Drawing.Point(555, 322);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(92, 20);
            this.labelNewPassword.TabIndex = 12;
            this.labelNewPassword.Text = "Nowe hasło";
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(675, 321);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.PasswordChar = '*';
            this.textBoxNewPassword.Size = new System.Drawing.Size(111, 20);
            this.textBoxNewPassword.TabIndex = 13;
            // 
            // pictureBoxPharmacy
            // 
            this.pictureBoxPharmacy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxPharmacy.BackgroundImage")));
            this.pictureBoxPharmacy.Location = new System.Drawing.Point(76, 1);
            this.pictureBoxPharmacy.Name = "pictureBoxPharmacy";
            this.pictureBoxPharmacy.Size = new System.Drawing.Size(201, 159);
            this.pictureBoxPharmacy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxPharmacy.TabIndex = 14;
            this.pictureBoxPharmacy.TabStop = false;
            // 
            // buttonPharmacy
            // 
            this.buttonPharmacy.Location = new System.Drawing.Point(95, 166);
            this.buttonPharmacy.Name = "buttonPharmacy";
            this.buttonPharmacy.Size = new System.Drawing.Size(140, 47);
            this.buttonPharmacy.TabIndex = 15;
            this.buttonPharmacy.Text = "Idź do apteki szpitalnej";
            this.buttonPharmacy.UseVisualStyleBackColor = true;
            this.buttonPharmacy.Click += new System.EventHandler(this.buttonPharmacy_Click);
            // 
            // pictureBoxCanteen
            // 
            this.pictureBoxCanteen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCanteen.BackgroundImage")));
            this.pictureBoxCanteen.Location = new System.Drawing.Point(63, 241);
            this.pictureBoxCanteen.Name = "pictureBoxCanteen";
            this.pictureBoxCanteen.Size = new System.Drawing.Size(214, 131);
            this.pictureBoxCanteen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxCanteen.TabIndex = 16;
            this.pictureBoxCanteen.TabStop = false;
            // 
            // buttonCanteen
            // 
            this.buttonCanteen.Location = new System.Drawing.Point(95, 380);
            this.buttonCanteen.Name = "buttonCanteen";
            this.buttonCanteen.Size = new System.Drawing.Size(140, 23);
            this.buttonCanteen.TabIndex = 17;
            this.buttonCanteen.Text = "Idź do kantyny";
            this.buttonCanteen.UseVisualStyleBackColor = true;
            this.buttonCanteen.Click += new System.EventHandler(this.buttonCanteen_Click);
            // 
            // Hospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(976, 416);
            this.Controls.Add(this.buttonCanteen);
            this.Controls.Add(this.pictureBoxCanteen);
            this.Controls.Add(this.buttonPharmacy);
            this.Controls.Add(this.pictureBoxPharmacy);
            this.Controls.Add(this.textBoxNewPassword);
            this.Controls.Add(this.labelNewPassword);
            this.Controls.Add(this.buttonSetPassword);
            this.Controls.Add(this.buttonDeletePatient);
            this.Controls.Add(this.buttonAddPatient);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelReception);
            this.Name = "Hospital";
            this.Text = "Hospital";
            this.Load += new System.EventHandler(this.Hospital_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPharmacy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanteen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelReception;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.Button buttonAddPatient;
        private System.Windows.Forms.Button buttonDeletePatient;
        private System.Windows.Forms.Button buttonSetPassword;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.PictureBox pictureBoxPharmacy;
        private System.Windows.Forms.Button buttonPharmacy;
        private System.Windows.Forms.PictureBox pictureBoxCanteen;
        private System.Windows.Forms.Button buttonCanteen;
    }
}

