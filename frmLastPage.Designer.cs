namespace GeographyApp
{
    partial class frmLastPage
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
            this.lblThankyou = new System.Windows.Forms.Label();
            this.lblYourScore = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSUbmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblThankyou
            // 
            this.lblThankyou.BackColor = System.Drawing.Color.Transparent;
            this.lblThankyou.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThankyou.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblThankyou.Location = new System.Drawing.Point(111, 25);
            this.lblThankyou.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThankyou.Name = "lblThankyou";
            this.lblThankyou.Size = new System.Drawing.Size(283, 29);
            this.lblThankyou.TabIndex = 0;
            this.lblThankyou.Text = "Thank you for playing!";
            // 
            // lblYourScore
            // 
            this.lblYourScore.BackColor = System.Drawing.Color.Transparent;
            this.lblYourScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblYourScore.Location = new System.Drawing.Point(72, 143);
            this.lblYourScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYourScore.Name = "lblYourScore";
            this.lblYourScore.Size = new System.Drawing.Size(99, 24);
            this.lblYourScore.TabIndex = 1;
            this.lblYourScore.Text = "Your Score:";
            // 
            // lblScore
            // 
            this.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScore.Location = new System.Drawing.Point(206, 143);
            this.lblScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(67, 15);
            this.lblScore.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(206, 222);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(183, 20);
            this.txtName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(32, 220);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter your name:";
            // 
            // btnSUbmit
            // 
            this.btnSUbmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSUbmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSUbmit.Location = new System.Drawing.Point(206, 299);
            this.btnSUbmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSUbmit.Name = "btnSUbmit";
            this.btnSUbmit.Size = new System.Drawing.Size(127, 44);
            this.btnSUbmit.TabIndex = 5;
            this.btnSUbmit.Text = "OK";
            this.btnSUbmit.UseVisualStyleBackColor = false;
            this.btnSUbmit.Click += new System.EventHandler(this.btnSUbmit_Click);
            // 
            // frmLastPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GeographyApp.Properties.Resources.landscape;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(535, 408);
            this.Controls.Add(this.btnSUbmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblYourScore);
            this.Controls.Add(this.lblThankyou);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmLastPage";
            this.Text = "Last Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThankyou;
        private System.Windows.Forms.Label lblYourScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSUbmit;
    }
}