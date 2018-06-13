namespace GeographyApp
{
    partial class frmFStartPage
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblHighScoreCaption = new System.Windows.Forms.Label();
            this.lblPlayerNae = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(330, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(336, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Canada\'s Capitals!";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(32, 848);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(190, 88);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(820, 848);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(190, 88);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblHighScoreCaption
            // 
            this.lblHighScoreCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScoreCaption.Location = new System.Drawing.Point(346, 75);
            this.lblHighScoreCaption.Name = "lblHighScoreCaption";
            this.lblHighScoreCaption.Size = new System.Drawing.Size(282, 52);
            this.lblHighScoreCaption.TabIndex = 4;
            this.lblHighScoreCaption.Text = "Top 10 Highest Scores";
            this.lblHighScoreCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerNae
            // 
            this.lblPlayerNae.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerNae.Location = new System.Drawing.Point(298, 175);
            this.lblPlayerNae.Name = "lblPlayerNae";
            this.lblPlayerNae.Size = new System.Drawing.Size(176, 35);
            this.lblPlayerNae.TabIndex = 5;
            this.lblPlayerNae.Text = "Name";
            this.lblPlayerNae.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(620, 175);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(176, 35);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "Score";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(184, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(692, 546);
            this.dataGridView1.TabIndex = 7;
            // 
            // frmFStartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1185, 997);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblPlayerNae);
            this.Controls.Add(this.lblHighScoreCaption);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmFStartPage";
            this.Text = "frmFStartPage";
            this.Load += new System.EventHandler(this.frmFStartPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblHighScoreCaption;
        private System.Windows.Forms.Label lblPlayerNae;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}