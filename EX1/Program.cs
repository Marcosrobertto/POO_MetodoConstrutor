﻿using System;
using EX1.classes;

namespace EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite seu sobrenome");
            string sobreNome = Console.ReadLine();


            Pessoa pessoa = new Pessoa(nome, sobreNome);

            Pessoa pessoa2 = new Pessoa();

            
        }
    }
}
