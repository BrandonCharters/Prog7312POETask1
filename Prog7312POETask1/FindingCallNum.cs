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
    public partial class FindingCallNum : Form
    {
        public FindingCallNum()
        {
            InitializeComponent();
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

        private void viewRulesBtn_Click(object sender, EventArgs e)
        {
            CallNumGameRules gameRules = new CallNumGameRules();
            gameRules.Show();
        }
    }
}
