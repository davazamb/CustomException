using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    //Custom User defiened Exception Created here, using Exception as base class
    public class TestCustomException : Exception
    {

        public TestCustomException(string message) : base(message)
        {
            this.HelpLink = "for more information https://github.com/davazamb";
            this.Source = "This is source of Error";
        }

    }

    //Usual Class with method Show(), which throws Exception with message
    public class MyClass
    {
        public static void Show()
        {
            throw new TestCustomException("This is Custom Exception example in C#");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            //enclose method inside try
            try
            {
                MyClass.Show();
            }
            //catch User defined Exception
            catch (TestCustomException ex)
            {
                //Show Custom defined Error messages
                Console.WriteLine("Error Message:-" + ex.Message);
                Console.WriteLine("Hyper Link :-" + ex.HelpLink);
                Console.WriteLine("Source :- " + ex.Source);
                Console.ReadKey();

            }
        }
    }
}
