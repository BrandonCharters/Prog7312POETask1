using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog7312POETask1.Classes
{
    public class IdAreasQuestionGen
    {
        //dictionary to store the callnumbers and their description
        private Dictionary<string, string> deweyDecimalsDictionary = new Dictionary<string, string>();

        //----------------------------------------------------------------------------------
        ///constructor to add call numbers and their descriptions to the dictionary
        public IdAreasQuestionGen()
        {
            DeweyDecimalsDictionary.Add("000-099", "General Knowledge");
            DeweyDecimalsDictionary.Add("100-199", "Philosophy and Psychology");
            DeweyDecimalsDictionary.Add("200-299", "Religion");
            DeweyDecimalsDictionary.Add("300-399", "Social Sciences");
            DeweyDecimalsDictionary.Add("400-499", "Languages");
            DeweyDecimalsDictionary.Add("500-599", "Science");
            DeweyDecimalsDictionary.Add("600-699", "Technology");
            DeweyDecimalsDictionary.Add("700-799", "The Arts");
            DeweyDecimalsDictionary.Add("800-899", "Literature");
            DeweyDecimalsDictionary.Add("900-999", "History and Geography");
        }

        //----------------------------------------------------------------------------------
        public Dictionary<string, string> DeweyDecimalsDictionary { get => deweyDecimalsDictionary; set => deweyDecimalsDictionary = value; }

    }
}
