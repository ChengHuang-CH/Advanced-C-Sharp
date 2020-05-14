using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TypicalDataTypes
{
    class DataTypes
    {
        /// <data type test>
        static void Main()
        {   
            // int float double decimal

            /* 2-7: data type formatting with R
             * multiple line annotation */

            const double number = 1.6123456798818394;
            double result;
            string text;

            text = string.Format("{0}", number);
            result = double.Parse(text);
            Console.WriteLine("{0}: result !=number", result != number);

            text = string.Format("{0:R}", number);
            result = double.Parse(text);
            Console.WriteLine("{0}: result ==number", result == number);

            /*2-11: escape character*/
            Console.Write("\"Truly, you have an apple.\"");
            Console.Write("\n\"Wait till I get more!\"\n");

            /*2-12: Draw triangles- @ means not processing escape characters*/
            Console.WriteLine(@"begin
                         /\
                        /  \
                       /    \
                      /______\");

            

            /*String methods*/
            // Format() method has similar function as console.write just without display
            string text1, firstName="C", lastName="H";
            text1 = string.Format("your full name is {0} {1}.",
                firstName, lastName);
            Console.WriteLine(text1);

            text1 = string.Concat(firstName, lastName);
            Console.WriteLine(text1);

            int result1 = string.Compare(firstName, lastName);
            //0 if equal; negative is last>first; positive if last<first
            Console.WriteLine(result1);

            // StartWith, EndWith, ToLower, ToUpper, Trim, Replace
            
            /*2-13: string length*/
            string palindrome = "if you feel very good";
            Console.WriteLine("The palindrome, \"{0}\" contains {1} characters", palindrome, palindrome.Length);

            /*2-15: string can not be changed but return to a new string */
            string uppercase;
            uppercase = palindrome.ToUpper(); // only palindrome.ToUpper() wiil assert errors
            Console.WriteLine(uppercase);


            /*2-26,27,28 cast*/
            string text2 = "9.11E-31";
            float kfElectronMass = float.Parse(text);
            Console.WriteLine(text2);

            string middleCText = "261.6234";
            double middleC = Convert.ToDouble(middleCText);
            Console.WriteLine(middleC);

            bool boolean = true;
            string text3 = boolean.ToString();
            Console.WriteLine(text3);

            /* TryParse*/



            Console.ReadLine();

        }
    }
}
