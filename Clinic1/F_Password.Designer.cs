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
            this.LblID = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.CmbWorker = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.BtnLogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblID.ForeColor = System.Drawing.Color.Snow;
            this.LblID.Location = new System.Drawing.Point(321, 141);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(96, 24);
            this.LblID.TabIndex = 12;
            this.LblID.Text = ":שם עובד";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.ForeColor = System.Drawing.Color.Snow;
            this.LblPassword.Location = new System.Drawing.Point(330, 198);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(85, 24);
            this.LblPassword.TabIndex = 13;
            this.LblPassword.Text = ":סיסמה";
            // 
            // CmbWorker
            // 
            this.CmbWorker.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.CmbWorker.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.CmbWorker.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmbWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbWorker.FormattingEnabled = true;
            this.CmbWorker.Location = new System.Drawing.Point(131, 137);
            this.CmbWorker.Name = "CmbWorker";
            this.CmbWorker.Size = new System.Drawing.Size(156, 33);
            this.CmbWorker.TabIndex = 14;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(131, 193);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(155, 31);
            this.txtPassword.TabIndex = 15;
            this.txtPassword.Text = "1";
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // BtnLogIn
            // 
            this.BtnLogIn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogIn.ForeColor = System.Drawing.Color.Black;
            this.BtnLogIn.Location = new System.Drawing.Point(173, 303);
            this.BtnLogIn.Name = "BtnLogIn";
            this.BtnLogIn.Size = new System.Drawing.Size(143, 40);
            this.BtnLogIn.TabIndex = 26;
            this.BtnLogIn.Text = "כניסה למערכת";
            this.BtnLogIn.UseVisualStyleBackColor = false;
            this.BtnLogIn.Click += new System.EventHandler(this.BtnLogIn_Click);
            // 
            // F_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(509, 370);
            this.Controls.Add(this.BtnLogIn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.CmbWorker);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblID);
            this.Name = "F_Password";
            this.Text = "F_Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.ComboBox CmbWorker;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button BtnLogIn;
    }
}