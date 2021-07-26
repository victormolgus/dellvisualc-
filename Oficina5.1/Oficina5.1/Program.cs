using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Oficina5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator fabricaCarro = new CarroCreator();
            Creator fabricaMoto = new MotoCreator();

            Carro meucarro = (Carro)fabricaCarro.criarVeiculo();
            Moto minhamoto = (Moto)fabricaMoto.criarVeiculo();

            meucarro.getTipo();
            minhamoto.getTipo();
            Console.WriteLine("Aperte qualquer tecla para sair...");
            Console.ReadKey();

        }
    }
}
