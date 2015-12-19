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
            this.button2 = new System.Windows.Forms.Button();
            this.BtnWorkers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(905, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 83);
            this.button1.TabIndex = 0;
            this.button1.Text = "יומן";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(905, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 83);
            this.button2.TabIndex = 1;
            this.button2.Text = "מגעים";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnWorkers
            // 
            this.BtnWorkers.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnWorkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnWorkers.Location = new System.Drawing.Point(905, 295);
            this.BtnWorkers.Name = "BtnWorkers";
            this.BtnWorkers.Size = new System.Drawing.Size(138, 83);
            this.BtnWorkers.TabIndex = 2;
            this.BtnWorkers.Text = "עובדים";
            this.BtnWorkers.UseVisualStyleBackColor = false;
            this.BtnWorkers.Click += new System.EventHandler(this.BtnWorkers_Click);
            // 
            // F_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1084, 573);
            this.Controls.Add(this.BtnWorkers);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "F_MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnWorkers;

    }
}

