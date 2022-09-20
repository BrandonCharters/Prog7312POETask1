using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Prog7312POETask1
{
    public partial class Form1 : Form
    {
        //This form will act as the home page of the application.
        //This is where the user selects what game they want ot play.

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button click events for both of the other games which will be changed for the other POE tasks.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IdentifyingAreasBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon...", "---UNDER CONSTRUCTION---", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void FindingCallNumbersBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon...", "---UNDER CONSTRUCTION---", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        //*********************************************************ooo METHOD END ooo*********************************************************//

        /// <summary>
        /// Button click event in order to take the user to the replacing books game page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReplacingBooksBtn_Click(object sender, EventArgs e)
        {
            ReplacingBooks replacingBooks = new ReplacingBooks();
            this.Hide();
            replacingBooks.Show();
        }
        //*********************************************************ooo METHOD END ooo*********************************************************//

        /// <summary>
        /// Button click event to exit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitAppBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //*********************************************************ooo METHOD END ooo*********************************************************//

        /// <summary>
        /// FormLoad event for when the form loads then theme music will play in the background of the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //Declaring a variable named sndPlay which is equal to a sample song which has been embedded into the app.
                SoundPlayer sndPlay = new SoundPlayer(Prog7312POETask1.Properties.Resources.SampleMusic);
                //Plays the sound when the form loads, loops the sound
                sndPlay.PlayLooping();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ": " + ex.StackTrace.ToString(), "Error");
            }
        }
        //*********************************************************ooo METHOD END ooo*********************************************************//
    }
    //*********************************************************ooo CLASS END ooo*********************************************************//
}
//*********************************************************ooo APP END ooo*********************************************************//