using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina6._1
{
    public class Program
    {
        static void Main(string[] args)
        {
            ControllerMensagens m = new ControllerMensagens(new SMS());
            //ControllerMensagens c = new ControllerMensagens(new Email());
            m.realizarEnvio();
            //c.realizarEnvio();
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();

        }
    }
}
