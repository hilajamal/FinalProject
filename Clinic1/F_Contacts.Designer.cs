namespace Clinic1
{
    partial class F_Contacts
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
            this.CmbContactType = new System.Windows.Forms.ComboBox();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.CmbWorker = new System.Windows.Forms.ComboBox();
            this.TxtContents = new System.Windows.Forms.RichTextBox();
            this.TxtRemarks = new System.Windows.Forms.RichTextBox();
            this.LblContents = new System.Windows.Forms.Label();
            this.LblRemarks = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblWorker = new System.Windows.Forms.Label();
            this.LblContactFirstName = new System.Windows.Forms.Label();
            this.LblContactPersonType = new System.Windows.Forms.Label();
            this.LblRelationship = new System.Windows.Forms.Label();
            this.TxtContactFirstName = new System.Windows.Forms.TextBox();
            this.CmbRelationship = new System.Windows.Forms.ComboBox();
            this.TxtContactPersonType = new System.Windows.Forms.TextBox();
            this.LblPatientName = new System.Windows.Forms.Label();
            this.LblPatientId = new System.Windows.Forms.Label();
            this.CmblPatientId = new System.Windows.Forms.ComboBox();
            this.CmbPatientName = new System.Windows.Forms.ComboBox();
            this.HourPicker = new System.Windows.Forms.DateTimePicker();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnExitNoSave = new System.Windows.Forms.Button();
            this.TxtContactLastName = new System.Windows.Forms.TextBox();
            this.LblContactLastName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmbContactType
            // 
            this.CmbContactType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbContactType.FormattingEnabled = true;
            this.CmbContactType.Location = new System.Drawing.Point(458, 115);
            this.CmbContactType.Name = "CmbContactType";
            this.CmbContactType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmbContactType.Size = new System.Drawing.Size(124, 24);
            this.CmbContactType.TabIndex = 0;
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(46, 5);
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 2;
            // 
            // CmbWorker
            // 
            this.CmbWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbWorker.FormattingEnabled = true;
            this.CmbWorker.Location = new System.Drawing.Point(458, 148);
            this.CmbWorker.Name = "CmbWorker";
            this.CmbWorker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmbWorker.Size = new System.Drawing.Size(124, 24);
            this.CmbWorker.TabIndex = 3;
            // 
            // TxtContents
            // 
            this.TxtContents.Location = new System.Drawing.Point(52, 312);
            this.TxtContents.Name = "TxtContents";
            this.TxtContents.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtContents.Size = new System.Drawing.Size(626, 100);
            this.TxtContents.TabIndex = 4;
            this.TxtContents.Text = "";
            // 
            // TxtRemarks
            // 
            this.TxtRemarks.Location = new System.Drawing.Point(52, 437);
            this.TxtRemarks.Name = "TxtRemarks";
            this.TxtRemarks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtRemarks.Size = new System.Drawing.Size(626, 74);
            this.TxtRemarks.TabIndex = 5;
            this.TxtRemarks.Text = "";
            // 
            // LblContents
            // 
            this.LblContents.AutoSize = true;
            this.LblContents.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContents.ForeColor = System.Drawing.Color.Snow;
            this.LblContents.Location = new System.Drawing.Point(327, 292);
            this.LblContents.Name = "LblContents";
            this.LblContents.Size = new System.Drawing.Size(80, 16);
            this.LblContents.TabIndex = 6;
            this.LblContents.Text = "תוכן השיחה";
            // 
            // LblRemarks
            // 
            this.LblRemarks.AutoSize = true;
            this.LblRemarks.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRemarks.ForeColor = System.Drawing.Color.Snow;
            this.LblRemarks.Location = new System.Drawing.Point(336, 418);
            this.LblRemarks.Name = "LblRemarks";
            this.LblRemarks.Size = new System.Drawing.Size(46, 16);
            this.LblRemarks.TabIndex = 7;
            this.LblRemarks.Text = "הערות";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(666, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "סוג מגע";
            // 
            // LblWorker
            // 
            this.LblWorker.AutoSize = true;
            this.LblWorker.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWorker.ForeColor = System.Drawing.Color.Snow;
            this.LblWorker.Location = new System.Drawing.Point(679, 150);
            this.LblWorker.Name = "LblWorker";
            this.LblWorker.Size = new System.Drawing.Size(41, 16);
            this.LblWorker.TabIndex = 10;
            this.LblWorker.Text = "מקבל";
            // 
            // LblContactFirstName
            // 
            this.LblContactFirstName.AutoSize = true;
            this.LblContactFirstName.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContactFirstName.ForeColor = System.Drawing.Color.Snow;
            this.LblContactFirstName.Location = new System.Drawing.Point(598, 184);
            this.LblContactFirstName.Name = "LblContactFirstName";
            this.LblContactFirstName.Size = new System.Drawing.Size(125, 16);
            this.LblContactFirstName.TabIndex = 11;
            this.LblContactFirstName.Text = "שם פרטי איש קשר";
            // 
            // LblContactPersonType
            // 
            this.LblContactPersonType.AutoSize = true;
            this.LblContactPersonType.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContactPersonType.ForeColor = System.Drawing.Color.Snow;
            this.LblContactPersonType.Location = new System.Drawing.Point(633, 250);
            this.LblContactPersonType.Name = "LblContactPersonType";
            this.LblContactPersonType.Size = new System.Drawing.Size(89, 16);
            this.LblContactPersonType.TabIndex = 12;
            this.LblContactPersonType.Text = "סוג איש קשר";
            // 
            // LblRelationship
            // 
            this.LblRelationship.AutoSize = true;
            this.LblRelationship.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRelationship.ForeColor = System.Drawing.Color.Snow;
            this.LblRelationship.Location = new System.Drawing.Point(674, 280);
            this.LblRelationship.Name = "LblRelationship";
            this.LblRelationship.Size = new System.Drawing.Size(47, 16);
            this.LblRelationship.TabIndex = 14;
            this.LblRelationship.Text = "קירבה";
            // 
            // TxtContactFirstName
            // 
            this.TxtContactFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContactFirstName.Location = new System.Drawing.Point(458, 182);
            this.TxtContactFirstName.Name = "TxtContactFirstName";
            this.TxtContactFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtContactFirstName.Size = new System.Drawing.Size(124, 22);
            this.TxtContactFirstName.TabIndex = 15;
            // 
            // CmbRelationship
            // 
            this.CmbRelationship.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbRelationship.FormattingEnabled = true;
            this.CmbRelationship.Location = new System.Drawing.Point(458, 275);
            this.CmbRelationship.Name = "CmbRelationship";
            this.CmbRelationship.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmbRelationship.Size = new System.Drawing.Size(124, 24);
            this.CmbRelationship.TabIndex = 16;
            // 
            // TxtContactPersonType
            // 
            this.TxtContactPersonType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContactPersonType.Location = new System.Drawing.Point(458, 245);
            this.TxtContactPersonType.Name = "TxtContactPersonType";
            this.TxtContactPersonType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtContactPersonType.Size = new System.Drawing.Size(124, 22);
            this.TxtContactPersonType.TabIndex = 17;
            // 
            // LblPatientName
            // 
            this.LblPatientName.AutoSize = true;
            this.LblPatientName.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPatientName.ForeColor = System.Drawing.Color.AliceBlue;
            this.LblPatientName.Location = new System.Drawing.Point(620, 50);
            this.LblPatientName.Name = "LblPatientName";
            this.LblPatientName.Size = new System.Drawing.Size(71, 16);
            this.LblPatientName.TabIndex = 19;
            this.LblPatientName.Text = "שם מטופל";
            // 
            // LblPatientId
            // 
            this.LblPatientId.AutoSize = true;
            this.LblPatientId.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPatientId.ForeColor = System.Drawing.Color.AliceBlue;
            this.LblPatientId.Location = new System.Drawing.Point(619, 21);
            this.LblPatientId.Name = "LblPatientId";
            this.LblPatientId.Size = new System.Drawing.Size(72, 16);
            this.LblPatientId.TabIndex = 18;
            this.LblPatientId.Text = "ת.ז. מטופל";
            // 
            // CmblPatientId
            // 
            this.CmblPatientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmblPatientId.FormattingEnabled = true;
            this.CmblPatientId.Location = new System.Drawing.Point(490, 17);
            this.CmblPatientId.Name = "CmblPatientId";
            this.CmblPatientId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmblPatientId.Size = new System.Drawing.Size(124, 24);
            this.CmblPatientId.TabIndex = 20;
            // 
            // CmbPatientName
            // 
            this.CmbPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbPatientName.FormattingEnabled = true;
            this.CmbPatientName.Location = new System.Drawing.Point(490, 48);
            this.CmbPatientName.Name = "CmbPatientName";
            this.CmbPatientName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmbPatientName.Size = new System.Drawing.Size(124, 24);
            this.CmbPatientName.TabIndex = 21;
            // 
            // HourPicker
            // 
            this.HourPicker.AllowDrop = true;
            this.HourPicker.Location = new System.Drawing.Point(59, 170);
            this.HourPicker.Name = "HourPicker";
            this.HourPicker.Size = new System.Drawing.Size(200, 20);
            this.HourPicker.TabIndex = 22;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.Black;
            this.BtnSave.Location = new System.Drawing.Point(490, 526);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(143, 40);
            this.BtnSave.TabIndex = 23;
            this.BtnSave.Text = "שמירה";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnExitNoSave
            // 
            this.BtnExitNoSave.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnExitNoSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExitNoSave.ForeColor = System.Drawing.Color.Black;
            this.BtnExitNoSave.Location = new System.Drawing.Point(74, 526);
            this.BtnExitNoSave.Name = "BtnExitNoSave";
            this.BtnExitNoSave.Size = new System.Drawing.Size(152, 40);
            this.BtnExitNoSave.TabIndex = 24;
            this.BtnExitNoSave.Text = "יציאה ללא שמירה";
            this.BtnExitNoSave.UseVisualStyleBackColor = false;
            // 
            // TxtContactLastName
            // 
            this.TxtContactLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContactLastName.Location = new System.Drawing.Point(457, 214);
            this.TxtContactLastName.Name = "TxtContactLastName";
            this.TxtContactLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtContactLastName.Size = new System.Drawing.Size(124, 22);
            this.TxtContactLastName.TabIndex = 26;
            // 
            // LblContactLastName
            // 
            this.LblContactLastName.AutoSize = true;
            this.LblContactLastName.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContactLastName.ForeColor = System.Drawing.Color.Snow;
            this.LblContactLastName.Location = new System.Drawing.Point(584, 217);
            this.LblContactLastName.Name = "LblContactLastName";
            this.LblContactLastName.Size = new System.Drawing.Size(140, 16);
            this.LblContactLastName.TabIndex = 25;
            this.LblContactLastName.Text = "שם משפחה איש קשר";
            // 
            // F_Contacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(721, 578);
            this.Controls.Add(this.TxtContactLastName);
            this.Controls.Add(this.LblContactLastName);
            this.Controls.Add(this.BtnExitNoSave);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.HourPicker);
            this.Controls.Add(this.CmbPatientName);
            this.Controls.Add(this.CmblPatientId);
            this.Controls.Add(this.LblPatientName);
            this.Controls.Add(this.LblPatientId);
            this.Controls.Add(this.TxtContactPersonType);
            this.Controls.Add(this.CmbRelationship);
            this.Controls.Add(this.TxtContactFirstName);
            this.Controls.Add(this.LblRelationship);
            this.Controls.Add(this.LblContactPersonType);
            this.Controls.Add(this.LblContactFirstName);
            this.Controls.Add(this.LblWorker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblRemarks);
            this.Controls.Add(this.LblContents);
            this.Controls.Add(this.TxtRemarks);
            this.Controls.Add(this.TxtContents);
            this.Controls.Add(this.CmbWorker);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.CmbContactType);
            this.ForeColor = System.Drawing.Color.Snow;
            this.Name = "F_Contacts";
            this.Text = "F_Contacts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbContactType;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.ComboBox CmbWorker;
        private System.Windows.Forms.RichTextBox TxtContents;
        private System.Windows.Forms.RichTextBox TxtRemarks;
        private System.Windows.Forms.Label LblContents;
        private System.Windows.Forms.Label LblRemarks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblWorker;
        private System.Windows.Forms.Label LblContactFirstName;
        private System.Windows.Forms.Label LblContactPersonType;
        private System.Windows.Forms.Label LblRelationship;
        private System.Windows.Forms.TextBox TxtContactFirstName;
        private System.Windows.Forms.ComboBox CmbRelationship;
        private System.Windows.Forms.TextBox TxtContactPersonType;
        private System.Windows.Forms.Label LblPatientName;
        private System.Windows.Forms.Label LblPatientId;
        private System.Windows.Forms.ComboBox CmblPatientId;
        private System.Windows.Forms.ComboBox CmbPatientName;
        private System.Windows.Forms.DateTimePicker HourPicker;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnExitNoSave;
        private System.Windows.Forms.TextBox TxtContactLastName;
        private System.Windows.Forms.Label LblContactLastName;
    }
}