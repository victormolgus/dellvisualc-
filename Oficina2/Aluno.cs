using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina2
{
    public class Aluno
    {
        private String nome_aluno;
        private int mat;
        private String email;

        public Aluno(string nome_aluno, int mat, string email)
        {
            this.nome_aluno = nome_aluno;
            this.mat = mat;
            this.email = email;
        }
        public void setNome_Aluno(String nome_aluno)
        {
            this.nome_aluno = nome_aluno;
        }

        public String getNome_Aluno()
        {
            return this.nome_aluno;
        }

        public void setMat(int mat)
        {
            this.mat = mat;
        }

        public int getMat()
        {
            return this.mat;
        }

        public void setEmail(String email)
        {
            this.email = email;
        }

        public String getEmail()
        {
            return this.email;
        }


        public void inserirDisciplina()
        {
            Console.WriteLine("Insira o nome da disciplina");
            Console.WriteLine("O aluno " + this.nome_aluno + " inseriu a disciplina de " + Console.ReadLine());

        }
        public void removerDisciplina()
        {
            Console.WriteLine("Insira o nome da disciplina");
            Console.WriteLine("O aluno " + this.nome_aluno + " removeu a disciplina de " + Console.ReadLine());

        }
        public void realizarMatricula()
        {
            Console.WriteLine("O aluno " + this.nome_aluno + " foi matriculado ");
            Console.WriteLine("Matrícula: " + this.mat);

        }
    }
}
