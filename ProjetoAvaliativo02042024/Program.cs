using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAvaliativo02042024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string con = "S";
            int vd = 0;
            int ve = 0;
            int va = 0;
            int vm = 0;

            while (con == "S")
            {
                Console.WriteLine("Bem vindo(a) ao Cursos Bons");
                Console.WriteLine("___________________________________________________________________________");
                Console.WriteLine("área de matricula");
                Console.WriteLine("");
                Console.Write("Nome: ");
                string n = Console.ReadLine();
                Console.Write("Idade: ");
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine("(D)esenvolvimento | (M)ecatronica | (E)dificações | (A)diministração ");
                Console.Write("Curso desejado: ");
                string cd = Console.ReadLine().ToUpper();
                Console.Clear();

                switch (cd)
                {
                    case "D":
                        vd++;
                        if (vd >= 5)
                        {
                            Console.WriteLine("Cursos Bons");
                            Console.WriteLine("___________________________________________________________________________");
                            Console.WriteLine("");
                            Console.WriteLine("Não foi possivel fazer a matricula. O número máximo de vagas do curso já foi preenchida");
                        }
                        else
                        {
                            Console.WriteLine("Cursos Bons");
                            Console.WriteLine("___________________________________________________________________________");
                            Console.WriteLine("");
                            Console.WriteLine("matricula feita no curso de Desenvolvimento.");
                        }
                        
                        break;

                    case "E":
                        ve++;
                        if (ve >= 5)
                        {
                            Console.WriteLine("Cursos Bons");
                            Console.WriteLine("___________________________________________________________________________");
                            Console.WriteLine("");
                            Console.WriteLine("Não foi possivel fazer a matricula. O número máximo de vagas do curso já foi preenchida");
                        }
                        else
                        {
                            Console.WriteLine("Cursos Bons");
                            Console.WriteLine("___________________________________________________________________________");
                            Console.WriteLine("");
                            Console.WriteLine("matricula feita no curso de Edificações.");
                        }
                        break;
                    case "A":
                        va++;
                        if (va >= 5)
                        {
                            Console.WriteLine("Cursos Bons");
                            Console.WriteLine("___________________________________________________________________________");
                            Console.WriteLine("");
                            Console.WriteLine("Não foi possivel fazer a matricula. O número máximo de vagas do curso já foi preenchida");
                        }
                        else
                        {
                            Console.WriteLine("Cursos Bons");
                            Console.WriteLine("___________________________________________________________________________");
                            Console.WriteLine("");
                            Console.WriteLine("matricula feita no curso de Adiministração.");
                        }
                        break;

                    case "M":
                        vm++;
                        if (vm >= 5)
                        {
                            Console.WriteLine("Cursos Bons");
                            Console.WriteLine("___________________________________________________________________________");
                            Console.WriteLine("");
                            Console.WriteLine("Não foi possivel fazer a matricula. O número máximo de vagas do curso já foi preenchida");
                        }
                        else
                        {
                            Console.WriteLine("Cursos Bons");
                            Console.WriteLine("___________________________________________________________________________");
                            Console.WriteLine("");
                            Console.WriteLine("matricula feita no curso de Mecatrônica.");
                        }
                        break;
                }
                Console.WriteLine("___________________________________________________________________________");
                Console.WriteLine("deseja matricular mais um aluno? ('S' para sim e 'N' para não)");
                con = Console.ReadLine().ToUpper();
                Console.Clear();
            }
           
            Console.WriteLine("Totais de Matriculas em Desenvolvimento: "+vd);
            Console.WriteLine("Totais de Matriculas Mecatrônica: " + vm);
            Console.WriteLine("Totais de Matriculas em Edificações: " + ve);
            Console.WriteLine("Totais de Matriculas em Adiministração: " + va);

            Console.ReadKey();
        }
    }
}
