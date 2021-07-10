using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina2._3
{
    class PessoaFisica: Pessoa
    {
        private int cpf;
        public int getCpf()
        {
            return this.cpf;
        }

        public void setCpf(int cpf)
        {
            this.cpf = cpf;
        }
    }
}
