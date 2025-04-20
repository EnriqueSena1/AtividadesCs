using System;
using System.Collections.Generic;
using System.Globalization;


namespace Calculos {

    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int x,y;
            x = 10;
            y = 20 *  x;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine( y.ToString("F2", CI));


        }
    }
}
