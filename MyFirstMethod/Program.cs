using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAula04 {
    class MyClass {
        /// <summary>
        /// It'll print the numbers the user input
        /// </summary>
        /// <param name="n">The number</param>
        static void CountToN(int n) {
            for (int i = 1; i <= n; i++)
                Console.WriteLine(i);
        }

        /// <summary>
        /// My Main method, it'll ask the user for two numbers, and then
        /// print them on the screen
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) {
            string aux = Console.ReadLine();
            string aox = Console.ReadLine();
            int nCount = Convert.ToInt32(aux);
            int mCount = Convert.ToInt32(aox);
            CountToN(nCount);
            CountToN(mCount);
            Console.ReadKey();
        }
    }
}