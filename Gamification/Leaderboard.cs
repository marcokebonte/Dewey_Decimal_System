using Dewey_Decimal_System_Library.Model;
using Dewey_Decimal_System_Library.Other;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Dewey_Decimal_System.Gamification
{
    public partial class Leaderboard : Form
    {
        public Leaderboard()
        {
            InitializeComponent();
        }


        #region Leaderboard Load
        private void frmLeaderboard_Load(object sender, EventArgs e)
        {
            // Check if the text file for Game1 exists
            string textFilePathGame1 = "SortingCallNos.txt";
            if (!File.Exists(textFilePathGame1))
            {
                // Create the text file for Game1
                File.Create(textFilePathGame1).Close();
            }

            // Check if the text file for Game2 exists
            string textFilePathGame2 = "IdentifyingAreas.txt";
            if (!File.Exists(textFilePathGame2))
            {
                // Create the text file for Game2
                File.Create(textFilePathGame2).Close();
            }

            // Check if the text file for Game3 exists
            string textFilePathGame3 = "TreeHighScores.txt";
            if (!File.Exists(textFilePathGame3))
            {
                // Create the text file for Game3
                File.Create(textFilePathGame3).Close();
            }

            Console.WriteLine(Univ.Game1);
            Console.WriteLine(Univ.Game2);
            Console.WriteLine(Univ.Game3);

            if (Univ.Game1)
            {
                // Clear the list view
                lvlLeaderboard.Items.Clear();

                // Retrieve data from the text file for Game1
                List<HighScoreModel> lstModelHighScore = ReadScoresFromTextFile(textFilePathGame1);

                // Populate list view for Game1
                PopulateListViewWithScores(lstModelHighScore);

                Univ.Game1 = false;
            }
            else if (Univ.Game2)
            {
                // Clear the list view
                lvlLeaderboard.Items.Clear();

                // Retrieve data from the text file for Game2
                List<HighScoreModel> lstModelHighScore = ReadScoresFromTextFile(textFilePathGame2);

                // Populate list view for Game2
                PopulateListViewWithScores(lstModelHighScore);

                Univ.Game2 = false;
            }
            else if (Univ.Game3)
            {
                // Clear the list view
                lvlLeaderboard.Items.Clear();

                // Retrieve data from the text file for Game3
                List<HighScoreModel> lstModelHighScore = ReadScoresFromTextFile(textFilePathGame3);

                // Populate list view for Game3
                PopulateListViewWithScores(lstModelHighScore);

                Univ.Game3 = false;
            }
        }
        #endregion




        #region Read Scores From Text File
        private List<HighScoreModel> ReadScoresFromTextFile(string filePath)
        {
            List<HighScoreModel> scores = new List<HighScoreModel>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(':');
                    if (parts.Length == 2 && int.TryParse(parts[1], out int score))
                    {
                        scores.Add(new HighScoreModel { Username = parts[0], Score = score });
                    }
                }
            }

            return scores;
        }
        #endregion




        #region Populate ListView with Scores
        private void PopulateListViewWithScores(List<HighScoreModel> scores)
        {
            scores.OrderByDescending(x => x.Score)
                .ToList()
                .ForEach(x => lvlLeaderboard.Items.Add(new ListViewItem(new string[] { x.Username, x.Score.ToString() })));
        }
        #endregion






    }







}
