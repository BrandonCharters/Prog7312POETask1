using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Collections;
using System.Xml;
using System.Security.Cryptography;
using Prog7312POETask1.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Prog7312POETask1
{
    public partial class IdentifyingAreas : Form
    {
        //******************************************************************************************************************//
        //List of created variables
        private static IdAreasQuestionGen questionGen = new IdAreasQuestionGen();

        //For drawing
        private Graphics g;
        private int x = -1;
        private int y = -1;
        private bool moving = false;
        private Pen pen;

        //For populating the lbls
        private string leftClickAns;
        private string rightClickAns;
        private string leftLblName;

        //For choosing the game, and score
        private int num;
        private int currentScore = 0;

        //For invisible radius around the lbls
        private int difference;

        //Lists of left and right Q&A boxes
        private List<Label> leftTextBoxes = new List<Label>();
        private List<Label> rightTextBoxes = new List<Label>();

        //Lists for the left and the right lbls
        private List<Label> leftLabels = new List<Label>();
        private List<Label> rightLabels = new List<Label>();

        //******************************************************************************************************************//
        /// <summary>
        /// Main class which has code for the drawing of the line.
        /// </summary>
        public IdentifyingAreas()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            pen = new Pen(Color.Black, 4);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        //******************************************************************************************************************//
        /// <summary>
        /// A method for adding the Left lbls to the lists
        /// </summary>
        public void addingLeftTextBoxes()
        {
            leftTextBoxes.Add(leftLbl1);
            leftTextBoxes.Add(leftLbl2);
            leftTextBoxes.Add(leftLbl3);
            leftTextBoxes.Add(leftLbl4);

            leftLabels.Add(left1);
            leftLabels.Add(left2);
            leftLabels.Add(left3);
            leftLabels.Add(left4);
        }

        //******************************************************************************************************************//
        /// <summary>
        /// A method for adding the right lbls to the lists
        /// </summary>
        public void addingRightTextBoxes()
        {
            rightTextBoxes.Add(rightLbl1);
            rightTextBoxes.Add(rightLbl2);
            rightTextBoxes.Add(rightLbl3);
            rightTextBoxes.Add(rightLbl4);
            rightTextBoxes.Add(rightLbl5);
            rightTextBoxes.Add(rightLbl6);
            rightTextBoxes.Add(rightLbl7);

            rightLabels.Add(right1);
            rightLabels.Add(right2);
            rightLabels.Add(right3);
            rightLabels.Add(right4);
        }

        //******************************************************************************************************************//        
        /// <summary>
        /// A mouseDown event for the start of the drawing line to take place.
        /// Checks which lbl the mouse is closest too when pressed down.
        /// Populates the leftLbls with the chosen questions.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;

            try
            {
                foreach (var textBox in leftTextBoxes)
                {
                    bool success = false;
                    int x1 = Convert.ToInt32(textBox.Location.X + textBox.Width);
                    int x2 = Convert.ToInt32(e.Location.X);
                    int y1 = Convert.ToInt32(textBox.Location.Y);
                    int y2 = Convert.ToInt32(e.Location.Y);
                    int dx = x1 - x2;
                    int dy = y1 - y2;

                    difference = (dx * dx + dy * dy);

                    if (difference < 60 * 60)
                    {
                        success = true;
                        leftClickAns = textBox.Text;

                        switch (textBox.Name)
                        {
                            case "leftLbl1":
                                left1.Text = leftClickAns;
                                leftLblName = "leftLbl1";
                                break;

                            case "leftLbl2":
                                left2.Text = leftClickAns;
                                leftLblName = "leftLbl2";
                                break;

                            case "leftLbl3":
                                left3.Text = leftClickAns;
                                leftLblName = "leftLbl3";
                                break;

                            case "leftLbl4":
                                left4.Text = leftClickAns;
                                leftLblName = "leftLbl4";
                                break;
                        }

                        break;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                throw;
            }
        }

        //******************************************************************************************************************//
        /// <summary>
        /// Mouse move event for the drawing of the line to take place.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving && x != -1 && y != -1)
            {
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }

        //******************************************************************************************************************//
        /// <summary>
        /// MouseUp event for the end of the drawing line to take place.
        /// Checks which lbl the mouse is closest too when released.
        /// Populates the rightLbls with the answers.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;

            try
            {
                foreach (var textBox in rightTextBoxes)
                {
                    bool success = false;
                    int x1 = Convert.ToInt32(textBox.Location.X - 10);
                    int x2 = Convert.ToInt32(e.Location.X);
                    int y1 = Convert.ToInt32(textBox.Location.Y);
                    int y2 = Convert.ToInt32(e.Location.Y);
                    int dx = x1 - x2;
                    int dy = y1 - y2;

                    difference = (dx * dx + dy * dy);

                    if (difference < 40 * 40)
                    {
                        success = true;
                        rightClickAns = textBox.Text;

                        switch (leftLblName)
                        {
                            case "leftLbl1":
                                right1.Text = rightClickAns;
                                break;

                            case "leftLbl2":
                                right2.Text = rightClickAns;
                                break;

                            case "leftLbl3":
                                right3.Text = rightClickAns;
                                break;

                            case "leftLbl4":
                                right4.Text = rightClickAns;
                                break;
                        }

                        break;
                    }
                }

                panel1.Invalidate(); //Clears the line after drawing
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                throw;
            }
        }

        //******************************************************************************************************************//
        /// <summary>
        /// Btn to exit the app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitAppBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //******************************************************************************************************************//
        /// <summary>
        /// Btn to go back to the game select screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 backForm1 = new Form1();
                this.Hide();
                backForm1.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                throw;
            }
        }

        //******************************************************************************************************************//
        /// <summary>
        /// Btn to display the rules of the game to the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewRulesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                IdAreaGameRules gameRules = new IdAreaGameRules();
                gameRules.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                throw;
            }
        }

        //******************************************************************************************************************//        
        /// <summary>
        /// Btn to populate the left and the right lbls with the call numbers and their descriptions.
        /// First checks if the panel is active, if it is then the button will be disabled.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateNumbersBtn_Click(object sender, EventArgs e)
        {
            clearLbls();
            if (panel1.Enabled == true)
            {
                MessageBox.Show("A game is currently active, can't start new game!");
            }
            else
            {
                loadGame();
            }
            
        }

        //******************************************************************************************************************//
        /// <summary>
        /// Method which has the layout for when the descriptions will be populated on the rightside and the callnumbers on the left.
        /// Once the right values are generated then the keys of those values will be randomized and populated into the left side.
        /// </summary>
        public void layout1()
        {
            Random rand = new Random();

            var valueSet = questionGen.DeweyDecimalsDictionary.Values;


            List<string> lblLstR = new List<string>();
            List<string> lblLstL = new List<string>();

            foreach (var lbl in rightTextBoxes)
            {
                int r = rand.Next(valueSet.Count);
                string key = (string)valueSet.ElementAt(r);

                if (!lblLstR.Contains(valueSet.ElementAt(r)))
                {
                    lbl.Text = (string)valueSet.ElementAt(r);
                    lblLstR.Add(lbl.Text);
                }
                else
                {
                    while (lblLstR.Contains(valueSet.ElementAt(r)))
                    {
                        r = rand.Next(valueSet.Count);
                    }

                    lbl.Text = (string)valueSet.ElementAt(r);
                    lblLstR.Add(lbl.Text);
                }
            }

            //Create a keySet of all the values on the right side
            var keySet = questionGen.DeweyDecimalsDictionary
                .Where(x => lblLstR
                    .Contains(x.Value))
                .Select(x => x.Key)
                .ToList();

            foreach (var lbl in leftTextBoxes)
            {
                int r = rand.Next(keySet.Count);
                string key = (string)keySet.ElementAt(r);


                if (!lblLstL.Contains(key))
                {
                    lbl.Text = key;
                    lblLstL.Add(lbl.Text);
                }
                else
                {
                    while (lblLstL.Contains(key))
                    {
                        r = rand.Next(keySet.Count);
                        key = (string)keySet.ElementAt(r);
                    }

                    lbl.Text = key;
                    lblLstL.Add(lbl.Text);
                }
            }
        }

        //******************************************************************************************************************//
        /// <summary>
        /// Method which has the layout for when the callnumbers will be populated on the rightside and the descriptions on the left.
        /// Once the right values are generated then the keys of those values will be randomized and populated into the left side. 
        /// </summary>
        public void layout2()
        {
            Random rand = new Random();

            var keySet = questionGen.DeweyDecimalsDictionary.Keys;

            List<string> lblLstR = new List<string>();
            List<string> lblLstL = new List<string>();

            foreach (var lbl in rightTextBoxes)
            {
                //Populate the right text boxes with the keys from the dictionary
                int r = rand.Next(keySet.Count);
                string key = (string)keySet.ElementAt(r);

                if (!lblLstR.Contains(key))
                {
                    lbl.Text = key;
                    lblLstR.Add(lbl.Text);
                }
                else
                {
                    while (lblLstR.Contains(key))
                    {
                        r = rand.Next(keySet.Count);
                        key = (string)keySet.ElementAt(r);
                    }

                    lbl.Text = key;
                    lblLstR.Add(lbl.Text);
                }
            }

            //Create a valueSet of all the values on the right side
            var valueSet = questionGen.DeweyDecimalsDictionary
                .Where(x => lblLstR
                    .Contains(x.Key))
                .Select(x => x.Value)
                .ToList();

            foreach (var lbl in leftTextBoxes)
            {
                //Populate the left text boxes with the values of the keys from the right side
                int r = rand.Next(valueSet.Count);
                string key = (string)valueSet.ElementAt(r);

                if (!lblLstL.Contains(valueSet.ElementAt(r)))
                {
                    lbl.Text = (string)valueSet.ElementAt(r);
                    lblLstL.Add(lbl.Text);
                }
                else
                {
                    while (lblLstL.Contains(valueSet.ElementAt(r)))
                    {
                        r = rand.Next(valueSet.Count);
                    }

                    lbl.Text = (string)valueSet.ElementAt(r);
                    lblLstL.Add(lbl.Text);
                }
            }
        }

        //******************************************************************************************************************//
        /// <summary>
        /// Btn to restart the game
        /// This will display the final score to the user aswell
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void restartGamebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (panel1.Enabled == true)
                {
                    MessageBox.Show($"Thanks for playing!!" +
                                    $"\nYour final score was: {currentScore}", "--OH NO!!--", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No game active, cannot restart!", "--OOPS!!--", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                
                panel1.Enabled = false;
                clearBoxes();
                currentScore = 0;
                currentScoreLbl.Text = currentScore.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                throw;
            }
        }

        //******************************************************************************************************************//
        /// <summary>
        /// On page load the boxes will be cleared and the lbls will be added to their lists
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IdentifyingAreas_Load(object sender, EventArgs e)
        {
            try
            {
                clearBoxes();
                addingLeftTextBoxes();
                addingRightTextBoxes();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                throw;
            }
        }

        //******************************************************************************************************************//
        /// <summary>
        /// Btn click for when the user wants to check their answers and play the next round.
        /// Cannot press this button if the game is not active.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void doneBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (leftLbl1.Text == "Question 1")
                {
                    MessageBox.Show("No game active, cannot go to next!", "--OOPS!!--", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    clearLbls();
                }
                else
                {
                    validateAnswers();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                throw;
            }
        }

        //******************************************************************************************************************//
        /// <summary>
        /// Method to reset the lbls to their initial state
        /// </summary>
        public void clearBoxes()
        {
            //Reset all the question labels texts to be question1 - question4
            leftLbl1.Text = "Question 1";
            leftLbl2.Text = "Question 2";
            leftLbl3.Text = "Question 3";
            leftLbl4.Text = "Question 4";

            //Reset all the answer labels texts to be answer1 - answer7
            rightLbl1.Text = "Answer 1";
            rightLbl2.Text = "Answer 2";
            rightLbl3.Text = "Answer 3";
            rightLbl4.Text = "Answer 4";
            rightLbl5.Text = "Answer 5";
            rightLbl6.Text = "Answer 6";
            rightLbl7.Text = "Answer 7";

            //Reset all the left labels texts to be empty
            left1.Text = "";
            left2.Text = "";
            left3.Text = "";
            left4.Text = "";

            //Reset all the right labels texts to be empty
            right1.Text = "";
            right2.Text = "";
            right3.Text = "";
            right4.Text = "";
        }

        //******************************************************************************************************************//
        /// <summary>
        /// Method to reset the lbls to their initial state
        /// </summary>
        public void clearLbls()
        {
            //Reset all the left labels texts to be empty
            left1.Text = "";
            left2.Text = "";
            left3.Text = "";
            left4.Text = "";

            //Reset all the right labels texts to be empty
            right1.Text = "";
            right2.Text = "";
            right3.Text = "";
            right4.Text = "";
        }

        //******************************************************************************************************************//
        /// <summary>
        /// Validate the answers that are in the left and the right lbls and check if they are a correct value pair.
        /// </summary>
        public void validateAnswers()
        {
            var dict = questionGen.DeweyDecimalsDictionary;

            try
            {
                //Check if the left labels are empty
                if (left1.Text == "" || left2.Text == "" || left3.Text == "" || left4.Text == "")
                    MessageBox.Show("Please fill in all the questions!", "--TRY AGAIN!!--", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                //Check if the right labels are empty
                else if (right1.Text == "" || right2.Text == "" || right3.Text == "" || right4.Text == "")
                    MessageBox.Show("Please fill in all the answers!", "--TRY AGAIN!!--", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                else
                {
                    if (num % 2 == 0)
                    {
                        //Check if the keyValue pair is correct
                        if (dict[left1.Text] == right1.Text
                            && dict[left2.Text] == right2.Text
                            && dict[left3.Text] == right3.Text
                            && dict[left4.Text] == right4.Text)
                        {
                            currentScore += 100;
                            currentScoreLbl.Text = currentScore.ToString();
                            MessageBox.Show("Well done!! All the answers were correct!", "--CONGRATULATIONS!!--",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            currentScore -= 50;
                            currentScoreLbl.Text = currentScore.ToString();
                            MessageBox.Show("Not all of the answers were correct!", "--TRY AGAIN!!--",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }

                        clearLbls();
                        loadGame();
                    }
                    else
                    {
                        //Check if the keyValue pair is correct
                        if (dict[right1.Text] == left1.Text
                            && dict[right2.Text] == left2.Text
                            && dict[right3.Text] == left3.Text
                            && dict[right4.Text] == left4.Text)
                        {
                            currentScore += 100;
                            currentScoreLbl.Text = currentScore.ToString();
                            MessageBox.Show("Well done!! All the answers were correct!", "--CONGRATULATIONS!!--",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            currentScore -= 50;
                            currentScoreLbl.Text = currentScore.ToString();
                            MessageBox.Show("Not all of the answers were correct!", "--TRY AGAIN!!--",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }

                        clearLbls();
                        loadGame();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }

        //******************************************************************************************************************//
        /// <summary>
        /// Method to load the game, this will generate a number between 1-10 and if the number is even then the game will populate with layout1, else layout2
        /// </summary>
        public void loadGame()
        {
            try
            {
                panel1.Enabled = true;

                Random rnd = new Random();

                num = rnd.Next(1, 10);

                if (num % 2 == 0)
                {
                    layout1();
                }
                else
                {
                    layout2();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }
    }
    //*********************************************************ooo CLASS END ooo*********************************************************//
}
//*********************************************************ooo APP END ooo*********************************************************//