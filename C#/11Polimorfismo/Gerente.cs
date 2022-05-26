using System;

class Gerente : Imposto // Herança herda os dados da classe imposto
{
    // Métodos
    public override void valeAlimentacao(double salario)
    {
        Console.WriteLine("Desconto gerente do vale alimentação R$"+(salario * 0.15));
    }
}