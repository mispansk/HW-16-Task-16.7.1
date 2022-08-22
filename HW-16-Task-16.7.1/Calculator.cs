using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_16_Task_16._7._1
{
    /// <summary>
    /// класс калькулятор, в котором описаны методы сложения, разности, умножения и деления
    /// </summary>
    public class Calculator
    {
        public int Additional(int a, int b)
        {
            return a + b;
        }

        public int Subtraction(int a, int b)
        {
            return a - b;
        }

        public int Miltiplication(int a, int b)
        {
            return a * b;
        }

        public int Division(int a, int b)
        {
            return a / b;
        }
    }
}
