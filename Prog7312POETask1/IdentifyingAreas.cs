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
        private static IdAreasQuestionGen questionGen = new IdAreasQuestionGen();

        private Graphics g;
        private int x = -1;
        private int y = -1;
        private bool moving = false;
        private Pen pen;

        private string leftClickAns;
        private string rightClickAns;
        private string leftLblName;

        private int num;
        private int currentScore = 0;


        private int difference;

        private List<Label> leftTextBoxes = new List<Label>();
        private List<Label> rightTextBoxes = new List<Label>();

        private List<Label> leftLabels = new List<Label>();
        private List<Label> rightLabels = new List<Label>();


        public IdentifyingAreas()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            pen = new Pen(Color.Black, 4);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

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

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving && x != -1 && y != -1)
            {
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }

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

                panel1.Invalidate();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                throw;
            }
        }

        private void exitAppBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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

        private void GenerateNumbersBtn_Click(object sender, EventArgs e)
        {
            loadGame();
        }

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

        private void restartGamebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentScore > 0)
                {
                    MessageBox.Show($"Well done!! Thanks for playing!!" +
                                    $"\nYour final score was: {currentScore}", "--WELL DONE!!--", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
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

        private void doneBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (leftLbl1.Text == "Question 1")
                {
                    MessageBox.Show("No game active, cannot restart!", "--OOPS!!--", MessageBoxButtons.OK,
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
                        //panel1.Enabled = false;
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
                        //panel1.Enabled = false;
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
}