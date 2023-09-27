using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Dewey_Decimal_System.Games
{
    public partial class ReplacingBooks : Form
    {




        //Declaring lists

        List<String> sortedList;
        List<String> shuffledList;
        List<String> userInputList;


        //Instantiating a timer object




        public bool gameBegin { get; set; } = false;



        #region Constructor
        public ReplacingBooks()
        {

            // display instructions to the user
            MessageBox.Show(null,
                " For this game you are going to SORT IN ASCENDING ORDER (Smallest to Biggest)\n" +
                "----------------------------------------------------------\n" +
                "To start the game, \n\n" +
                "1. Click on any Call number (eg. 222.97 JAM) \n" +
                "   and drag it over to the list box that's empty.\n\n" +
                "2. Once the first call number is entered, the timer will begin and\n" +
                "   the game will continue, until all the numbers have been moved.\n" +
                "   The the game will then come to an end.\n\n" +
                "Remember, you're working against the timer.\n\n" +
                "-----------------------------------------------------\n" +
                "GOODLUCK!", "Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);
            InitializeComponent();


        }
        #endregion



        #region Loading Call Numbers
        public void LoadCallNos()
        {

            //Clear the component
            listBoxRand.Items.Clear();


            //Shuffle the list and store
            ReplacingBooksLogic r = new ReplacingBooksLogic();
            sortedList = r.GenerateCallNos();
            shuffledList = r.ShuffleList(sortedList);

            //Populate the list
            foreach (var callNo in shuffledList)
            {
                listBoxRand.Items.Add(callNo);
            }

        }
        #endregion



        //#region Drag and Drop 
        //private void lstboxRandom_MouseDown(object sender, MouseEventArgs e)
        //{
        //    try
        //    {
        //        lstboxSorted.DoDragDrop(lstboxRandom.SelectedItem.ToString(), DragDropEffects.Copy);
        //    }
        //    catch (System.NullReferenceException ex)
        //    {
        //        MessageBox.Show("Please select a call number from the list");
        //        throw ex;
        //    }

        //    if (StartGame())
        //    {
        //        StartTimer();
        //        gameBegin = false;
        //    }

        //    if (EndGame())
        //    {
        //        // get the data of the users from the list box
        //        userList = lstboxSorted.Items.Cast<String>().ToList();

        //        bool isCorrectAnswer = userList.SequenceEqual(sortedList);

        //        if (isCorrectAnswer)
        //        {
        //            // save the score 
        //            Universal.Points = ScoreSystem.CalculateScore(Convert.ToInt32(timer.TimeLeft.Seconds));

        //            Universal.UpdateUserControl = true;

        //            // show user details and score
        //            ScoreAndDetails scoreAndDetails = new ScoreAndDetails("Congratulations! You Solved Correctly 👑 ");
        //            this.Hide();
        //            scoreAndDetails.Show();
        //        }
        //        else
        //        {
        //            // incorrect sorting
        //            Universal.Points = 0;
        //            Universal.BonusPoints = 0;

        //            Universal.UpdateUserControl = true;

        //            // show user details and score
        //            ScoreAndDetails scoreAndDetails = new ScoreAndDetails("Unlucky! You Solved Incorrectly 😢 ");
        //            this.Hide();
        //            scoreAndDetails.Show();

        //        }
        //    }
        //}

        //private void lstboxSorted_DragEnter(object sender, DragEventArgs e)
        //{
        //    if (e.Data.GetDataPresent(DataFormats.Text))
        //    {
        //        e.Effect = DragDropEffects.Copy;
        //    }
        //    else
        //    {
        //        e.Effect = DragDropEffects.None;
        //    }
        //}

        //private void lstboxSorted_DragDrop(object sender, DragEventArgs e)
        //{
        //    lstboxSorted.Items.Add(e.Data.GetData(DataFormats.Text));
        //    lstboxRandom.Items.Remove(e.Data.GetData(DataFormats.Text));

        //    // initialise game mode
        //    Global.Game1 = true;
        //    Global.Game2 = false;
        //    Global.Game3 = false;

        //}
        //#endregion







    }//End of partial class Replacing Books: Form
}//End of Namespace 
//------------------------------------------------------oooo0000End of File0000oooo-------------------------------------------------------------------------------
