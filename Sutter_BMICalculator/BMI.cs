using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sutter_BMICalculator
{
    
    class BMI
    {
        //Declaring variables height, weight and bmi
        int weightInPounds;
        int heightInInches;
        double bodyMassIndex;

        //Property for getting and setting users weight
        public int WeightInPounds
        {
            get { return weightInPounds; }
            set { weightInPounds = value; }
        }

        //Property for getting and setting users height
        public int HeightInInches
        {
            get { return heightInInches; }
            set { heightInInches = value; }
        }

        //Property for getting bmi
        public double BodyMassIndex
        {
            get { return bodyMassIndex; }
            set { bodyMassIndex = value; }
        }

        //Calculating users bmi
        public double CalculateBMI(double height, double weight)
        {
            double num = 703;
            bodyMassIndex = (weight / (Math.Pow(height , 2))) * num;
            return bodyMassIndex;
        }

        //Determining users weight status based on their bmi
        public string ObtainWeightStatus(double bmi)
        {
            string weightStatus = "Normal";

            if (bmi < 18.5)
                weightStatus = "Underweight";
            if (bmi > 24.9 && bmi < 29.9)
                weightStatus = "Overweight";
            if (bmi > 30)
                weightStatus = "Obese";

            return weightStatus;

        }
    }
}
