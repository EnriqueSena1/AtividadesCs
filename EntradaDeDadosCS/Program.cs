using System;
using System.Collections.Generic;
using System.Globalization;

namespace EntradaDados {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double salario1, salario2;
            string nome1, nome2;
            int idade1, idade2;
            char sexo1, sexo2;

            Console.Write("Digite o nome da primeira pessoa: ");
            nome1 = Console.ReadLine();
            Console.Write("Digite o salario da primeira pessoa: ");
            salario1 = double.Parse(Console.ReadLine(),CI); // Tive que colocar a variavel CI para numero float

            Console.Write("Digite o nome da segunda pessoa: ");
            nome2 = Console.ReadLine();
            Console.Write("Digite o salario da segunda pessoa: ");
            salario2 = double.Parse(Console.ReadLine(),CI); // Tive que colocar a variavel CI para numero float

            Console.Write("Digite a idade da primeira pessoa: ");
            idade1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o sexo da primeira pessoa (F/M):");
            sexo1 = char.Parse(Console.ReadLine());


            Console.Write("Digite a idade da segunda pessoa: ");
            idade2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o sexo da segunda pessoa (F/M):");
            sexo2 = char.Parse(Console.ReadLine());

            Console.WriteLine("Dados da primeira pessoa:" + nome1 +" tem a idade de " +
            idade1 + "Anos e do sexo "+ sexo1 + " E recebe o salario de: R$ " + salario1.ToString("F2",CI)); //Determinando quantas casas decimais após a virgula tem que ter!

            Console.WriteLine("Dados da Segunda pessoa:" + nome2 + " tem a idade de " +
            idade2 + "Anos e do sexo " + sexo2 + " E recebe o salario de: R$ " + salario2.ToString( "F2", CI)); //Determinando quantas casas decimais após a virgula tem que ter!
        }
    }
}
