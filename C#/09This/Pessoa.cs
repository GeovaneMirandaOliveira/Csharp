using System;

class Pessoa
{
    // Atributo
    private string nome = "Bettina";

    //construtor
    public Pessoa(string nome)
    {
        Console.WriteLine(nome);
        Console.WriteLine(this.nome);
    }
}