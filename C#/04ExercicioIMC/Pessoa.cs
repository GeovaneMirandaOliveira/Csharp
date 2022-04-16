using System;


class Pessoa
{
    //Atributos
    public double peso;
    public double altura;


    // Metodos(ações)

    // Calculo IMC
    public double imc()
    {
        return peso / (altura * altura);
    }


    // Situação do IMC
    public string situacao(double imc)
    {
        return imc <= 18.5 ? "abaixo do Peso" : imc <= 25 ? "Peso Normal" : imc <= 30 ? "Acima do Peso" : imc <= 35 ? "Obesidade 1" : imc <= 40 ? "Obesidade 2" : imc >= 40 ? "Obesidade 3" : "";
    }

    // MSG para informar situação do IMC;
    public void mensagem()
    {
        double obterImc = imc();

        string obterSituacao = situacao(obterImc);

        Console.WriteLine("Seu IMC é " + obterImc);
        Console.WriteLine("Sua situação é " + obterSituacao);

    }


}
