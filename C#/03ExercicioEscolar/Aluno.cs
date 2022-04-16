using System;

class Aluno
{
    // Atributos
    public String nome;

    public double nota1, nota2;


    // Metodos

    //media
    public double media()
    {
        return (nota1 + nota2) / 2;
    }
    //situação
    public String situacao(double media)
    {
        //operador ternario
        return media >= 7 ? "Aprovado" : "Reprovado";
    }
    //mensagem
    public void mensagem()
    {
        //obter media
        double obterMedia = media();

        //obter a situação
        string obterSituacao = situacao(obterMedia);

        Console.WriteLine(nome + " está " + obterSituacao + " com media " + obterMedia);
    }
}