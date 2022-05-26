using System;


class PessoaFisica : Padrao
{
    public override void taxaEmprestimo(double valor)
    {
        Console.WriteLine("Taxa de emprestimo para pessao fisica R$ "+(valor*0.1));
    }


}