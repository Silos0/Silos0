using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using FormulaEvaluator;

namespace TestFormEval
{
    class TestFormulaEvaluator
    {
        static void Main(string[] args)
        {
            string a = "3";
            string s = "(2+35)*A7"; //["(", "2", "+", "35", ")", "*", "A7"] from given regex
            string r = "(2+35)* A7";
            

            string t = "E96F";

            string[] testvariable = Regex.Split(a, "[A-Z]+");

            int x =  Evaluator.Evaluate(a, TestLookup);

            foreach (string test1 in testvariable)
            {
                Console.Write(test1 + "\n");
               //int? number = IsNum(test1);
                Console.WriteLine("Printing ints" + x);
                Console.WriteLine(x + 1);


            }
           Console.WriteLine(x);
           
            
            
        }
        
     public static int TestLookup(string s)
        {
            return 2;
        }

        static int? IsNum(string s)
        {            
            int x;
          bool yesorno = int.TryParse(s, out x);
            if (yesorno)
                return x;
            else
                return null;             
        }

    }
}
