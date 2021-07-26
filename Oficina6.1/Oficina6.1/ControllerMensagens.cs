using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina6._1
{
    public class ControllerMensagens
    {
        public IMensagem msg;
        
        public ControllerMensagens(IMensagem m)
        {
            msg = m;

        }
        public void realizarEnvio()
        {
            msg.enviar();
        }
    }
}
