using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina2._3
{
    class Pessoa
    {
        private String nome;
        private int telefone;

        public String getNome()
        {
            return this.nome;
        }
        public void setNome(String nome)
        {
            this.nome = nome;
        }
        public int getTelefone()
        {
            return this.telefone;
        }
        public void setTelefone(int telefone)
        {
            this.telefone = telefone;
        }
    }
}
