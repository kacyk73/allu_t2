namespace allu2
{
    partial class Board
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
            this.btnBoardExit = new System.Windows.Forms.Button();
            this.lblPosX = new System.Windows.Forms.Label();
            this.lblPosY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBoardExit
            // 
            this.btnBoardExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBoardExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBoardExit.Location = new System.Drawing.Point(1382, 819);
            this.btnBoardExit.Name = "btnBoardExit";
            this.btnBoardExit.Size = new System.Drawing.Size(90, 30);
            this.btnBoardExit.TabIndex = 0;
            this.btnBoardExit.Text = "Exit!";
            this.btnBoardExit.UseVisualStyleBackColor = false;
            this.btnBoardExit.Click += new System.EventHandler(this.btnBoardExit_Click);
            // 
            // lblPosX
            // 
            this.lblPosX.AutoSize = true;
            this.lblPosX.Location = new System.Drawing.Point(1347, 76);
            this.lblPosX.Name = "lblPosX";
            this.lblPosX.Size = new System.Drawing.Size(32, 13);
            this.lblPosX.TabIndex = 1;
            this.lblPosX.Text = "PosX";
            // 
            // lblPosY
            // 
            this.lblPosY.AutoSize = true;
            this.lblPosY.Location = new System.Drawing.Point(1345, 106);
            this.lblPosY.Name = "lblPosY";
            this.lblPosY.Size = new System.Drawing.Size(32, 13);
            this.lblPosY.TabIndex = 2;
            this.lblPosY.Text = "PosY";
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1484, 861);
            this.Controls.Add(this.lblPosY);
            this.Controls.Add(this.lblPosX);
            this.Controls.Add(this.btnBoardExit);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1500, 900);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1500, 900);
            this.Name = "Board";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Allu game is on!";
            this.Load += new System.EventHandler(this.Board_Load);
            this.Shown += new System.EventHandler(this.Board_Shown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Board_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBoardExit;
        private System.Windows.Forms.Label lblPosX;
        private System.Windows.Forms.Label lblPosY;
    }
}