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
            this.SuspendLayout();
            // 
            // btnBoardExit
            // 
            this.btnBoardExit.Location = new System.Drawing.Point(1040, 624);
            this.btnBoardExit.Name = "btnBoardExit";
            this.btnBoardExit.Size = new System.Drawing.Size(103, 35);
            this.btnBoardExit.TabIndex = 0;
            this.btnBoardExit.Text = "Exit";
            this.btnBoardExit.UseVisualStyleBackColor = true;
            this.btnBoardExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 677);
            this.Controls.Add(this.btnBoardExit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Board";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Allu game is on!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBoardExit;
    }
}