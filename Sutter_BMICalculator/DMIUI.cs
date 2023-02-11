using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Sutter_BMICalculator
{
    class DMIUI
    {
        //Declaring height and weight variables
        private double height;
        private double weight;

        //Displaying application intro
        public void Introduction()
        {
            WriteLine("\n\nThis program will calculate your Body Mass" +
                " Index (BMI)\nusing your height & weight.");
        }

        //Getting user input for height
        public double InputHeight()
        {
            
            Write("\nPlease enter your height in inches: ");
            string h = ReadLine();
            height = double.Parse(h);

            return height;
        }

        //Getting user input for weight
        public double InputWeight()
        {
            Write("\nPlease enter your weight in pounds: ");
            string w = ReadLine();
            weight = double.Parse(w);

            return weight;
        }

        //Displaying height, weight & BMI to user
        public void DisplayBMI(double height, double weight, double bmi, string status)
        {
            WriteLine("\n\nFor your height of " + height + " inches and your weight of " +
                weight + " pounds,\nyour BMI is " + bmi + " which gives you a weight " +
                "status of " + status + ".\n\n");
            ReadKey();
        }
    }
}
