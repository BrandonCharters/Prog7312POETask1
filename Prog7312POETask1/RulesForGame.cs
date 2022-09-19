using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog7312POETask1
{
    public partial class RulesForGame : Form
    {
        //This is just a form which displays the rules for the game when the button on the game page is pressed.

        public RulesForGame()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button click event, when pressed will exit the app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitRulesBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //*********************************************************ooo METHOD END ooo*********************************************************//
    }
    //*********************************************************ooo CLASS END ooo*********************************************************//
}
//*********************************************************ooo APP END ooo*********************************************************//
