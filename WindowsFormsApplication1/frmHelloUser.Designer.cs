namespace WindowsFormsApplication1
{
    partial class frmHelloUser
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LBLHi
            // 
            this.LBLHi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LBLHi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LBLHi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LBLHi.Location = new System.Drawing.Point(522, 298);
            this.LBLHi.Name = "LBLHi";
            this.LBLHi.Size = new System.Drawing.Size(153, 109);
            this.LBLHi.TabIndex = 0;
            this.LBLHi.Click += new System.EventHandler(this.LBLHi_Click);
            // 
            // BTNPress
            // 
            this.BTNPress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNPress.Location = new System.Drawing.Point(521, 258);
            this.BTNPress.Name = "BTNPress";
            this.BTNPress.Size = new System.Drawing.Size(153, 37);
            this.BTNPress.TabIndex = 1;
            this.BTNPress.Text = "Press Here";
            this.BTNPress.UseVisualStyleBackColor = true;
            this.BTNPress.Click += new System.EventHandler(this.BTNPress_Click);
            // 
            // lblName
            // 
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblName.Location = new System.Drawing.Point(392, 234);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(123, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Please enter your name.";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Control;
            this.txtName.Location = new System.Drawing.Point(522, 232);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(153, 20);
            this.txtName.TabIndex = 3;
            // 
            // lblNum
            // 
            this.lblNum.AutoEllipsis = true;
            this.lblNum.BackColor = System.Drawing.SystemColors.Control;
            this.lblNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblNum.Location = new System.Drawing.Point(392, 182);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(123, 18);
            this.lblNum.TabIndex = 4;
            this.lblNum.Text = "Please enter a  number";
            this.lblNum.Click += new System.EventHandler(this.lblWhat_Click);
            // 
            // txtNum
            // 
            this.txtNum.BackColor = System.Drawing.SystemColors.Control;
            this.txtNum.Location = new System.Drawing.Point(522, 180);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(153, 20);
            this.txtNum.TabIndex = 5;
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(372, 209);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(143, 13);
            this.lblNum2.TabIndex = 6;
            this.lblNum2.Text = "Please enter another number";
            // 
            // txtNum2
            // 
            this.txtNum2.BackColor = System.Drawing.SystemColors.Control;
            this.txtNum2.Location = new System.Drawing.Point(521, 206);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(154, 20);
            this.txtNum2.TabIndex = 7;
            // 
            // frmHelloUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 627);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.BTNPress);
            this.Controls.Add(this.LBLHi);
            this.Name = "frmHelloUser";
            this.Text = "Hello User 2.0";
            this.Load += new System.EventHandler(this.frmHelloUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLHi;
        private System.Windows.Forms.Button BTNPress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.TextBox txtNum2;
    }
}

