using System;

namespace Sutter_BMICalculator
{
    class Sutter_BMICalculator
    {
        static void Main(string[] args)
        {
            //Declaring assignment variable
            string assignment = "BMI Assignment 3";
            int h;
            int w;
            double bmi;
            
            //Creating info object
            Display info = new Display();
            //Creating display object
            DMIUI display = new DMIUI();
            //Creating BMI object
            BMI bodyMassIndex = new BMI();

            //Passing assignment info to info object and displaying
            info.DisplayInfo(assignment);
            //Displaying introduction to application
            display.Introduction();
            h = display.InputHeight();
            w = display.InputWeight();
            bmi = bodyMassIndex.CalculateBMI(h, w);

            display.DisplayBMI(h, w, bmi);
            


        }
    }
}
