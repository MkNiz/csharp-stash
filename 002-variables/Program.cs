﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // short - small integer between -32,768 and 32,767
            short var1 = -9999;
            Console.WriteLine("var1: " + var1);

            // int - medium integer between -2,147,483,648 and 2,147,483,647
            int var2 = 999999999;
            Console.WriteLine("var2: " + var2);

            // long - large integer between -9,224,372,036,854,775,808 and 9,223,372,036,852,775,807
            long var3 = -9999999999999999;
            Console.WriteLine("var3: " + var3);

            // byte - very small unsigned integer between 0 and 255
            byte var4 = 99;
            Console.WriteLine("var4: " + var4);

            // ushort - small unsigned integer between 0 and 65,535
            ushort var5 = 9999;
            Console.WriteLine("var5: " + var5);

            // uint - medium unsigned integer between 0 and 4,294,967,295
            uint var6 = 999999999;
            Console.WriteLine("var6: " + var6);

            // ulong - large unsigned integer between 0 and 18,446,744,073,709,551,615
            ulong var7 = 9999999999999999999;
            Console.WriteLine("var7: " + var7);

            // float - small real number w/ 7 digits of accuracy
            float var8 = 9.9f;
            Console.WriteLine("var8: " + var8);

            // double - large real number w/ 15-16 digits of accuracy
            double var9 = 0.00000000999;
            Console.WriteLine("var9: " + var9);

            // decimal - real number w/ smaller range but higher (28 to 29 digits) accuracy than double
            decimal var10 = 0.000000999M;
            Console.WriteLine("var10: " + var10);

            // char - a single character/letter
            char var11 = 'x';
            Console.WriteLine("var11: " + var11);

            // string - a sequence of numbers, letters, and/or symbols
            string var12 = "I like apples";
            Console.WriteLine("var12: " + var12);

            // bool - a value that can only be true or false
            bool var13 = true;
            Console.WriteLine("var13: " + var13);

            Console.ReadKey();
        }
    }
}
