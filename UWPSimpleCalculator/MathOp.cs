using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPSimpleCalculator
{
    class MathOp
    {
        public static double Add(double FirstNumber, double secondNumber) => FirstNumber + secondNumber; 
        public static double Subtract(double FirstNumber, double secondNumber) => FirstNumber - secondNumber; 
        public static double Multiply(double FirstNumber, double secondNumber) => FirstNumber * secondNumber;
        public static double Division(double FirstNumber, double secondNumber) => FirstNumber / secondNumber; 
        public static double Pow(double Number, double Degree) => Math.Pow(Number, Degree);
        public static double Sqrt(double Number) => Math.Sqrt(Number);
        public static double Exp(double Number) => Math.Exp(Number);
        public static double Sin(double Number) => Math.Sin(Number);
        public static double Cos(double Number) => Math.Cos(Number);
        public static double Tan(double Number) => Math.Tan(Number);
        public static double PercentageAdd(double FirstNumber, double secondNumber) => FirstNumber + secondNumber / 100 * FirstNumber;
        public static double PercentageSub(double FirstNumber, double secondNumber) => FirstNumber - secondNumber / 100 * FirstNumber;
        public static double PercentageMult(double FirstNumber, double secondNumber) => Math.Pow(FirstNumber, 2) * secondNumber / (100 * FirstNumber);
        public static double PercentageDiv(double FirstNumber, double secondNumber) => FirstNumber / (FirstNumber * secondNumber / 100);
        public static double Factorial(double n) => n == 0 ? 1 : Factorial(n - 1) * n;
    }
}
