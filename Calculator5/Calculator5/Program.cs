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
            string values = Console.ReadLine().Replace("\\\\", "\\");
            Add DoSum = new Add();
            List<string> ListOfInput = values.Split(' ').ToList();
            char del;
            if (ListOfInput.Count() > 0 && (ListOfInput[0].ToUpper() == "SUM" || ListOfInput[0].ToUpper() == "ADD"))
            {
               
                if (ListOfInput.Count() == 1)
                {
                    Console.WriteLine(DoSum.Sum(new List<int>()));
                }
                else
                {
                    del = Convert.ToChar(ListOfInput[1].Split('\\')[1]);
                    List<int> IntList = new List<int>();
                    foreach (var stringValue in ListOfInput[1].Split('\\')[2].Split(del))
                    {
                        int outInt;
                        int.TryParse(stringValue, out outInt);
                        IntList.Add(outInt);
                    }
                    if (IntList.Where(d => d < 0).Count() > 0)
                    {
                        Console.WriteLine("Negative numbers are not allowed.");
                    }
                    else
                    {
                        Console.WriteLine(DoSum.Sum(IntList));
                    }
                }
            }
            else
            {
                Console.WriteLine("Please provide valid operation");
            }
        }
    }
}
