namespace Clinic1
{
    partial class F_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Password));
            this.LblID = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.CmbWorker = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.BtnLogIn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnShowPassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.BackColor = System.Drawing.Color.Transparent;
            this.LblID.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblID.Location = new System.Drawing.Point(259, 72);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(96, 24);
            this.LblID.TabIndex = 12;
            this.LblID.Text = ":שם עובד";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.BackColor = System.Drawing.Color.Transparent;
            this.LblPassword.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblPassword.Location = new System.Drawing.Point(268, 118);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(85, 24);
            this.LblPassword.TabIndex = 13;
            this.LblPassword.Text = ":סיסמה";
            // 
            // CmbWorker
            // 
            this.CmbWorker.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.CmbWorker.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.CmbWorker.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CmbWorker.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmbWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbWorker.ForeColor = System.Drawing.Color.Black;
            this.CmbWorker.FormattingEnabled = true;
            this.CmbWorker.Location = new System.Drawing.Point(95, 68);
            this.CmbWorker.Name = "CmbWorker";
            this.CmbWorker.Size = new System.Drawing.Size(156, 33);
            this.CmbWorker.TabIndex = 14;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(95, 113);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(155, 31);
            this.txtPassword.TabIndex = 15;
            this.txtPassword.Text = "1";
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // BtnLogIn
            // 
            this.BtnLogIn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnLogIn.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogIn.ForeColor = System.Drawing.Color.Black;
            this.BtnLogIn.Location = new System.Drawing.Point(180, 252);
            this.BtnLogIn.Name = "BtnLogIn";
            this.BtnLogIn.Size = new System.Drawing.Size(155, 57);
            this.BtnLogIn.TabIndex = 26;
            this.BtnLogIn.Text = "כניסה למערכת";
            this.BtnLogIn.UseVisualStyleBackColor = false;
            this.BtnLogIn.Click += new System.EventHandler(this.BtnLogIn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(371, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 128);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // BtnShowPassword
            // 
            this.BtnShowPassword.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnShowPassword.Font = new System.Drawing.Font("David", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowPassword.Location = new System.Drawing.Point(131, 150);
            this.BtnShowPassword.Name = "BtnShowPassword";
            this.BtnShowPassword.Size = new System.Drawing.Size(84, 33);
            this.BtnShowPassword.TabIndex = 28;
            this.BtnShowPassword.Text = "הצג סיסמה";
            this.BtnShowPassword.UseVisualStyleBackColor = false;
            this.BtnShowPassword.Click += new System.EventHandler(this.BtnShowPassword_Click);
            // 
            // F_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(568, 358);
            this.Controls.Add(this.BtnShowPassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnLogIn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.CmbWorker);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblID);
            this.Name = "F_Password";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.F_Password_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.ComboBox CmbWorker;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button BtnLogIn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnShowPassword;
    }
}