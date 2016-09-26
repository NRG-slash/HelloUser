namespace WindowsFormsApplication1
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
            this.LBLHi = new System.Windows.Forms.Label();
            this.BTNPress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLHi
            // 
            this.LBLHi.AutoSize = true;
            this.LBLHi.Location = new System.Drawing.Point(150, 302);
            this.LBLHi.Name = "LBLHi";
            this.LBLHi.Size = new System.Drawing.Size(0, 13);
            this.LBLHi.TabIndex = 0;
            // 
            // BTNPress
            // 
            this.BTNPress.Location = new System.Drawing.Point(115, 229);
            this.BTNPress.Name = "BTNPress";
            this.BTNPress.Size = new System.Drawing.Size(75, 23);
            this.BTNPress.TabIndex = 1;
            this.BTNPress.Text = "Press Here";
            this.BTNPress.UseVisualStyleBackColor = true;
            this.BTNPress.Click += new System.EventHandler(this.BTNPress_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 627);
            this.Controls.Add(this.BTNPress);
            this.Controls.Add(this.LBLHi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLHi;
        private System.Windows.Forms.Button BTNPress;
    }
}

