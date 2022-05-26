using System;

class Pessoa
{

    //Atributos
    protected string nome;

    protected int idade;

    //Métodos
    protected void mensagemPessoa()
    {
        Console.WriteLine("Nome: "+nome);
        Console.WriteLine("Idade: "+idade);
    }
}