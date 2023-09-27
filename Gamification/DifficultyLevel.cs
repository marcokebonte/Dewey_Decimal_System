using Dewey_Decimal_System.Games;
using Dewey_Decimal_System_Library.Other;
using System;
using System.Windows.Forms;

namespace Dewey_Decimal_System.Gamification
{
    public partial class DifficultyLevel : Form
    {
        public DifficultyLevel()
        {
            InitializeComponent();
        }


        private void DifficultyLevel_Load(object sender, EventArgs e)
        {
        }



        #region Form Close
        private void frmDifficultyLevel_FormClosed(object sender, FormClosedEventArgs e)
        {
            // navigate back to the homescreen
            this.Hide();
            Home home = new Home();
            home.Show();
        }
        #endregion


        #region Select Difficulty
        private void btnEasy_Click(object sender, EventArgs e)
        {
            // assign time and bonus points
            Univ.CountdownTime = 60;
            Univ.BonusPoints = 0;

            NavigateToGame();
        }

        private void btnMed_Click(object sender, EventArgs e)
        {
            // assign time and bonus points
            Univ.CountdownTime = 45;
            Univ.BonusPoints = 25;

            NavigateToGame();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            // assign time and bonus points
            Univ.CountdownTime = 30;
            Univ.BonusPoints = 50;

            NavigateToGame();
        }
        #endregion


        #region Game Navigation

        public void NavigateToGame()
        {
            if (Univ.Game1)
            {
                // Game 1
                ReplacingBooks replacingBooks = new ReplacingBooks();
                this.Hide();
                try
                {
                    replacingBooks.ShowDialog();
                }
                catch (System.NullReferenceException) { throw; }
            }
            else if (Univ.Game2)
            {
                // Game 2

            }
            else if (Univ.Game3)
            {
                // Game 3

            }
        }
        #endregion







    }
}
