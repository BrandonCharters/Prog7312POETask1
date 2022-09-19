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
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void IdentifyingAreasBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon...");
        }

        private void FindingCallNumbersBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon...");
        }

        private void ReplacingBooksBtn_Click(object sender, EventArgs e)
        {
            ReplacingBooks replacingBooks = new ReplacingBooks();
            this.Hide();
            replacingBooks.Show();
        }

        private void exitAppBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Im wanting to make it so when the books are generated they are generated in a "pile",
        //The books are then dragged from the pile onto the shelf in the correct order which is required.
    }
}
