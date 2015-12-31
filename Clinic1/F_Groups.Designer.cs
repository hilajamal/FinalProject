namespace Clinic1
{
    partial class F_Groups
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnLogIn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LblName = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.BtnAddToGroup = new System.Windows.Forms.Button();
            this.CmbPatientName = new System.Windows.Forms.ComboBox();
            this.CmblPatientId = new System.Windows.Forms.ComboBox();
            this.LblPatientName = new System.Windows.Forms.Label();
            this.LblPatientId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(164, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(634, 387);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnLogIn
            // 
            this.BtnLogIn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogIn.ForeColor = System.Drawing.Color.Black;
            this.BtnLogIn.Location = new System.Drawing.Point(605, 22);
            this.BtnLogIn.Name = "BtnLogIn";
            this.BtnLogIn.Size = new System.Drawing.Size(143, 40);
            this.BtnLogIn.TabIndex = 27;
            this.BtnLogIn.Text = "הוספת קבוצה";
            this.BtnLogIn.UseVisualStyleBackColor = false;
            this.BtnLogIn.Click += new System.EventHandler(this.BtnLogIn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(428, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 40);
            this.button1.TabIndex = 28;
            this.button1.Text = "עדכון קבוצה";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(248, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 40);
            this.button2.TabIndex = 29;
            this.button2.Text = "מחיקת קבוצה";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.ForeColor = System.Drawing.Color.Snow;
            this.LblName.Location = new System.Drawing.Point(786, 124);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(100, 20);
            this.LblName.TabIndex = 31;
            this.LblName.Text = ":שם קבוצה";
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblID.ForeColor = System.Drawing.Color.Snow;
            this.LblID.Location = new System.Drawing.Point(770, 83);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(117, 20);
            this.LblID.TabIndex = 30;
            this.LblID.Text = ":מספר קבוצה";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(557, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(190, 28);
            this.comboBox1.TabIndex = 32;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(557, 120);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(191, 28);
            this.comboBox2.TabIndex = 33;
            // 
            // BtnAddToGroup
            // 
            this.BtnAddToGroup.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnAddToGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddToGroup.ForeColor = System.Drawing.Color.Black;
            this.BtnAddToGroup.Location = new System.Drawing.Point(164, 88);
            this.BtnAddToGroup.Name = "BtnAddToGroup";
            this.BtnAddToGroup.Size = new System.Drawing.Size(83, 40);
            this.BtnAddToGroup.TabIndex = 46;
            this.BtnAddToGroup.Text = "הוסף לקבוצה";
            this.BtnAddToGroup.UseVisualStyleBackColor = false;
            this.BtnAddToGroup.Click += new System.EventHandler(this.BtnAddToGroup_Click);
            // 
            // CmbPatientName
            // 
            this.CmbPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbPatientName.FormattingEnabled = true;
            this.CmbPatientName.Location = new System.Drawing.Point(274, 110);
            this.CmbPatientName.Name = "CmbPatientName";
            this.CmbPatientName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmbPatientName.Size = new System.Drawing.Size(166, 24);
            this.CmbPatientName.TabIndex = 45;
            // 
            // CmblPatientId
            // 
            this.CmblPatientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmblPatientId.FormattingEnabled = true;
            this.CmblPatientId.Location = new System.Drawing.Point(274, 79);
            this.CmblPatientId.Name = "CmblPatientId";
            this.CmblPatientId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmblPatientId.Size = new System.Drawing.Size(166, 24);
            this.CmblPatientId.TabIndex = 44;
            // 
            // LblPatientName
            // 
            this.LblPatientName.AutoSize = true;
            this.LblPatientName.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPatientName.ForeColor = System.Drawing.Color.AliceBlue;
            this.LblPatientName.Location = new System.Drawing.Point(446, 112);
            this.LblPatientName.Name = "LblPatientName";
            this.LblPatientName.Size = new System.Drawing.Size(71, 16);
            this.LblPatientName.TabIndex = 43;
            this.LblPatientName.Text = "שם מטופל";
            // 
            // LblPatientId
            // 
            this.LblPatientId.AutoSize = true;
            this.LblPatientId.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPatientId.ForeColor = System.Drawing.Color.AliceBlue;
            this.LblPatientId.Location = new System.Drawing.Point(445, 83);
            this.LblPatientId.Name = "LblPatientId";
            this.LblPatientId.Size = new System.Drawing.Size(72, 16);
            this.LblPatientId.TabIndex = 42;
            this.LblPatientId.Text = "ת.ז. מטופל";
            // 
            // F_Groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(971, 590);
            this.Controls.Add(this.BtnAddToGroup);
            this.Controls.Add(this.CmbPatientName);
            this.Controls.Add(this.CmblPatientId);
            this.Controls.Add(this.LblPatientName);
            this.Controls.Add(this.LblPatientId);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnLogIn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "F_Groups";
            this.Text = "F_Groups";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnLogIn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button BtnAddToGroup;
        private System.Windows.Forms.ComboBox CmbPatientName;
        private System.Windows.Forms.ComboBox CmblPatientId;
        private System.Windows.Forms.Label LblPatientName;
        private System.Windows.Forms.Label LblPatientId;
    }
}