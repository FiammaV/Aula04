﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAula04 {
    class MyClass {
        static void CountToN(int n) {
            for (int i = 1; i <= n; i++)
                Console.WriteLine(i);
        }

        static void Main(string[] args) {
            string aux = Console.ReadLine();
            int nCount = Convert.ToInt32(aux);
            CountToN(nCount);
            CountToN(nCount);
            Console.ReadKey();
        }
    }
}
