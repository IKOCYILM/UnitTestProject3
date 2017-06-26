using System;
using System.Collections.Generic;

namespace UnitTestProject3
{

    internal class Calculator
    {
        private List<int> numbers = new List<int>();

        public List<int> Numbers { get => numbers; set => numbers = value; }

        internal int add()
        {
            return Numbers[0] + Numbers[1];
        }

        internal void addNumber(int number)
        {
            Numbers.Add(number);
        }
    }


}