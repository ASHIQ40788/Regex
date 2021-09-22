using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexDemo058
{
    class ExceptionSampleDemo
    {
        public static void TestSample()
        {
            try
            {
                //nullreferenceException
                ////string name = null;
                string name = "XYZ";
                //creating array object with fixed size and then initializing elements
                int[] arr = new int[3];
                arr[0] = 67;
                arr[1] = 34;
                arr[2] = 64;
                //Indexoutofrange exception
                //arr[3] = 89;

                //At the time of creation assigning values
                int[] newArray = { 12, 34 };

                Console.WriteLine("1st array elements");
                foreach (int element in arr)
                {
                    Console.WriteLine(element);

                }

                Console.WriteLine("2nd array elements");
                foreach (int element in newArray)
                {
                    Console.WriteLine(element);
                }
                Console.WriteLine(name.Length); 
            }
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message+ "string is not initialized");
            }

        }

        public static void TestInvalidOperationException()
        {
            try
            {
                ArrayList list = new ArrayList();
                list.Add("xyz");
                list.Add("pqr");
                list.Add("phd");

                Console.WriteLine("arraylist collection elements");
                foreach (string element in list)
                {
                    Console.WriteLine(element);
                }
                list.Clear();
                Console.WriteLine(list.Count);
               // list.Remove("xyz");
                list.RemoveAt(1);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

    }
}
