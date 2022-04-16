using System;

namespace _03ExercicioEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciar objeto de classe aluno
            Aluno a = new Aluno();
            a.nome = "Geovane";
            a.nota1 = 9;
            a.nota2 = 8;
            a.mensagem();
        }
    }
}
