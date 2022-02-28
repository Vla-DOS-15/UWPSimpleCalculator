using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPSimpleCalculator
{
    class Operations
    {
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }
        public double Add(double FirstNumber, double secondNumber) => FirstNumber + secondNumber; 
        public double Subtract(double FirstNumber, double secondNumber) => FirstNumber - secondNumber; 
        public double Multiply(double FirstNumber, double secondNumber) => FirstNumber * secondNumber; 
        public double Division(double FirstNumber, double secondNumber) => FirstNumber / secondNumber; 
        public double Pow(double Number, double Degree) => Math.Pow(Number, Degree);
        public double Sqrt(double Number) => Math.Sqrt(Number);
        public double Exp(double Number) => Math.Exp(Number);
        public double PercentageAdd(double FirstNumber, double secondNumber) => FirstNumber + secondNumber / 100 * FirstNumber;
        public double PercentageSub(double FirstNumber, double secondNumber) => FirstNumber - secondNumber / 100 * FirstNumber;
        public double PercentageMult(double FirstNumber, double secondNumber) => Math.Pow(FirstNumber, 2) * secondNumber / (100 * FirstNumber);
        public double PercentageDiv(double FirstNumber, double secondNumber) => FirstNumber / (FirstNumber * secondNumber / 100);


    }
}
