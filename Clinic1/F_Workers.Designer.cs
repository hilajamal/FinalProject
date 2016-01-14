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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnEditWorkers = new System.Windows.Forms.Button();
            this.btnSaveEditing = new System.Windows.Forms.Button();
            this.BtnExitNoSaveEditting = new System.Windows.Forms.Button();
            this.LblPermission = new System.Windows.Forms.Label();
            this.CmbPermissions = new System.Windows.Forms.ComboBox();
            this.BtnExitNoSavePermissions = new System.Windows.Forms.Button();
            this.BtnSavePermissions = new System.Windows.Forms.Button();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgWorkers)).BeginInit();
            this.SuspendLayout();
            // 
            // DgWorkers
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DgWorkers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgWorkers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgWorkers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgWorkers.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DgWorkers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgWorkers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgWorkers.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgWorkers.Location = new System.Drawing.Point(72, 23);
            this.DgWorkers.MultiSelect = false;
            this.DgWorkers.Name = "DgWorkers";
            this.DgWorkers.ReadOnly = true;
            this.DgWorkers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgWorkers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgWorkers.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DgWorkers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgWorkers.Size = new System.Drawing.Size(782, 423);
            this.DgWorkers.TabIndex = 0;
            // 
            // BtnAddNewWorker
            // 
            this.BtnAddNewWorker.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnAddNewWorker.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddNewWorker.Location = new System.Drawing.Point(582, 487);
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
            this.TxtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtID_KeyPress);
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
            this.BtnExitNoSave.BackColor = System.Drawing.Color.CornflowerBlue;
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
            this.BtnSave.BackColor = System.Drawing.Color.CornflowerBlue;
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
            this.BtnPermissions.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnPermissions.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPermissions.Location = new System.Drawing.Point(416, 487);
            this.BtnPermissions.Name = "BtnPermissions";
            this.BtnPermissions.Size = new System.Drawing.Size(129, 63);
            this.BtnPermissions.TabIndex = 27;
            this.BtnPermissions.Text = "ניהול הרשאות";
            this.BtnPermissions.UseVisualStyleBackColor = false;
            this.BtnPermissions.Click += new System.EventHandler(this.BtnPermissions_Click);
            // 
            // btnEditWorkers
            // 
            this.btnEditWorkers.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEditWorkers.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditWorkers.Location = new System.Drawing.Point(247, 487);
            this.btnEditWorkers.Name = "btnEditWorkers";
            this.btnEditWorkers.Size = new System.Drawing.Size(129, 63);
            this.btnEditWorkers.TabIndex = 28;
            this.btnEditWorkers.Text = "עריכה";
            this.btnEditWorkers.UseVisualStyleBackColor = false;
            this.btnEditWorkers.Click += new System.EventHandler(this.btnEditWorkers_Click);
            // 
            // btnSaveEditing
            // 
            this.btnSaveEditing.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveEditing.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEditing.Location = new System.Drawing.Point(482, 487);
            this.btnSaveEditing.Name = "btnSaveEditing";
            this.btnSaveEditing.Size = new System.Drawing.Size(129, 63);
            this.btnSaveEditing.TabIndex = 29;
            this.btnSaveEditing.Text = "שמירה";
            this.btnSaveEditing.UseVisualStyleBackColor = false;
            this.btnSaveEditing.Visible = false;
            this.btnSaveEditing.Click += new System.EventHandler(this.btnSaveEditing_Click);
            // 
            // BtnExitNoSaveEditting
            // 
            this.BtnExitNoSaveEditting.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnExitNoSaveEditting.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExitNoSaveEditting.Location = new System.Drawing.Point(330, 487);
            this.BtnExitNoSaveEditting.Name = "BtnExitNoSaveEditting";
            this.BtnExitNoSaveEditting.Size = new System.Drawing.Size(129, 63);
            this.BtnExitNoSaveEditting.TabIndex = 30;
            this.BtnExitNoSaveEditting.Text = "יציאה ללא שמירה";
            this.BtnExitNoSaveEditting.UseVisualStyleBackColor = false;
            this.BtnExitNoSaveEditting.Visible = false;
            this.BtnExitNoSaveEditting.Click += new System.EventHandler(this.BtnExitNoSaveEditting_Click);
            // 
            // LblPermission
            // 
            this.LblPermission.BackColor = System.Drawing.Color.White;
            this.LblPermission.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPermission.Location = new System.Drawing.Point(520, 317);
            this.LblPermission.Name = "LblPermission";
            this.LblPermission.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblPermission.Size = new System.Drawing.Size(104, 24);
            this.LblPermission.TabIndex = 31;
            this.LblPermission.Text = "הרשאה";
            this.LblPermission.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CmbPermissions
            // 
            this.CmbPermissions.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbPermissions.FormattingEnabled = true;
            this.CmbPermissions.Location = new System.Drawing.Point(359, 317);
            this.CmbPermissions.Name = "CmbPermissions";
            this.CmbPermissions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmbPermissions.Size = new System.Drawing.Size(100, 24);
            this.CmbPermissions.TabIndex = 32;
            // 
            // BtnExitNoSavePermissions
            // 
            this.BtnExitNoSavePermissions.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnExitNoSavePermissions.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExitNoSavePermissions.Location = new System.Drawing.Point(330, 487);
            this.BtnExitNoSavePermissions.Name = "BtnExitNoSavePermissions";
            this.BtnExitNoSavePermissions.Size = new System.Drawing.Size(129, 63);
            this.BtnExitNoSavePermissions.TabIndex = 34;
            this.BtnExitNoSavePermissions.Text = "יציאה ללא שמירה";
            this.BtnExitNoSavePermissions.UseVisualStyleBackColor = false;
            this.BtnExitNoSavePermissions.Visible = false;
            this.BtnExitNoSavePermissions.Click += new System.EventHandler(this.BtnExitNoSavePermissions_Click);
            // 
            // BtnSavePermissions
            // 
            this.BtnSavePermissions.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnSavePermissions.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSavePermissions.Location = new System.Drawing.Point(482, 487);
            this.BtnSavePermissions.Name = "BtnSavePermissions";
            this.BtnSavePermissions.Size = new System.Drawing.Size(129, 63);
            this.BtnSavePermissions.TabIndex = 33;
            this.BtnSavePermissions.Text = "שמירה";
            this.BtnSavePermissions.UseVisualStyleBackColor = false;
            this.BtnSavePermissions.Visible = false;
            this.BtnSavePermissions.Click += new System.EventHandler(this.BtnSavePermissions_Click);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(359, 362);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(100, 23);
            this.TxtEmail.TabIndex = 36;
            this.TxtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(522, 360);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 35;
            this.label1.Text = "דואר אלקטרוני";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // F_Workers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(931, 574);
            this.Controls.Add(this.BtnExitNoSavePermissions);
            this.Controls.Add(this.BtnSavePermissions);
            this.Controls.Add(this.BtnExitNoSaveEditting);
            this.Controls.Add(this.btnSaveEditing);
            this.Controls.Add(this.btnEditWorkers);
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
            this.Controls.Add(this.CmbPermissions);
            this.Controls.Add(this.LblPermission);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtEmail);
            this.Name = "F_Workers";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button btnEditWorkers;
        private System.Windows.Forms.Button btnSaveEditing;
        private System.Windows.Forms.Button BtnExitNoSaveEditting;
        private System.Windows.Forms.Label LblPermission;
        private System.Windows.Forms.ComboBox CmbPermissions;
        private System.Windows.Forms.Button BtnExitNoSavePermissions;
        private System.Windows.Forms.Button BtnSavePermissions;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label1;
    }
}