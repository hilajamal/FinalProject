namespace Clinic1
{
    partial class F_AddNewGroup
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
            this.LblName = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            this.txtGroupNumber = new System.Windows.Forms.TextBox();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.CmbPatientName = new System.Windows.Forms.ComboBox();
            this.CmblPatientId = new System.Windows.Forms.ComboBox();
            this.LblPatientName = new System.Windows.Forms.Label();
            this.LblPatientId = new System.Windows.Forms.Label();
            this.BtnAddToGroup = new System.Windows.Forms.Button();
            this.clinic = new Clinic1.Clinic();
            this.DgPatients = new System.Windows.Forms.DataGridView();
            this.btnSaveGroup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clinic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.ForeColor = System.Drawing.Color.Snow;
            this.LblName.Location = new System.Drawing.Point(559, 67);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(100, 20);
            this.LblName.TabIndex = 33;
            this.LblName.Text = ":שם קבוצה";
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblID.ForeColor = System.Drawing.Color.Snow;
            this.LblID.Location = new System.Drawing.Point(543, 26);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(117, 20);
            this.LblID.TabIndex = 32;
            this.LblID.Text = ":מספר קבוצה";
            // 
            // txtGroupNumber
            // 
            this.txtGroupNumber.Enabled = false;
            this.txtGroupNumber.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupNumber.Location = new System.Drawing.Point(437, 23);
            this.txtGroupNumber.Name = "txtGroupNumber";
            this.txtGroupNumber.Size = new System.Drawing.Size(100, 23);
            this.txtGroupNumber.TabIndex = 34;
            // 
            // txtGroupName
            // 
            this.txtGroupName.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupName.Location = new System.Drawing.Point(315, 65);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(222, 23);
            this.txtGroupName.TabIndex = 35;
            // 
            // CmbPatientName
            // 
            this.CmbPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbPatientName.FormattingEnabled = true;
            this.CmbPatientName.Location = new System.Drawing.Point(547, 188);
            this.CmbPatientName.Name = "CmbPatientName";
            this.CmbPatientName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmbPatientName.Size = new System.Drawing.Size(166, 24);
            this.CmbPatientName.TabIndex = 40;
            // 
            // CmblPatientId
            // 
            this.CmblPatientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmblPatientId.FormattingEnabled = true;
            this.CmblPatientId.Location = new System.Drawing.Point(547, 157);
            this.CmblPatientId.Name = "CmblPatientId";
            this.CmblPatientId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmblPatientId.Size = new System.Drawing.Size(166, 24);
            this.CmblPatientId.TabIndex = 39;
            // 
            // LblPatientName
            // 
            this.LblPatientName.AutoSize = true;
            this.LblPatientName.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPatientName.ForeColor = System.Drawing.Color.AliceBlue;
            this.LblPatientName.Location = new System.Drawing.Point(719, 190);
            this.LblPatientName.Name = "LblPatientName";
            this.LblPatientName.Size = new System.Drawing.Size(71, 16);
            this.LblPatientName.TabIndex = 38;
            this.LblPatientName.Text = "שם מטופל";
            // 
            // LblPatientId
            // 
            this.LblPatientId.AutoSize = true;
            this.LblPatientId.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPatientId.ForeColor = System.Drawing.Color.AliceBlue;
            this.LblPatientId.Location = new System.Drawing.Point(718, 161);
            this.LblPatientId.Name = "LblPatientId";
            this.LblPatientId.Size = new System.Drawing.Size(72, 16);
            this.LblPatientId.TabIndex = 37;
            this.LblPatientId.Text = "ת.ז. מטופל";
            // 
            // BtnAddToGroup
            // 
            this.BtnAddToGroup.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnAddToGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddToGroup.ForeColor = System.Drawing.Color.Black;
            this.BtnAddToGroup.Location = new System.Drawing.Point(437, 166);
            this.BtnAddToGroup.Name = "BtnAddToGroup";
            this.BtnAddToGroup.Size = new System.Drawing.Size(83, 40);
            this.BtnAddToGroup.TabIndex = 41;
            this.BtnAddToGroup.Text = "הוסף לקבוצה";
            this.BtnAddToGroup.UseVisualStyleBackColor = false;
            this.BtnAddToGroup.Click += new System.EventHandler(this.BtnAddToGroup_Click);
            // 
            // clinic
            // 
            this.clinic.DataSetName = "Clinic";
            this.clinic.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DgPatients
            // 
            this.DgPatients.AllowUserToAddRows = false;
            this.DgPatients.AllowUserToDeleteRows = false;
            this.DgPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgPatients.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DgPatients.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgPatients.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgPatients.Enabled = false;
            this.DgPatients.Location = new System.Drawing.Point(126, 240);
            this.DgPatients.Name = "DgPatients";
            this.DgPatients.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DgPatients.Size = new System.Drawing.Size(703, 271);
            this.DgPatients.TabIndex = 42;
            // 
            // btnSaveGroup
            // 
            this.btnSaveGroup.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSaveGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveGroup.ForeColor = System.Drawing.Color.Black;
            this.btnSaveGroup.Location = new System.Drawing.Point(437, 517);
            this.btnSaveGroup.Name = "btnSaveGroup";
            this.btnSaveGroup.Size = new System.Drawing.Size(114, 55);
            this.btnSaveGroup.TabIndex = 43;
            this.btnSaveGroup.Text = "שמור קבוצה";
            this.btnSaveGroup.UseVisualStyleBackColor = false;
            // 
            // F_AddNewGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(950, 584);
            this.Controls.Add(this.btnSaveGroup);
            this.Controls.Add(this.DgPatients);
            this.Controls.Add(this.BtnAddToGroup);
            this.Controls.Add(this.CmbPatientName);
            this.Controls.Add(this.CmblPatientId);
            this.Controls.Add(this.LblPatientName);
            this.Controls.Add(this.LblPatientId);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.txtGroupNumber);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblID);
            this.Name = "F_AddNewGroup";
            this.Text = "F_AddNewGroup";
            ((System.ComponentModel.ISupportInitialize)(this.clinic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.TextBox txtGroupNumber;
        private System.Windows.Forms.TextBox txtGroupName;
        private Clinic clinic;
        private System.Windows.Forms.ComboBox CmbPatientName;
        private System.Windows.Forms.ComboBox CmblPatientId;
        private System.Windows.Forms.Label LblPatientName;
        private System.Windows.Forms.Label LblPatientId;
        private System.Windows.Forms.Button BtnAddToGroup;
        private System.Windows.Forms.DataGridView DgPatients;
        private System.Windows.Forms.Button btnSaveGroup;
    }
}