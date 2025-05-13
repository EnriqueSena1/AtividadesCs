using System;
using System.Collections.Generic;
using System.Globalization;

namespace EntradaDados {
    class Program {
        static void Main(string[] args) {
            //CI = CultureInfo.InvariantCulture;
            int hora;
            Console.Write("Digite uma Hora do dia: ");
            hora = int.Parse(Console.ReadLine());

            if (hora < 12) {
                Console.WriteLine("Bom dia!!!");
            }
            else {
                Console.WriteLine("Boa tarde !!!");
            }

        }
    }
}
