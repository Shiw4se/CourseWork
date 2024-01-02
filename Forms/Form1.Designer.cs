namespace CourseWork
{
    partial class Form1
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
            this.StartPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.StartPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartPanel
            // 
            this.StartPanel.BackColor = System.Drawing.SystemColors.MenuText;
            this.StartPanel.Controls.Add(this.label1);
            this.StartPanel.Controls.Add(this.button15);
            this.StartPanel.Controls.Add(this.button14);
            this.StartPanel.Location = new System.Drawing.Point(2, -1);
            this.StartPanel.Name = "StartPanel";
            this.StartPanel.Size = new System.Drawing.Size(336, 434);
            this.StartPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuText;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(62, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 112);
            this.label1.TabIndex = 13;
            this.label1.Text = "GET STARTED";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.MenuText;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button15.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button15.ForeColor = System.Drawing.Color.Lime;
            this.button15.Location = new System.Drawing.Point(88, 277);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(172, 54);
            this.button15.TabIndex = 12;
            this.button15.Text = "Log in";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.ControlText;
            this.button14.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button14.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button14.ForeColor = System.Drawing.Color.Lime;
            this.button14.Location = new System.Drawing.Point(88, 172);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(172, 54);
            this.button14.TabIndex = 11;
            this.button14.Text = "Sing up";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(339, 434);
            this.Controls.Add(this.StartPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get Started";
            this.StartPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Panel StartPanel;

        private System.Windows.Forms.Panel RegisterrPanel;

        private System.Windows.Forms.Button button15;

        private System.Windows.Forms.Button button14;

        #endregion
    }
}