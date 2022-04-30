using System;

namespace Aplicação_teste
{
    class Program
    {


        static void Main(string[] args)
        {
            decimal nota1;
            decimal nota2;
            decimal nota3;
            decimal media;

            //Recebe as 3 notas 
            Console.WriteLine("Digite a primeira nota.");
            nota1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota.");
            nota2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota.");
            nota3 = Convert.ToDecimal(Console.ReadLine());

            //analisa qual numero é maior

            if (nota1 > nota2 && nota1 > nota3  )
            {
           
                {
                    Console.WriteLine( "a sua maior nota é: " + nota1);
                }
            }
           else if (nota2 > nota3 && nota2 > nota1)
            {
                Console.WriteLine("a sua maior nota é: " + nota2);
            }
            else if (nota3 > nota2 )
            {
                Console.WriteLine("a sua maior nota é: " + nota3);
            }


            //analisa qual numero é menor
            if (nota1 < nota2 && nota1 < nota3)
            {
                Console.WriteLine("a sua menor nota é: " + nota1);
            }
            else if (nota2 < nota3 && nota2 < nota1)
            {
                Console.WriteLine("a sua menor note é: " + nota2);
            }
            else if (nota3 < nota2)
            {
                Console.WriteLine("a sua maior nota é: " + nota2);
            }

            //calcula a média do aluno
            media = ((nota1 + nota2 + nota3)/3);
            Console.WriteLine( "sua média é: " + media);
            
        }
    }
}
