using System;

namespace EX1.classes
{
    public class Pessoa
    {
        public string primeiroNome;
        public string sobreNome;

        public Pessoa(){

        }
        public Pessoa(string nome, string sobreNome){

            this.primeiroNome = nome;
            this.sobreNome = sobreNome;

            Console.WriteLine($"Bem vindo {nome} {sobreNome}");
            
        }

    }
}