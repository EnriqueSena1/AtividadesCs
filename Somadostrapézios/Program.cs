using System;
using System.Collections.Generic;
using System.Globalization;


namespace Calculos {

    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;

            //Calculo da área de um triângulo trapezio
            //double b1, b2, h, area;
            //b1 = 6.0;
            //b2 = 8.0;
            //h = 5.0;

            //area = (b1 + b2) / 2.0 * h;
            //Console.WriteLine("A área do trapézio é: " + area.ToString("F2", CI));

            //---------------------------

            //Calculo da área de um círculo (Forçando o uso de numero flutuante passando "double")
            //int a, b; 
            //double resultado;

            //a = 5;
            //b = 2;
            //resultado = (double) a / b;
            //Console.WriteLine(resultado);

            //--------------------------

            double a;
            int b;
            a = 5.2;
            b = (int)a; // força pegar somente a parte inteira do calculo!
            //b = Convert.ToInt32(a); // outra forma de fazer a conversão
            Console.WriteLine(b);

        }
    }
}
