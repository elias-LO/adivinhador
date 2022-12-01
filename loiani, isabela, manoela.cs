using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavra1, palavra2, palavra3, palavra4, palavra5, palavrachave = "Eu", palavra = "", palavra6, palavra7, palavra8, palavra9, palavra10, palavrachave1 = "Tu", proximo;
            int seletor, tentativas = 0, seletor1, tentativas1 = 0;

            Console.WriteLine("ADIVINHADOR");
            Console.WriteLine("Tente descobrir a palavra em menos tentativas possíveis");

            Console.Clear();
            Console.WriteLine("Jogador 1");
            Console.WriteLine("insira a primeira palavra");
            palavra1 = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("insira a segunda palavra");
            palavra2 = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("insira a terceira palavra");
            palavra3 = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("insira a quarta palavra");
            palavra4 = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("insira a quinta palavra");
            palavra5 = Console.ReadLine();


            Random adivinhador = new Random();
            seletor = adivinhador.Next(0);


            Console.WriteLine(seletor);

            if (seletor == 1)
            {
                palavrachave = palavra1;
                Console.ReadKey();
            }
            else if (seletor == 2)
            {
                palavrachave = palavra2;
                Console.ReadKey();
            }
            else if (seletor == 3)
            {
                palavrachave = palavra3;
                Console.ReadKey();
            }
            else if (seletor == 4)
            {
                palavrachave = palavra4;
                Console.ReadKey();
            }
            else if (seletor == 5)
            {
                palavrachave = palavra5;
                Console.ReadKey();
            }

            do
            {

                Console.WriteLine("insira sua tentativa");
                palavra = Console.ReadLine();
                tentativas = tentativas + 1;
                Console.Clear();
                Console.ReadKey();

            } while (palavra != palavrachave);

            Console.WriteLine("Você adivinhou a palavra chave em "
             + tentativas + " tentativas");

            Console.WriteLine("Próximo Jogador");
            proximo = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Jogador 2");
            Console.WriteLine("Digite a primeira palavra");
            palavra6 = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Digite a segunda palavra");
            palavra7 = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Digite a terceira palavra");
            palavra8 = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Digite a quarta palavra");
            palavra9 = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Digite a quinta palavra");
            palavra10 = Console.ReadLine();


            Random adivinhador1 = new Random();
            seletor1 = adivinhador.Next(0);


            Console.WriteLine(seletor);

            if (seletor1 == 1)
            {
                palavrachave1 = palavra1;
                Console.ReadKey();
            }
            else if (seletor1 == 2)
            {
                palavrachave1 = palavra2;
                Console.ReadKey();
            }
            else if (seletor1 == 3)
            {
                palavrachave1 = palavra3;
                Console.ReadKey();
            }
            else if (seletor1 == 4)
            {
                palavrachave1 = palavra4;
                Console.ReadKey();
            }
            else if (seletor1 == 5)
            {
                palavrachave1 = palavra5;
                Console.ReadKey();
            }

            do
            {

                Console.WriteLine("Digite sua tentativa");
                palavra = Console.ReadLine();
                tentativas1 = tentativas1 + 1;
                Console.Clear();

            } while (palavra1 != palavrachave1);

            Console.WriteLine("Você adivinhou a palavra chave em "
             + tentativas1 + " tentativas");

            if (tentativas < tentativas1)
            {
                Console.WriteLine("Jogador 2 ganhou");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Jogador 1 ganhou");
                Console.ReadKey();
            }

            Console.ReadKey();
        }
    }
}
