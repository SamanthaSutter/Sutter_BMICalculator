using System;

namespace Sutter_BMICalculator
{
    class Sutter_BMICalculator
    {
        static void Main(string[] args)
        {
            //Declaring variables
            string assignment = "BMI Assignment 3";
            double h;
            double w;
            double bmi;
            string status;
            
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

            //Setting user input for height
            h = display.InputHeight();
            //Setting user input for weight
            w = display.InputWeight();
            //Calculating users bmi 
            bmi = bodyMassIndex.CalculateBMI(h, w);
            //Determining users weight status
            status = bodyMassIndex.ObtainWeightStatus(bmi);

            //Displaying the users height, weight, bmi and weight status
            display.DisplayBMI(h, w, bmi, status);
            
            


        }
    }
}
