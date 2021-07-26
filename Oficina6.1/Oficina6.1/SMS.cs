using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina6._1
{
    public class SMS: IMensagem
    {
        public void enviar()
        {
            Console.WriteLine("Enviando SMS");
            
        }
    }
}
