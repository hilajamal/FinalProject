namespace Clinic1
{
    partial class F_MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnContacts = new System.Windows.Forms.Button();
            this.BtnWorkers = new System.Windows.Forms.Button();
            this.BtnGroups = new System.Windows.Forms.Button();
            this.BtnPatients = new System.Windows.Forms.Button();
            this.btnGroupsMeetings = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnIntake = new System.Windows.Forms.Button();
            this.BtnIntakeBoard = new System.Windows.Forms.Button();
            this.BtnPsycho = new System.Windows.Forms.Button();
            this.BtnDoctor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button1.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(32, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 133);
            this.button1.TabIndex = 0;
            this.button1.Text = "יומן";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnContacts
            // 
            this.btnContacts.BackColor = System.Drawing.Color.Purple;
            this.btnContacts.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContacts.ForeColor = System.Drawing.SystemColors.Control;
            this.btnContacts.Location = new System.Drawing.Point(32, 12);
            this.btnContacts.Name = "btnContacts";
            this.btnContacts.Size = new System.Drawing.Size(214, 136);
            this.btnContacts.TabIndex = 1;
            this.btnContacts.Text = "מגעים";
            this.btnContacts.UseVisualStyleBackColor = false;
            this.btnContacts.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnWorkers
            // 
            this.BtnWorkers.BackColor = System.Drawing.Color.Purple;
            this.BtnWorkers.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnWorkers.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnWorkers.Location = new System.Drawing.Point(508, 298);
            this.BtnWorkers.Name = "BtnWorkers";
            this.BtnWorkers.Size = new System.Drawing.Size(219, 136);
            this.BtnWorkers.TabIndex = 2;
            this.BtnWorkers.Text = "עובדים";
            this.BtnWorkers.UseVisualStyleBackColor = false;
            this.BtnWorkers.Click += new System.EventHandler(this.BtnWorkers_Click);
            // 
            // BtnGroups
            // 
            this.BtnGroups.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnGroups.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGroups.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnGroups.Location = new System.Drawing.Point(267, 440);
            this.BtnGroups.Name = "BtnGroups";
            this.BtnGroups.Size = new System.Drawing.Size(219, 136);
            this.BtnGroups.TabIndex = 3;
            this.BtnGroups.Text = "קבוצות טיפול";
            this.BtnGroups.UseVisualStyleBackColor = false;
            this.BtnGroups.Click += new System.EventHandler(this.BtnGroups_Click);
            // 
            // BtnPatients
            // 
            this.BtnPatients.BackColor = System.Drawing.Color.Purple;
            this.BtnPatients.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPatients.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnPatients.Location = new System.Drawing.Point(508, 12);
            this.BtnPatients.Name = "BtnPatients";
            this.BtnPatients.Size = new System.Drawing.Size(219, 135);
            this.BtnPatients.TabIndex = 4;
            this.BtnPatients.Text = "מטופלים";
            this.BtnPatients.UseVisualStyleBackColor = false;
            this.BtnPatients.Click += new System.EventHandler(this.BtnPatients_Click);
            // 
            // btnGroupsMeetings
            // 
            this.btnGroupsMeetings.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnGroupsMeetings.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroupsMeetings.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGroupsMeetings.Location = new System.Drawing.Point(508, 154);
            this.btnGroupsMeetings.Name = "btnGroupsMeetings";
            this.btnGroupsMeetings.Size = new System.Drawing.Size(219, 133);
            this.btnGroupsMeetings.TabIndex = 5;
            this.btnGroupsMeetings.Text = "פגישות קבוצתיות";
            this.btnGroupsMeetings.UseVisualStyleBackColor = false;
            this.btnGroupsMeetings.Click += new System.EventHandler(this.btnGroupsMeetings_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Purple;
            this.btnReports.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReports.Location = new System.Drawing.Point(267, 12);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(219, 133);
            this.btnReports.TabIndex = 6;
            this.btnReports.Text = "דו\"חות";
            this.btnReports.UseVisualStyleBackColor = false;
            // 
            // btnIntake
            // 
            this.btnIntake.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnIntake.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntake.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIntake.Location = new System.Drawing.Point(267, 154);
            this.btnIntake.Name = "btnIntake";
            this.btnIntake.Size = new System.Drawing.Size(219, 133);
            this.btnIntake.TabIndex = 7;
            this.btnIntake.Text = "אינטייק";
            this.btnIntake.UseVisualStyleBackColor = false;
            this.btnIntake.Click += new System.EventHandler(this.btnIntake_Click);
            // 
            // BtnIntakeBoard
            // 
            this.BtnIntakeBoard.BackColor = System.Drawing.Color.Purple;
            this.BtnIntakeBoard.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIntakeBoard.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnIntakeBoard.Location = new System.Drawing.Point(32, 300);
            this.BtnIntakeBoard.Name = "BtnIntakeBoard";
            this.BtnIntakeBoard.Size = new System.Drawing.Size(214, 136);
            this.BtnIntakeBoard.TabIndex = 8;
            this.BtnIntakeBoard.Text = "ועדות אינטייק";
            this.BtnIntakeBoard.UseVisualStyleBackColor = false;
            this.BtnIntakeBoard.Click += new System.EventHandler(this.BtnIntakeBoard_Click);
            // 
            // BtnPsycho
            // 
            this.BtnPsycho.BackColor = System.Drawing.Color.Purple;
            this.BtnPsycho.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPsycho.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnPsycho.Location = new System.Drawing.Point(267, 298);
            this.BtnPsycho.Name = "BtnPsycho";
            this.BtnPsycho.Size = new System.Drawing.Size(219, 136);
            this.BtnPsycho.TabIndex = 9;
            this.BtnPsycho.Text = "פסיכו-תרפיה";
            this.BtnPsycho.UseVisualStyleBackColor = false;
            this.BtnPsycho.Click += new System.EventHandler(this.BtnPsycho_Click);
            // 
            // BtnDoctor
            // 
            this.BtnDoctor.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnDoctor.Font = new System.Drawing.Font("David", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDoctor.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnDoctor.Location = new System.Drawing.Point(508, 440);
            this.BtnDoctor.Name = "BtnDoctor";
            this.BtnDoctor.Size = new System.Drawing.Size(219, 136);
            this.BtnDoctor.TabIndex = 10;
            this.BtnDoctor.Text = "מפגש רופא";
            this.BtnDoctor.UseVisualStyleBackColor = false;
            // 
            // F_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(743, 585);
            this.Controls.Add(this.BtnDoctor);
            this.Controls.Add(this.BtnPsycho);
            this.Controls.Add(this.BtnIntakeBoard);
            this.Controls.Add(this.btnIntake);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnGroupsMeetings);
            this.Controls.Add(this.BtnPatients);
            this.Controls.Add(this.BtnGroups);
            this.Controls.Add(this.BtnWorkers);
            this.Controls.Add(this.btnContacts);
            this.Controls.Add(this.button1);
            this.Name = "F_MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnContacts;
        private System.Windows.Forms.Button BtnWorkers;
        private System.Windows.Forms.Button BtnGroups;
        private System.Windows.Forms.Button BtnPatients;
        private System.Windows.Forms.Button btnGroupsMeetings;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnIntake;
        private System.Windows.Forms.Button BtnIntakeBoard;
        private System.Windows.Forms.Button BtnPsycho;
        private System.Windows.Forms.Button BtnDoctor;

    }
}

