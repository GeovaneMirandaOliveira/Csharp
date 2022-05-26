using System;

class Atendente : Imposto // Herança herda os dados da classe imposto
{
    // Métodos
    public override void valeAlimentacao(double salario)
    {
        Console.WriteLine("Desconto atendente do vale alimentação R$"+(salario * 0.12));
    }
}