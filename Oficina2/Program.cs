using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Oficina2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Defino quatro objetos, dois para instanciar a classe aluno e dois para professor
            Aluno a1 = new Aluno("Matt Murdock", 12345, "daredevil@gmail.com");
            Aluno a2 = new Aluno("Foggy Nelson", 67890, "nelson@gmail.com");
            Professor p1 = new Professor("Charles Xavier", 7987987, 2500);
            Professor p2 = new Professor("Otto Octavius", 1253456, 2700);

            //Aqui exibo os dados dos dois alunos
            Console.WriteLine("Aluno 1");
            Console.WriteLine("--------");
            Console.WriteLine(a1.getNome_Aluno());
            Console.WriteLine(a1.getEmail());
            Console.WriteLine(a1.getMat());
            Console.WriteLine();

            Console.WriteLine("Aluno 2");
            Console.WriteLine("--------");
            Console.WriteLine(a2.getNome_Aluno());
            Console.WriteLine(a2.getEmail());
            Console.WriteLine(a2.getMat());
            Console.WriteLine();

            //Aqui exibo os dados dos dois professores
            Console.WriteLine("Professor 1");
            Console.WriteLine("--------");
            Console.WriteLine(p1.getNome_Professor());
            Console.WriteLine(p1.getNum_Carteira());
            Console.WriteLine(p1.getSalario());
            Console.WriteLine();

            Console.WriteLine("Professor 2");
            Console.WriteLine("--------");
            Console.WriteLine(p2.getNome_Professor());
            Console.WriteLine(p2.getNum_Carteira());
            Console.WriteLine(p2.getSalario());
            Console.WriteLine();


            //Aqui exibo os métodos da classe aluno
            a1.inserirDisciplina();
            Console.WriteLine();
            a2.removerDisciplina();
            Console.WriteLine();
            a1.realizarMatricula();
            Console.WriteLine();

            //a2.inserirDisciplina();
            //a1.removerDisciplina();
            //a2.realizarMatricula();

            //Aqui exibo os métodos da classe professor
            p1.postarConteudo();
            Console.WriteLine();
            p1.realizarChamada();
            Console.WriteLine();

            p2.postarConteudo();
            Console.WriteLine();
            p2.realizarChamada();
            Console.WriteLine();

            //Uso para que o programa se encerre após o clique de qualquer tecla
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();



        }
    }
}
