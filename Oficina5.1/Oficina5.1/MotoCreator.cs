using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina5._1
{
    class MotoCreator: Creator
    {
        public override Veiculo criarVeiculo()
        {
            return new Moto();
        }
    }
}
