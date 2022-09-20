using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog7312POETask1
{
    internal class NumberGeneration
    {
        //This class is where the dewey decimal values will be calculated and generated

        //Local variable for generating the random dewey decimal values
        Random _random;

        /// <summary>
        /// This is a class in which a random book is being generated.
        /// </summary>
        public NumberGeneration()
        {
            _random = new Random();
        }
        //*********************************************************ooo CLASS END ooo*********************************************************//
        
        /// <summary>
        /// This is a method where the call numbers as well as the authors name is being generated. For example: 273.99 STV
        /// </summary>
        /// <returns></returns>
        public string generates_call_numbers()
        {
            //List to store the callNumbers
            List<string> callNumbers = new List<string>();

            //A variable for the first 3 call numbers. For example: 283
            int Call_Number = _random.Next(999);

            //Converting the generated callNumber into a string called myNumbers
            string myNumbers = Call_Number.ToString();

            //An if statement where if the numbers length is smaller than 3,
            //Then it will be added to the beginning section of the dewey decimal value 
            if (myNumbers.Length < 3)
            {
                int runTimes = 3 - myNumbers.Length;
                for (int i = 0; i < runTimes; i++)
                {
                    myNumbers = myNumbers.Insert(0, "0");
                }
            }

            myNumbers += "."; //This is the space between the first and the second callNumber values
            Call_Number = _random.Next(9,999); //generating the next callNumber to add next to the first one
            myNumbers += Call_Number.ToString(); //Adding the 2 callNumbers

            string Author = " "; //This is the space between the callNumbers and the generated author name
            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; //This is the range of letters which can be used when generating the name

            //A for loop to generate 3 letters then add then together as the authors name
            for (int i = 0; i < 3; i++)
            {
                Author += letters[_random.Next(letters.Length)];
            }

            //Adding the myNumbers and the Author together
            myNumbers += Author;

            //Returning the finished dewey decimal value
            return myNumbers;
        }
        //*********************************************************ooo METHOD END ooo*********************************************************//
    }
    //*********************************************************ooo CLASS END ooo*********************************************************//
}
//*********************************************************ooo APP END ooo*********************************************************//