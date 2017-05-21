﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiAOD_LR4
{
    class Program
    {
        /*
            А+В – инфиксная: знак операции находится между операндами; 
            +АВ  – префиксная (польская): знак операции расположен перед операндами; 
            АВ+  – постфиксная (обратная польская): знак операция находится после 
         */
        static void Main(string[] args)
        {
            Console.Write("введите инфиксную: ");
            string equation = Console.ReadLine();
            StackSettings decision = new StackSettings();
            string result = decision.decision(equation);
            Console.WriteLine("постфиксная: {0}", result);
            Console.WriteLine("постфиксная: {0}", Reverse(result));
            Console.ReadKey();
        }

        static public string Reverse(string str)
        {
            string newStr = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                newStr += str[i];
            }
            return newStr;
        }
    }
}
