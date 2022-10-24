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
        //******************************************************************************************************************//       
        //dictionary to store the callnumbers and their description
        private Dictionary<string, string> deweyDecimalsDictionary = new Dictionary<string, string>();

        //******************************************************************************************************************//        
        ///constructor to add call numbers and their descriptions to the dictionary
        public IdAreasQuestionGen()
        {
            DeweyDecimalsDictionary.Add("000", "General Knowledge");
            DeweyDecimalsDictionary.Add("100", "Philosophy and Psychology");
            DeweyDecimalsDictionary.Add("200", "Religion");
            DeweyDecimalsDictionary.Add("300", "Social Sciences");
            DeweyDecimalsDictionary.Add("400", "Languages");
            DeweyDecimalsDictionary.Add("500", "Science");
            DeweyDecimalsDictionary.Add("600", "Technology");
            DeweyDecimalsDictionary.Add("700", "The Arts");
            DeweyDecimalsDictionary.Add("800", "Literature");
            DeweyDecimalsDictionary.Add("900", "History and Geography");
        }

        //******************************************************************************************************************//        
        public Dictionary<string, string> DeweyDecimalsDictionary { get => deweyDecimalsDictionary; set => deweyDecimalsDictionary = value; }
    }
    //*********************************************************ooo CLASS END ooo*********************************************************//
}
//*********************************************************ooo APP END ooo*********************************************************//
