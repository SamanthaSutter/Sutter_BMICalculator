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

        public double CalculateBMI(int height, int weight)
        {
            bodyMassIndex = (weight / (height * height)) * 703;
            return bodyMassIndex;
        }
    }
}
