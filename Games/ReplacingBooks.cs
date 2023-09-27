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



        public void LoadCallNos()
        {

            //Clear the component
            listBoxRand.Items.Clear();


            //Shuffle 
        }










    }//End of partial class Replacing Books: Form
}//End of Namespace 
//------------------------------------------------------oooo0000End of File0000oooo-------------------------------------------------------------------------------
