using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            String n1, n2;
            Console.WriteLine("|----------------------|");
            Console.WriteLine("| Cálculo da Diferença |");
            Console.WriteLine("|----------------------|\n");
            //Recebo os valores n1 e n2
            Console.Write(" Digite o primeiro número: ");
            n1 = Console.ReadLine();
            Console.WriteLine();
            Console.Write(" Digite o segundo número: ");
            n2 = Console.ReadLine();
            //resultado recebe a diferença da conversão dos valores para inteiro.
            double resultado;
            resultado = int.Parse(n1) - int.Parse(n2);
            Console.WriteLine("|--------------");
            Console.WriteLine("| Resultado: " + resultado);
            Console.WriteLine("|--------------");
            //Espero a ação do usuário.
            Console.Write(" Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
