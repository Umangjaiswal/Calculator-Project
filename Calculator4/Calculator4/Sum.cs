using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calculator.Interfaces;


namespace Calculator
{
    public class Add : ICalculator
    {

        public int Sum(List<int> CommaSaparatedValues)
        {
            if (CommaSaparatedValues.Count() == 0)
            {
                return 0;
            }
            else 
            {
                return CommaSaparatedValues.Sum(x => x);
            }
        }
    }
}
