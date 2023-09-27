namespace Dewey_Decimal_System.Games
{
    partial class ReplacingBooks
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
            this.listBoxSorted = new System.Windows.Forms.ListBox();
            this.listBoxRand = new System.Windows.Forms.ListBox();
            this.Upbtn = new System.Windows.Forms.Button();
            this.DownBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxSorted
            // 
            this.listBoxSorted.FormattingEnabled = true;
            this.listBoxSorted.ItemHeight = 20;
            this.listBoxSorted.Location = new System.Drawing.Point(513, 114);
            this.listBoxSorted.Name = "listBoxSorted";
            this.listBoxSorted.Size = new System.Drawing.Size(248, 364);
            this.listBoxSorted.TabIndex = 0;
            // 
            // listBoxRand
            // 
            this.listBoxRand.FormattingEnabled = true;
            this.listBoxRand.ItemHeight = 20;
            this.listBoxRand.Location = new System.Drawing.Point(103, 114);
            this.listBoxRand.Name = "listBoxRand";
            this.listBoxRand.Size = new System.Drawing.Size(248, 364);
            this.listBoxRand.TabIndex = 1;
            // 
            // Upbtn
            // 
            this.Upbtn.Location = new System.Drawing.Point(834, 180);
            this.Upbtn.Name = "Upbtn";
            this.Upbtn.Size = new System.Drawing.Size(101, 85);
            this.Upbtn.TabIndex = 2;
            this.Upbtn.UseVisualStyleBackColor = true;
            // 
            // DownBtn
            // 
            this.DownBtn.Location = new System.Drawing.Point(834, 332);
            this.DownBtn.Name = "DownBtn";
            this.DownBtn.Size = new System.Drawing.Size(101, 85);
            this.DownBtn.TabIndex = 3;
            this.DownBtn.UseVisualStyleBackColor = true;
            // 
            // ReplacingBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 569);
            this.Controls.Add(this.DownBtn);
            this.Controls.Add(this.Upbtn);
            this.Controls.Add(this.listBoxRand);
            this.Controls.Add(this.listBoxSorted);
            this.Name = "ReplacingBooks";
            this.Text = "ReplacingBooks";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSorted;
        private System.Windows.Forms.ListBox listBoxRand;
        private System.Windows.Forms.Button Upbtn;
        private System.Windows.Forms.Button DownBtn;
    }
}