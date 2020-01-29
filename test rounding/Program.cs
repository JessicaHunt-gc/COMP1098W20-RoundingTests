using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_rounding
{
    class Program
    {
        enum TermValues : short
        {
            Net30Days = 30,
            Net60Days = 60,
            Net90Days = 90
        };

        static void Main(string[] args)
        {
            double testRounding = 23.85;
            double result = Math.Round(testRounding, 1);

            List<int> numbers = new List<int>()
            {
                1,5,7,3,7,3,2,29
            };

            Console.WriteLine("Math.Round(" + testRounding + ",1) = " + result);
            Console.ReadLine();
            String firstName = "Bob";
            String lastName = "Smith";

            String name = firstName + " " + lastName;
            name = "Name: \"" + name+"\"";
            Console.WriteLine(name);
            Console.ReadLine();

            String blob = name +"\nRounded Value: "+result;
            String file = "C:\\folder\\test.txt";

            Console.WriteLine(blob);
            Console.WriteLine(file);
            Console.ReadLine();

            double otherValue = 43.22;
            String doubleValue = "12.34";
            String badDoubleValue = "a12.34";

            double parsedValue = Double.Parse(doubleValue);

            var outputValue = doubleValue + otherValue; // 12.3443.22
            var outputValue2 = parsedValue + otherValue; // 55.56

            var intVal = Convert.ToInt32(outputValue2);
            var dblVal = Convert.ToDouble(intVal);

            double parsedValue2;
            Boolean tryParseResult = Double.TryParse(badDoubleValue, out parsedValue);
           // double parseBadValueResult = Double.Parse(badDoubleValue); // This throws an exception


            TermValues invoiceTerm = TermValues.Net60Days;

            Console.WriteLine("Invoice Term: " + (short)invoiceTerm);
            Nullable<decimal> d = null;
            decimal? d2 = null;
            //decimal d3 = null;
            d = 45.55m;
            decimal d4;
            if(d.HasValue && d !=null)
                d4 = d.Value;

            d4 = d ?? -1;





            Console.ReadLine();

            string num = null;
            for (int i = 1; i < 6; i++)
            {
                num += i;
                num += "\n";
                if (i < 4)
                    continue;
                num += "Big\n";
            }

        }
    }
}
