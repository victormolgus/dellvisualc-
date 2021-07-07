using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina2
{
    public class Professor
    {
        //Coloco os atributos em privado
        private String nome_professor;
        private int num_carteira;
        private float salario;

        //Defino o construtor da classe
        public Professor(string nome_professor, int num_carteira, float salario)
        {
            this.nome_professor = nome_professor;
            this.num_carteira = num_carteira;
            this.salario = salario;
        }

        //Defino os setters e getters
        public void setNome_Professor(String nome_professor)
        {
            this.nome_professor = nome_professor;
        }

        public String getNome_Professor()
        {
            return this.nome_professor;
        }

        public void setNum_Carteira(int num_carteira)
        {
            this.num_carteira = num_carteira;
        }

        public int getNum_Carteira()
        {
            return this.num_carteira;
        }

        public void setSalario(float salario)
        {
            this.salario = salario;
        }

        public float getSalario()
        {
            return this.salario;
        }

        //Defino os métodos
        public void postarConteudo()
        {
            Console.WriteLine("Insira o nome da disciplina");
            Console.WriteLine("Professor " + this.nome_professor + " postando o conteúdo: " + Console.ReadLine());

        }
        public void realizarChamada()
        {
            Console.WriteLine("Professor " + this.nome_professor + " fazendo a chamada");

        }
    }
}
