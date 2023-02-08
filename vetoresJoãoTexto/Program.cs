using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetoresExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string[] valor2; // basico para um usuario definir um tamanho parte 1
            int valor3, valor4;

            Console.WriteLine("insira o tamanho do vetor: ");
            valor3 = int.Parse(Console.ReadLine());

            valor2 = new string[valor3]; // basico para um usuario definir um tamanho parte 2

            for (int i = 0; i <= (valor3 - 1); i++)
			{
                 Console.WriteLine("insira o texto do º vetor: ");
                 valor2[i] = Console.ReadLine();
                                
			}

            for (int i = 0; i <= (valor3 - 1); i++)
			{
                Console.WriteLine("aqui está o conteudo da º linha: "+ valor2[i]);
			}

            Console.ReadKey();


        }
    }
}
