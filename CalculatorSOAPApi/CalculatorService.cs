﻿using System.ServiceModel;

namespace CalculatorSOAPAPI
{
    public class CalculatorService : ICalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            if (b == 0)
                throw new FaultException("Division by zero is not allowed");

            return a / b;
        }
    }
}
