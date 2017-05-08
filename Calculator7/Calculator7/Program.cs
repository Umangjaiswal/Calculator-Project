using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();
            Add DoSum = new Add();
            List<string> ListOfInput = values.Split(' ').ToList();
            if (ListOfInput.Count() > 0 && (ListOfInput[0].ToUpper() == "SUM" || ListOfInput[0].ToUpper() == "ADD"))
            {
                if (ListOfInput.Count() == 1)
                {
                    Console.WriteLine(DoSum.Sum(new List<int>()));
                }
                else
                {
                    List<int> IntList = new List<int>();

                    foreach (var stringValue in ListOfInput[1].Split(','))
                    {
                        int outInt;
                        int.TryParse(stringValue, out outInt);
                        if (outInt < 1000)
                        { IntList.Add(outInt); }
                    }
                    Console.WriteLine(DoSum.Sum(IntList));
                }
            }
            else
            {
                Console.WriteLine("Please provide valid operation");
            }
        }
    }
}
