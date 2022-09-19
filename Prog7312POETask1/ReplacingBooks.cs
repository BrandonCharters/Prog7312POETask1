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
        public static List<string> _deweyDecimalList = new List<string>();
        private int _timerValue;

        public ReplacingBooks()
        {
            InitializeComponent();
            this.listBox1.AllowDrop = true;
            this.listBox2.AllowDrop = true;
        }

        private void GenerateNumbersBtn_Click(object sender, EventArgs e)
        {
            if (!easyBtn.Checked && !mediumBtn.Checked && !hardBtn.Checked)
            {
                MessageBox.Show("Make sure a difficulty is selected!");
                return;
            }


            
            if (easyBtn.Checked) _timerValue = 30;
            if (mediumBtn.Checked) _timerValue = 20;
            if (hardBtn.Checked) _timerValue = 15;
            gameTimer.Start();












            difficultPanel.Visible = false;
            if (_deweyDecimalList.Any()) return;

            NumberGeneration NG = new NumberGeneration();

            try
            {
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

        private void CheckOrderBtn_Click(object sender, EventArgs e)
        {
            var items = listBox2.Items.Cast<string>().ToList();
            var sortedItems = listBox2.Items.Cast<string>().OrderBy(x => x).ToList();
            var matches = true;
            gameTimer.Stop();

            for (int i = 0; i < items.Count; i++)
            {
                if (!items[i].Equals(sortedItems[i], StringComparison.OrdinalIgnoreCase))
                {
                    matches = false;
                    break;
                }
            }

            if (matches)
                MessageBox.Show("You have put all of the books in the correct order!", "WELL DONE!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("You did not put the books in the correct order!", "TRY AGAIN!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            timerLbl.Text = "";
            listBox2.Items.Clear();
            return;

        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (listBox1?.SelectedItem == null)
                {
                    MessageBox.Show("No item has been selected!");
                    return;
                }
                listBox2.DoDragDrop(listBox1.SelectedItem.ToString(), DragDropEffects.Copy);
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occured!");
            }
            
        }

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

        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            listBox2.Items.Add(e.Data.GetData(DataFormats.Text));
            listBox1.Items.Remove(e.Data.GetData(DataFormats.Text));
        }

        private void viewRulesBtn_Click(object sender, EventArgs e)
        {
            RulesForGame gameRules = new RulesForGame();
            gameRules.Show();
        }

        private void exitAppBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Form1 backForm1 = new Form1();
            this.Hide();
            backForm1.Show();
        }

        private void restartGamebtn_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();
            timerLbl.Text = "";
            difficultPanel.Visible = true;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            _deweyDecimalList.Clear();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            timerLbl.Visible = true;
            timerLbl.Text = _timerValue--.ToString();
            if (_timerValue < 0)
            {
                gameTimer.Stop();
                DialogResult result = MessageBox.Show("Oh no!! You have run out of time! Would you like to try again?", "TIMES UP!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
    }
}
