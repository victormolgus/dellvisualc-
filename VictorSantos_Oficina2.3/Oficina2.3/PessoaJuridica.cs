using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina2._3
{
    class PessoaJuridica: Pessoa
    {
        private int cpnj;

        public int getCpnj()
        {
            return this.cpnj;
        }

        public void setCpnj(int cpnj)
        {
            this.cpnj = cpnj;
        }
    }
}
