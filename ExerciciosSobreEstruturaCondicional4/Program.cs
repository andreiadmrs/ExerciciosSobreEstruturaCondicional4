using System;

namespace ExerciciosSobreEstruturaCondicional4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
            começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.*/

            Console.WriteLine("Digite o hórario que o jogo começou: ");
            int comeco = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o hórario que o jogo terminou: ");
            int termino = int.Parse(Console.ReadLine());
            int dia = 24;

            

            if (comeco >= termino)
            {
                int duracao = dia - comeco + termino;
                Console.WriteLine("O jogo durou " + duracao + " horas.");
            }
            else
            {
                int duracao = termino - comeco;
                Console.WriteLine("O jogo durou " + duracao + " horas.");

            }
            
        }
    }
}
