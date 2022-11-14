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

        //Declaring a variable named sndPlay which is equal to a sample song which has been embedded into the app.
        private SoundPlayer sndPlay = new SoundPlayer(Prog7312POETask1.Properties.Resources.SampleMusic);
        
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
            IdentifyingAreas identifyingAreas = new IdentifyingAreas();
            this.Hide();
            identifyingAreas.Show();
        }

        private void FindingCallNumbersBtn_Click(object sender, EventArgs e)
        {
            FindingCallNum findingNum = new FindingCallNum();
            this.Hide();
            findingNum.Show();
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

        private void musicBtn_Click(object sender, EventArgs e)
        {
            sndPlay.PlayLooping();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sndPlay.Stop();
        }
        //*********************************************************ooo METHOD END ooo*********************************************************//
    }
    //*********************************************************ooo CLASS END ooo*********************************************************//
}
//*********************************************************ooo APP END ooo*********************************************************//