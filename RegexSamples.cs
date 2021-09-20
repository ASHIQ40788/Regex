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
        string pattern = "^[0-9]*[a-zA-z]{3,}[a-zA-Z0-9]*$";
        //string Pinpattern = "^[0-9]{6}$";
        // string PinPattern = "^[0-9]{3}[]*[0-9]{3}$";
        string[] inputs = { "111", "1aaa", "aa11", "bcc", "1a1aab", "1abb23a" };
        //string[] pinInputs = { " 400088", "A400088", "400088", "400J8", "400088" };
        public void ValidingThreeConsecutives()
        {
            Regex regex = new Regex(pattern);
            Console.WriteLine("Validing 3 consecutive samples");
            IterateLoop(inputs, regex);
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
