﻿using System;
using System.Collections.Generic;
using System.Globalization;


namespace ExceciciosC_ {

    class teste {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int idade;
            double salario;
            string nome;
            char sexo;

            idade = 32;
            salario = 4560.9;
            nome = "Maria Silva";
            sexo = 'F';

            Console.WriteLine("A funcionaria " + nome + ", sexo " + sexo + " Tem o salario de R$"
                + salario.ToString("F2", CI) + " e tem a idade de " + idade + " anos");



        }
    }
}
