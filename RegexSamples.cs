using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexDemo058
{
    class RegexSamples
    {
        string PinPattern = "^[0-9]{3}[ ]*[0-9]{3}$";
        //string PinPattern = "^[0-9]{6}$";
        string pattern = "^[0-9]*[a-zA-z]{3,}[a-zA-Z0-9]*$";
        string[] pinInputs = { "123456","123 456", "7467621","A123456","A12345","1234568","123458","123C234","120234" };
        string[] inputs = { "111", "1aaa", "aa11", "bcc", "1a1aab", "1abb23a" };

       

        //string[] pinInputs = { "A400088", "400088B", "400088", "400 088" };
        public void ValidingThreeConsecutives()
        {
            Regex regex = new Regex(pattern);
            Console.WriteLine("Validing 3 consecutive samples");
            IterateLoop(inputs, regex);
        }

        public void ValidingPinCode()
        {
            Regex regex = new Regex(PinPattern);
            Console.WriteLine("Validing PIN code");
            IterateLoop(pinInputs, regex);
        }
        public static void IterateLoop(string[] arr, Regex regex)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                bool result = regex.IsMatch(arr[i]);
                if (result)
                {
                    Console.WriteLine(arr[i] + "-----> " + "Valid");
                }
                else
                {
                    Console.WriteLine(arr[i] + "-------->" + "Invalid");
                }

            }

        }
    }
}

//        public void ValidingPinCode()
//        {
//            Regex regex = new Regex(PinPattern);
//            Console.WriteLine("Validing PIN code");
//            IterateLoop(pinInputs, regex);
//        }
//    }

//}
