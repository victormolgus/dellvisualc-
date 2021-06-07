using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" |------------------------|");
            Console.WriteLine(" | VERIFICADOR DE STRINGS |");
            Console.WriteLine(" |------------------------|\n");
            Console.WriteLine(" Verifica se é um número inteiro, apenas letras ou um alfanumérico.");
            String input;
            //Booleano para verificar se a string é um número inteiro
            bool isNumber;

            do
            {
                Console.Write(" \n Digite alguma coisa: ");
                input = Console.ReadLine();
                //Verificar a condição
                isNumber = long.TryParse(input, out long n);
                switch (isNumber)
                {
                    case true:
                        //Caso verdadeiro
                        Console.WriteLine("\n --> {0} (Apenas números)", input);
                        break;

                    default:
                        //Caso falso
                        if (Regex.IsMatch(input, "^[a-zA-Z]*$"))
                        {
                            Console.WriteLine("\n --> {0} (Apenas letras)", input);
                        }
                        else if(Regex.IsMatch(input, "^[a-zA-Z0-9]*$"))
                        {
                            Console.WriteLine("\n --> {0} (Alfanumérico)", input);
                        }
                        break;

                }
                //Aviso da necessidade de apertar o enter para continuar na estrutura de repetição.
                Console.WriteLine("\n Pressione Enter para recomeçar ou qualquer tecla para sair...");
            }
            while (Console.ReadKey().Key == ConsoleKey.Enter);
        }
    }
}
