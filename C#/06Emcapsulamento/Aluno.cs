using System;

class Aluno
{
    //Atributos

    private double nota1, nota2;

    // Média
    private double media()
    {
        return (nota1+nota2)/2;
    }

    public void mensagem()
    {
        Console.WriteLine("Informe a Primeira nota");
        nota1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe nota2");
        nota2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("A media e "+media());
    }
}