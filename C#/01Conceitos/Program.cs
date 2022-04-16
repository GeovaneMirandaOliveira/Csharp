using System;

namespace _01Conceitos // pasta aonde esta o projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            // instanciar objeto , criar objeto
            Pessoa obj = new Pessoa(); //dando o nome obj ao objeto pessoa , Pessoa recebe o nome de obj
            obj.nome = "Geovane";
            obj.idade = 32;
            obj.mensagem();
        }
    }
}
