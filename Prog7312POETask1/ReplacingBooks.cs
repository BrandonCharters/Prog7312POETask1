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
    public partial class ReplacingBooks : Form
    {
        //This form is the main game page for the replacing books game.

        //This is the list where the dewey decimal value are being stored
        public static List<string> _deweyDecimalList = new List<string>();
        //This is the variable for the timer of the game
        private int _timerValue;

        /// <summary>
        /// This is the main class of the form
        /// Both listBoxes are given the ability to allow for the dropping function
        /// </summary>
        public ReplacingBooks()
        {
            InitializeComponent();
            this.listBox1.AllowDrop = true;
            this.listBox2.AllowDrop = true;
        }
        //*********************************************************ooo CLASS END ooo*********************************************************//
        
        /// <summary>
        /// A button click event which populates the first listBox with the 10 dewey decimal numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateNumbersBtn_Click(object sender, EventArgs e)
        {
            //An if statement that checks that one of the difficulty buttons have been checked.
            //If not then the user will be displayed a message and will not be able to play until one is selected.
            if (!easyBtn.Checked && !mediumBtn.Checked && !hardBtn.Checked)
            {
                MessageBox.Show("Make sure a difficulty is selected!", "--CHECK AGAIN!!--", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //A set of if statements that check which one of the difficulty buttons are checked such as:
            //  If the easy is checked then the timer will be set to 30.
            //  If the medium is checked then the timer will be set to 20.
            //  If the hard is checked then the timer will be set to 15.
            if (easyBtn.Checked) _timerValue = 30;
            if (mediumBtn.Checked) _timerValue = 20;
            if (hardBtn.Checked) _timerValue = 15;
            //Game timer will start after
            gameTimer.Start();

            //The difficulty choices will vanish when the user is playing.
            difficultPanel.Visible = false;

            //This if statement just checks if the deweyDecimalList has data which has been populated.
            //This is done so that the list cant be populated again if their is already existing data.
            if (_deweyDecimalList.Any()) return;

            //This is allowing the callNumbers from the other class to be gotten on this form.
            NumberGeneration NG = new NumberGeneration();

            //A try catch to make sure that if the app fails to get the dewey decimal values from the other class then an exception will be thrown.
            try
            {
                //A for loop to populate the listBox1 with 10 randomly generated deweyDecimalNumbers.
                //And then stored in the _deweyDecimalList.
                for (int i = 0; i < 10; i++)
                {
                    _deweyDecimalList.Add(NG.generates_call_numbers());
                }

                listBox1.Items.AddRange(_deweyDecimalList.ToArray());
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
        //*********************************************************ooo METHOD END ooo*********************************************************//
        
        /// <summary>
        /// A button click event to check that the order of the books in listBox2 are in the correct order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckOrderBtn_Click(object sender, EventArgs e)
        {
            //A variable called items which are the items that are currently present on the listBox2.
            //A variable called sortedItems which are the items in listBox2 but ordered in ascending order.
            //A variable called matches which is checking if the items and the sortedItems are matching
            var items = listBox2.Items.Cast<string>().ToList();
            var sortedItems = listBox2.Items.Cast<string>().OrderBy(x => x).ToList();
            var matches = true;

            //This if statement checks if all of the books are dragged over.
            //If not them it will display a message to the user.
            if (items.Count != 10)
            {
                MessageBox.Show("Not all of the books have been dragged over!!", "--CHECK AGAIN!!--", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Stops the games timer
            gameTimer.Stop();

            //A for loop which runs through all of the items that are in listBox2
            for (int i = 0; i < items.Count; i++)
            {
                //An if statement which compared the items which are currently in the listBox2 with the items but ordered in ascending order
                if (!items[i].Equals(sortedItems[i], StringComparison.OrdinalIgnoreCase))
                {
                    matches = false;
                    break;
                }
            }

            //If the 2 variables match then a message will be displayed congratulating the user
            //Else a message saying Oh No.
            if (matches)
                MessageBox.Show("Well done!! All of the books were in the correct order!" +
                                "\nMaybe try make it harder by trying a higher difficulty.", "--CONGRATULATIONS!!--", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
                MessageBox.Show("Oh no!! You did not put all of the books in the correct order :(" +
                                "\nDon't let this discourage you from trying again!", "--OH NO!!--", MessageBoxButtons.OK, MessageBoxIcon.Information);

            gameTimer.Stop();
            timerLbl.Text = "";
            difficultPanel.Visible = true;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            _deweyDecimalList.Clear();
            return;
        }
        //*********************************************************ooo METHOD END ooo*********************************************************//

        /// <summary>
        /// A mouseDown event which is checking if a book has been selected, and if not then it will display a message saying so.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                //If statement which checks if an item has not been selected
                if (listBox1?.SelectedItem == null)
                {
                    MessageBox.Show("No book has been selected!", "--CHECK AGAIN!!--", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //Allowing the user to drag the item
                listBox2.DoDragDrop(listBox1.SelectedItem.ToString(), DragDropEffects.Copy);
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occured!", "--OOPS!!--", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //*********************************************************ooo METHOD END ooo*********************************************************//

        /// <summary>
        /// DragEvent which allows the dragged item from listBox1 to be dragged over to listBox2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        //*********************************************************ooo METHOD END ooo*********************************************************//

        /// <summary>
        /// DragDrop event which allows the book to be dropped into listBox2 and removed from listBox1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            listBox2.Items.Add(e.Data.GetData(DataFormats.Text));
            listBox1.Items.Remove(e.Data.GetData(DataFormats.Text));
        }
        //*********************************************************ooo METHOD END ooo*********************************************************//

        /// <summary>
        /// ButtonClick to display the rules to the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewRulesBtn_Click(object sender, EventArgs e)
        {
            RulesForGame gameRules = new RulesForGame();
            gameRules.Show();
        }
        //*********************************************************ooo METHOD END ooo*********************************************************//

        /// <summary>
        /// ButtonClick to exit the app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitAppBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //*********************************************************ooo METHOD END ooo*********************************************************//

        /// <summary>
        /// ButtonClick to go back to the home page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backBtn_Click(object sender, EventArgs e)
        {
            Form1 backForm1 = new Form1();
            this.Hide();
            backForm1.Show();
        }
        //*********************************************************ooo METHOD END ooo*********************************************************//

        /// <summary>
        /// ButtonClick to restart the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void restartGamebtn_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();
            timerLbl.Text = "";
            difficultPanel.Visible = true;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            _deweyDecimalList.Clear();
        }
        //*********************************************************ooo METHOD END ooo*********************************************************//

        /// <summary>
        /// TimerTicker for the game timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //Makes the lbl of the timer be displayed to the user
            timerLbl.Visible = true;
            //Sets the lbl to whatever the difficulty was chosen
            timerLbl.Text = _timerValue--.ToString();
            //If statement for when the timer value reaches 0.
            //The timer will stop and the user will be given the choice to either play again or exit the app.
            if (_timerValue < 0)
            {
                gameTimer.Stop();
                DialogResult result = MessageBox.Show("Oh no!! You have run out of time!" +
                                                      "\nWould you like to try again?", "--TIMES UP!!--", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    difficultPanel.Visible = true;
                    listBox1.Items.Clear();
                    listBox2.Items.Clear();
                    _deweyDecimalList.Clear();
                }
                else if (result == DialogResult.No)
                {
                    Application.Exit();
                }
            }
        }
        //*********************************************************ooo METHOD END ooo*********************************************************//
    }
    //*********************************************************ooo CLASS END ooo*********************************************************//
}
//*********************************************************ooo APP END ooo*********************************************************//