using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matricula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            int D = 0;
            int A = 0;
            int M = 0;
            int E = 0;
            string resposta = "S";
            while (resposta == "S")
            {
                Console.WriteLine("Digite qual curso você quer se matricular: (D)Desenvolvimento, (A)Administração, (M)Mecatrônica e (E)Edificação: ");
                string curso = Console.ReadLine();
                switch (curso)
                {
                    case "D":
                        if (D < 5)
                        {
                            D++;
                            Console.WriteLine("Matrícula concluída.");
                        }
                        else
                        {
                            Console.WriteLine("Não foi possível fazer a matrícula.");
                        }
                        break;
                    case "A":
                        if (A < 5)
                        {
                            A++;
                            Console.WriteLine("Matrícula concluída.");
                        }
                        else
                        {
                            Console.WriteLine("Não foi possível fazer a matrícula.");
                        }
                        break;
                    case "M":
                        if (M < 5)
                        {
                            M++;
                            Console.WriteLine("Matrícula concluída.");
                        }
                        else
                        {
                            Console.WriteLine("Não foi possível fazer a matrícula.");
                        }
                        break;
                    case "E":
                        if (E < 5)
                        {
                            E++;
                            Console.WriteLine("Matrícula concluída.");
                        }
                        else
                        {
                            Console.WriteLine("Não foi possível fazer a matrícula.");
                        }
                        break;
                    default:
                        Console.WriteLine("erro");
                        break;
                }
                Console.WriteLine("Vagas sobrando: " +
                                  " Desenvolvimento: " + (5 - D) +
                                  "/  Administração: " + (5 - A) +
                                  "/  Mecatrônica: " + (5 - M) +
                                  "/  Edificações: " + (5 - E));
                Console.WriteLine("Deseja matricular mais um aluno? (S)im / (N)ão");
                resposta = Console.ReadLine().ToUpper().Substring(0, 1);
                Console.Clear();
            }
            Console.WriteLine("Alunos matriculados:" +
                              " Desenvolvimento: " + D +
                              "/  Administração: " + A +
                              "/  Mecatrônica: " + M +
                              "/  Edificações: " + E +
                              "/ Total de matrículas: " + (D + A + M + E));
            Console.ReadKey();


        }
    }
}
