using Dewey_Decimal_System.Games;
using Dewey_Decimal_System_Library.Model;
using Dewey_Decimal_System_Library.Other;
using System;
using System.IO;
using System.Windows.Forms;

namespace Dewey_Decimal_System.Gamification
{
    public partial class Scores : Form
    {



        #region Constructor
        public Scores(string info)
        {
            InitializeComponent();


            lblUserMessage.Text = info;
        }
        #endregion



        #region Form Load
        private void ScoreAndDetails_Load(object sender, EventArgs e)
        {
            RefreshUI();

            if (Univ.UpdateUserControl)
            {
                // update ui values
                textBoxYS.Text = Univ.Points.ToString();
                textBoxBP.Text = Univ.BonusPoints.ToString();
                textBoxTotalScore.Text = (Univ.BonusPoints + Univ.Points).ToString();

            }
        }
        #endregion




        #region Refresh UI
        public void RefreshUI()
        {
            // clear componenets
            textBoxUsername.Clear();
            textBoxYS.Clear();
            textBoxTotalScore.Clear();
            textBoxBP.Clear();
        }
        #endregion



        #region Play Again 
        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            if (Univ.Game1)
            {
                // Game 1
                ReplacingBooks sortingCall = new ReplacingBooks();
                this.Hide();
                sortingCall.ShowDialog();

            }
            else if (Univ.Game2)
            {

                //Game 2

            }
            else if (Univ.Game3)
            {

                //Game 3
            }

        }

        #endregion





        #region Save Score
        private void btnSaveScore_Click(object sender, EventArgs e)
        {
            // Error handling
            if (string.IsNullOrEmpty(textBoxUsername.Text))
            {
                MessageBox.Show("Please enter a valid name", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Instantiate high score model 
                HighScoreModel modelHighScore = new HighScoreModel();

                // Score
                modelHighScore.Score = Univ.Points + Univ.BonusPoints;

                Univ.Username = textBoxUsername.Text;

                modelHighScore.Username = Univ.Username;

                if (Univ.Game1)
                {
                    // Game 1
                    string textFilePath = "SortingCallNos.txt";

                    // Check if the text file exists
                    if (!File.Exists(textFilePath))
                    {
                        // Create the text file
                        File.Create(textFilePath).Close();

                        // Write data to the file
                        using (StreamWriter writer = new StreamWriter(textFilePath))
                        {
                            writer.WriteLine($"{modelHighScore.Username}:{modelHighScore.Score}");
                        }
                    }
                    else
                    {
                        // Write to the text file
                        using (StreamWriter writer = File.AppendText(textFilePath))
                        {
                            writer.WriteLine($"{modelHighScore.Username}:{modelHighScore.Score}");
                        }
                    }
                }
                else if (Univ.Game2)
                {
                    Univ.countAlt = Univ.countAlt + 1;
                    string textFilePath = "IdentifyingAreas.txt";

                    // Game 2
                    // Check if the text file exists
                    if (!File.Exists(textFilePath))
                    {
                        // Create the text file
                        File.Create(textFilePath).Close();

                        // Write data to the file
                        using (StreamWriter writer = new StreamWriter(textFilePath))
                        {
                            writer.WriteLine($"{modelHighScore.Username}:{modelHighScore.Score}");
                        }
                    }
                    else
                    {
                        // Write to the text file
                        using (StreamWriter writer = File.AppendText(textFilePath))
                        {
                            writer.WriteLine($"{modelHighScore.Username}:{modelHighScore.Score}");
                        }
                    }
                }
                else if (Univ.Game3)
                {
                    string textFilePath = "TreeHighScores.txt";

                    // Game 3
                    // Check if the text file exists
                    if (!File.Exists(textFilePath))
                    {
                        // Create the text file
                        File.Create(textFilePath).Close();

                        // Write data to the file
                        using (StreamWriter writer = new StreamWriter(textFilePath))
                        {
                            writer.WriteLine($"{modelHighScore.Username}:{modelHighScore.Score}");
                        }
                    }
                    else
                    {
                        // Write to the text file
                        using (StreamWriter writer = File.AppendText(textFilePath))
                        {
                            writer.WriteLine($"{modelHighScore.Username}:{modelHighScore.Score}");
                        }
                    }
                }

                // Message to the user
                MessageBox.Show($"{textBoxUsername.Text} score of : {textBoxTotalScore.Text} has been saved successfully", "Score Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Navigate back to the home screen
                RefreshUI();

                // Back to home page
                Home home = new Home();
                this.Hide();
                home.Show();
            }

        }
        #endregion





        #region Form Close Method
        private void ScoreAndDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            // navigate back to the homescreen
            this.Hide();
            Home home = new Home();
            home.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        #endregion



    }




}



