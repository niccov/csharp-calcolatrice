using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    public static class CalcoliHelper
    {
        //metodo per la somma di due int
        public static int SumOfTwoInt(int number1, int number2)
        {
            return number1 + number2;
        }

        //metodo per la somma di due double
        public static double SumOfTwoDouble(double number1, double number2)
        {
            return number1 + number2;
        }

        //metodo per la differenza tra due int
        public static int DifferenceOfTwoInt(int number1, int number2)
        {
            return number1 - number2;
        }

        //metodo per la differenza tra due double
        public static double DifferenceOfTwoDouble(double number1, double number2)
        {
            return number1 - number2;
        }

        //metodo per la moltiplicazione di due interi
        public static int MultiplicationOfTwoInt(int number1, int number2)
        {
            return number1 * number2;
        }

        //metodo per la moltiplicazione di due double
        public static double MultiplicationOfTwoDouble(double number1, double number2)
        {
            return number1 * number2;
        }

        //metodo per calcolare il valore assoluto di un intero
        public static int AbsoluteValueOfInt(int number)
        {
            if(number >= 0)
            {
                return number;
            }
            else 
            {
                return -number;
            }
        }

        //metodo per calcolare il valore assoluto di un double 
        public static double AbsoluteValueOfDouble(double number)
        {
            if(number >= 0)
            {
                return number;
            }else
            {
                return -number;
            }
        }

        //metodo per trovare il minimo tra due interi
        public static int MinimumValueInt(int number1, int number2)
        {
            if(number1 < number2)
            {
                return number1;
            }else
            {
                return number2;
            }   
        }

        //metodo per trovare il minimo tra due double 
        public static double MinimumValueDouble(double number1, double number2)
        {
            if( number1 < number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }

        //metodo per trovare il massimo tra due interi 
        public static int MaximumValueInt(int number1, int number2)
        {
            if(number1 > number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }

        //metodo per trovare il massimo tra due double 
        public static double MaximumValueDouble(double number1, double number2)
        {
            if(number1 > number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }
    }
}
