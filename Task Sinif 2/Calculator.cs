using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Sinif_2
{
    internal class Calculator
    {
        public string Calculation(int num1, int num2, string operation)
        {
            double result=0;

            switch(operation)
            {
                case "+":
                    result = num1+num2;
                    return result.ToString();
                    case "-":
                    result= num2 - num1;
                    return result.ToString();
                    case "*":
                    result = num1 * num2;
                    return result.ToString();
                    case "/":
                    result = num1 / num2;
                    return result.ToString();

                default:
                    return "Duzgun daxil edin";
            }
        }
    }
}
