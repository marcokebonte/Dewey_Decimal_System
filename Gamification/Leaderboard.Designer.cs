namespace Dewey_Decimal_System.Gamification
{
    partial class Leaderboard
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
            this.lvlLeaderboard = new System.Windows.Forms.ListView();
            this.usernameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ScoreHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvlLeaderboard
            // 
            this.lvlLeaderboard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.usernameHeader,
            this.ScoreHeader});
            this.lvlLeaderboard.HideSelection = false;
            this.lvlLeaderboard.Location = new System.Drawing.Point(135, 53);
            this.lvlLeaderboard.Name = "lvlLeaderboard";
            this.lvlLeaderboard.Size = new System.Drawing.Size(654, 377);
            this.lvlLeaderboard.TabIndex = 0;
            this.lvlLeaderboard.UseCompatibleStateImageBehavior = false;
            // 
            // usernameHeader
            // 
            this.usernameHeader.Text = "Username";
            // 
            // ScoreHeader
            // 
            this.ScoreHeader.Text = "Score";
            // 
            // Leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dewey_Decimal_System.Properties.Resources.Butterfly_lifespan;
            this.ClientSize = new System.Drawing.Size(969, 453);
            this.Controls.Add(this.lvlLeaderboard);
            this.Name = "Leaderboard";
            this.Text = "Leaderboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvlLeaderboard;
        private System.Windows.Forms.ColumnHeader usernameHeader;
        private System.Windows.Forms.ColumnHeader ScoreHeader;
    }
}