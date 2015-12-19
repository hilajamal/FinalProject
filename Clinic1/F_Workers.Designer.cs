namespace Clinic1
{
    partial class F_Workers
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
            this.DgWorkers = new System.Windows.Forms.DataGridView();
            this.BtnAddNewWorker = new System.Windows.Forms.Button();
            this.LblID = new System.Windows.Forms.Label();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.LblLastName = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.BtnExitNoSave = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnPermissions = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgWorkers)).BeginInit();
            this.SuspendLayout();
            // 
            // DgWorkers
            // 
            this.DgWorkers.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DgWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgWorkers.Location = new System.Drawing.Point(224, 27);
            this.DgWorkers.MultiSelect = false;
            this.DgWorkers.Name = "DgWorkers";
            this.DgWorkers.ReadOnly = true;
            this.DgWorkers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DgWorkers.Size = new System.Drawing.Size(502, 423);
            this.DgWorkers.TabIndex = 0;
            // 
            // BtnAddNewWorker
            // 
            this.BtnAddNewWorker.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnAddNewWorker.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddNewWorker.Location = new System.Drawing.Point(505, 487);
            this.BtnAddNewWorker.Name = "BtnAddNewWorker";
            this.BtnAddNewWorker.Size = new System.Drawing.Size(129, 63);
            this.BtnAddNewWorker.TabIndex = 1;
            this.BtnAddNewWorker.Text = "הוספת עובד חדש";
            this.BtnAddNewWorker.UseVisualStyleBackColor = false;
            this.BtnAddNewWorker.Click += new System.EventHandler(this.BtnAddNewWorker_Click);
            // 
            // LblID
            // 
            this.LblID.BackColor = System.Drawing.Color.White;
            this.LblID.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblID.Location = new System.Drawing.Point(522, 132);
            this.LblID.Name = "LblID";
            this.LblID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblID.Size = new System.Drawing.Size(100, 23);
            this.LblID.TabIndex = 2;
            this.LblID.Text = "תעודת זהות";
            this.LblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblFirstName
            // 
            this.LblFirstName.BackColor = System.Drawing.Color.White;
            this.LblFirstName.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFirstName.Location = new System.Drawing.Point(522, 181);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblFirstName.Size = new System.Drawing.Size(100, 23);
            this.LblFirstName.TabIndex = 3;
            this.LblFirstName.Text = "שם פרטי";
            this.LblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblLastName
            // 
            this.LblLastName.BackColor = System.Drawing.Color.White;
            this.LblLastName.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLastName.Location = new System.Drawing.Point(522, 226);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblLastName.Size = new System.Drawing.Size(100, 22);
            this.LblLastName.TabIndex = 4;
            this.LblLastName.Text = "שם משפחה";
            this.LblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPassword
            // 
            this.LblPassword.BackColor = System.Drawing.Color.White;
            this.LblPassword.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(520, 273);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblPassword.Size = new System.Drawing.Size(104, 24);
            this.LblPassword.TabIndex = 5;
            this.LblPassword.Text = "סיסמה";
            this.LblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtID
            // 
            this.TxtID.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtID.Location = new System.Drawing.Point(359, 133);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(100, 23);
            this.TxtID.TabIndex = 6;
            this.TxtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFirstName.Location = new System.Drawing.Point(359, 181);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(100, 23);
            this.TxtFirstName.TabIndex = 7;
            this.TxtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLastName.Location = new System.Drawing.Point(359, 228);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(100, 23);
            this.TxtLastName.TabIndex = 8;
            this.TxtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(359, 273);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(100, 23);
            this.TxtPassword.TabIndex = 9;
            this.TxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPassword.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // BtnExitNoSave
            // 
            this.BtnExitNoSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnExitNoSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExitNoSave.ForeColor = System.Drawing.Color.Black;
            this.BtnExitNoSave.Location = new System.Drawing.Point(194, 496);
            this.BtnExitNoSave.Name = "BtnExitNoSave";
            this.BtnExitNoSave.Size = new System.Drawing.Size(152, 40);
            this.BtnExitNoSave.TabIndex = 26;
            this.BtnExitNoSave.Text = "יציאה ללא שמירה";
            this.BtnExitNoSave.UseVisualStyleBackColor = false;
            this.BtnExitNoSave.Visible = false;
            this.BtnExitNoSave.Click += new System.EventHandler(this.BtnExitNoSave_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.Black;
            this.BtnSave.Location = new System.Drawing.Point(610, 496);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(143, 40);
            this.BtnSave.TabIndex = 25;
            this.BtnSave.Text = "שמירה";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Visible = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnPermissions
            // 
            this.BtnPermissions.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnPermissions.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPermissions.Location = new System.Drawing.Point(339, 487);
            this.BtnPermissions.Name = "BtnPermissions";
            this.BtnPermissions.Size = new System.Drawing.Size(129, 63);
            this.BtnPermissions.TabIndex = 27;
            this.BtnPermissions.Text = "ניהול הרשאות";
            this.BtnPermissions.UseVisualStyleBackColor = false;
            // 
            // F_Workers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(931, 574);
            this.Controls.Add(this.BtnPermissions);
            this.Controls.Add(this.BtnExitNoSave);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnAddNewWorker);
            this.Controls.Add(this.DgWorkers);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblLastName);
            this.Controls.Add(this.LblFirstName);
            this.Controls.Add(this.LblID);
            this.Name = "F_Workers";
            this.Text = "F_Workers";
            ((System.ComponentModel.ISupportInitialize)(this.DgWorkers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgWorkers;
        private System.Windows.Forms.Button BtnAddNewWorker;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label LblFirstName;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button BtnExitNoSave;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnPermissions;
    }
}