using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog7312POETask1.Classes
{
    public class BookTreeModel
    {
        //******************************************************************************************************************//
        /// <summary>
        /// Tree structure being created
        /// </summary>
        public BookTreeModel()
        {
            Category = String.Empty;
            Children = new List<BookTreeModel>();
        }
        public int Index { get; set; }
        public String Category { get; set; }
        public List<BookTreeModel> Children { get; set; }
    }
    //*********************************************************ooo CLASS END ooo*********************************************************//
}
//*********************************************************ooo APP END ooo*********************************************************//
