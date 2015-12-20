namespace Clinic1
{
    partial class F_UpdateGroups
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
            this.DgPatients = new System.Windows.Forms.DataGridView();
            this.CmbGroupName = new System.Windows.Forms.ComboBox();
            this.CmblGroupId = new System.Windows.Forms.ComboBox();
            this.LblGrouptName = new System.Windows.Forms.Label();
            this.LblGroupNumber = new System.Windows.Forms.Label();
            this.BtnAddToGroup = new System.Windows.Forms.Button();
            this.CmbPatientName = new System.Windows.Forms.ComboBox();
            this.CmblPatientId = new System.Windows.Forms.ComboBox();
            this.LblPatientName = new System.Windows.Forms.Label();
            this.LblPatientId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgPatients)).BeginInit();
            this.SuspendLayout();
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
            this.DgPatients.Location = new System.Drawing.Point(139, 147);
            this.DgPatients.Name = "DgPatients";
            this.DgPatients.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DgPatients.Size = new System.Drawing.Size(703, 415);
            this.DgPatients.TabIndex = 45;
            // 
            // CmbGroupName
            // 
            this.CmbGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbGroupName.FormattingEnabled = true;
            this.CmbGroupName.Location = new System.Drawing.Point(641, 95);
            this.CmbGroupName.Name = "CmbGroupName";
            this.CmbGroupName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmbGroupName.Size = new System.Drawing.Size(124, 24);
            this.CmbGroupName.TabIndex = 49;
            // 
            // CmblGroupId
            // 
            this.CmblGroupId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmblGroupId.FormattingEnabled = true;
            this.CmblGroupId.Location = new System.Drawing.Point(641, 64);
            this.CmblGroupId.Name = "CmblGroupId";
            this.CmblGroupId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmblGroupId.Size = new System.Drawing.Size(124, 24);
            this.CmblGroupId.TabIndex = 48;
            this.CmblGroupId.SelectedIndexChanged += new System.EventHandler(this.CmblGroupId_SelectedIndexChanged);
            // 
            // LblGrouptName
            // 
            this.LblGrouptName.AutoSize = true;
            this.LblGrouptName.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGrouptName.ForeColor = System.Drawing.Color.AliceBlue;
            this.LblGrouptName.Location = new System.Drawing.Point(771, 97);
            this.LblGrouptName.Name = "LblGrouptName";
            this.LblGrouptName.Size = new System.Drawing.Size(71, 16);
            this.LblGrouptName.TabIndex = 47;
            this.LblGrouptName.Text = "שם קבוצה";
            // 
            // LblGroupNumber
            // 
            this.LblGroupNumber.AutoSize = true;
            this.LblGroupNumber.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGroupNumber.ForeColor = System.Drawing.Color.AliceBlue;
            this.LblGroupNumber.Location = new System.Drawing.Point(770, 68);
            this.LblGroupNumber.Name = "LblGroupNumber";
            this.LblGroupNumber.Size = new System.Drawing.Size(85, 16);
            this.LblGroupNumber.TabIndex = 46;
            this.LblGroupNumber.Text = "מספר קבוצה";
            // 
            // BtnAddToGroup
            // 
            this.BtnAddToGroup.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnAddToGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddToGroup.ForeColor = System.Drawing.Color.Black;
            this.BtnAddToGroup.Location = new System.Drawing.Point(287, 71);
            this.BtnAddToGroup.Name = "BtnAddToGroup";
            this.BtnAddToGroup.Size = new System.Drawing.Size(83, 40);
            this.BtnAddToGroup.TabIndex = 54;
            this.BtnAddToGroup.Text = "הוסף לקבוצה";
            this.BtnAddToGroup.UseVisualStyleBackColor = false;
            this.BtnAddToGroup.Click += new System.EventHandler(this.BtnAddToGroup_Click);
            // 
            // CmbPatientName
            // 
            this.CmbPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbPatientName.FormattingEnabled = true;
            this.CmbPatientName.Location = new System.Drawing.Point(376, 95);
            this.CmbPatientName.Name = "CmbPatientName";
            this.CmbPatientName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmbPatientName.Size = new System.Drawing.Size(166, 24);
            this.CmbPatientName.TabIndex = 53;
            // 
            // CmblPatientId
            // 
            this.CmblPatientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmblPatientId.FormattingEnabled = true;
            this.CmblPatientId.Location = new System.Drawing.Point(376, 64);
            this.CmblPatientId.Name = "CmblPatientId";
            this.CmblPatientId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmblPatientId.Size = new System.Drawing.Size(166, 24);
            this.CmblPatientId.TabIndex = 52;
            // 
            // LblPatientName
            // 
            this.LblPatientName.AutoSize = true;
            this.LblPatientName.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPatientName.ForeColor = System.Drawing.Color.AliceBlue;
            this.LblPatientName.Location = new System.Drawing.Point(548, 97);
            this.LblPatientName.Name = "LblPatientName";
            this.LblPatientName.Size = new System.Drawing.Size(71, 16);
            this.LblPatientName.TabIndex = 51;
            this.LblPatientName.Text = "שם מטופל";
            // 
            // LblPatientId
            // 
            this.LblPatientId.AutoSize = true;
            this.LblPatientId.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPatientId.ForeColor = System.Drawing.Color.AliceBlue;
            this.LblPatientId.Location = new System.Drawing.Point(547, 68);
            this.LblPatientId.Name = "LblPatientId";
            this.LblPatientId.Size = new System.Drawing.Size(72, 16);
            this.LblPatientId.TabIndex = 50;
            this.LblPatientId.Text = "ת.ז. מטופל";
            // 
            // F_UpdateGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(981, 579);
            this.Controls.Add(this.BtnAddToGroup);
            this.Controls.Add(this.CmbPatientName);
            this.Controls.Add(this.CmblPatientId);
            this.Controls.Add(this.LblPatientName);
            this.Controls.Add(this.LblPatientId);
            this.Controls.Add(this.CmbGroupName);
            this.Controls.Add(this.CmblGroupId);
            this.Controls.Add(this.LblGrouptName);
            this.Controls.Add(this.LblGroupNumber);
            this.Controls.Add(this.DgPatients);
            this.Name = "F_UpdateGroups";
            this.Text = "F_UpdateGroups";
            ((System.ComponentModel.ISupportInitialize)(this.DgPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgPatients;
        private System.Windows.Forms.ComboBox CmbGroupName;
        private System.Windows.Forms.ComboBox CmblGroupId;
        private System.Windows.Forms.Label LblGrouptName;
        private System.Windows.Forms.Label LblGroupNumber;
        private System.Windows.Forms.Button BtnAddToGroup;
        private System.Windows.Forms.ComboBox CmbPatientName;
        private System.Windows.Forms.ComboBox CmblPatientId;
        private System.Windows.Forms.Label LblPatientName;
        private System.Windows.Forms.Label LblPatientId;
    }
}