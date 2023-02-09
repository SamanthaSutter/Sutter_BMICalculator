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
        private int height;
        private int weight;

        //Displaying application intro
        public void Introduction()
        {
            WriteLine("\n\nThis program will calculate your Body Mass" +
                " Index (BMI)\nusing your height & weight.");
        }

        //Getting user input for height
        public int InputHeight()
        {
            
            Write("\nPlease enter your height in inches: ");
            string h = ReadLine();
            height = int.Parse(h);

            return height;
        }

        //Getting user input for weight
        public int InputWeight()
        {
            Write("\nPlease enter your weight in pounds: ");
            string w = ReadLine();
            weight = int.Parse(w);

            return weight;
        }

        //Displaying height, weight & BMI to user
        public void DisplayBMI(int height, int weight, double bmi)
        {
            WriteLine("For your height of " + height + " and your weight of " +
                weight + " pounds,\nyour BMI is " + bmi + " which gives you a weight " +
                "status of " + ".");
        }

    }
}
