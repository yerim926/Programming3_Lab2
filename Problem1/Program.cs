using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    public class MyTestClass
    {
        public string getUpperCase(string a)
        {
            return a.ToUpper();
        }

        public int getLength(string a)
        {
            return a.Length;
        }
    }


    public class BuiltInDelegateTest
    {
        public static void Main(string[] args)
        {

            MyTestClass c = new MyTestClass();


            Func<string, string> aDel = c.getUpperCase;

            Func<string, int> bDel = c.getLength;

            //////////////////////////////
            Console.Write("Enter word: ");
            string s = Console.ReadLine();
            Console.WriteLine("Options:");
            Console.WriteLine("1: Get UpperCase");
            Console.WriteLine("2: Get Length");
            Console.Write("Enter option: ");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    {
                        aDel = c.getUpperCase;

                        string theWord = s;


                        string sUpper;

                        sUpper = aDel.Invoke(theWord);
                        Console.WriteLine("Uppercase: " + sUpper);
                    }

                    break;
                case 2:
                    {
                        bDel = c.getLength;
                        string theWord = s;

                        int sLength;

                        sLength = bDel.Invoke(theWord);
                        Console.WriteLine("Length: " + sLength);
                    }
                    break;

                default:
                    break;
            }

            Console.WriteLine("");
            Console.WriteLine("Press any key to exit...");


            Console.ReadKey(); //Halts execution

        }

    }
}
