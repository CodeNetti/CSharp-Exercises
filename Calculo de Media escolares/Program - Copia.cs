using System;

namespace Mediadousuario.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nome do aluno");
            String nome = Console.ReadLine();
            Console.WriteLine($"Vamos apresentar  a media de suas  notas:{nome}");
            Console.WriteLine("Sua primeira nota é:");
            
            
            
            float n1, n2, n3, n4;
            float.TryParse(Console.ReadLine(), out n1);
            Console.WriteLine("Sua segunda nota é:");
            float.TryParse(Console.ReadLine(), out n2);
            Console.WriteLine("Sua Terceira nota é:");
            float.TryParse(Console.ReadLine(), out n3);
           Console.WriteLine("Sua quarta nota é:");
            float.TryParse(Console.ReadLine(), out n4);
            float media = (n1 + n2 + n3 + n4) / 4;
            Console.WriteLine(media);
            if(media<6)
            {

                Console.WriteLine("Você foi reprovado");
            }
            else
            {

                Console.WriteLine("Você foi aprovado");
            }
                    

            
          




           
        }
    }
}
