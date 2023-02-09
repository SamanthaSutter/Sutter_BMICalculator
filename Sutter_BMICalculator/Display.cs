using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Sutter_BMICalculator
{ 
    class Display
    {
        public void DisplayInfo(string assignment)
        {
            const string BARRIER = "***************************************************";
            WriteLine(BARRIER);
            WriteLine("Name:\t\tSamantha Sutter");
            WriteLine("Instructor:\tJanese Christie");
            WriteLine("Assignment:\t" + assignment);
            WriteLine("Date:\t\t" + DateTime.Today.ToShortDateString());
            WriteLine(BARRIER);
        }
    }
}

