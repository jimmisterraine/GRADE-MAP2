using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapa_de_notas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULADORA DE DESEMPENHO ESCOLAR");
            Console.WriteLine(" ");

            Console.WriteLine("INSTRUÇÕES");
            Console.WriteLine("Preencha com sua nota nos espaços solicitados");
            Console.WriteLine("Separe as casas decimais usando vírgula *,*");
            Console.WriteLine("Exemplo: Nota de PORTUGUÊS - 9,7");
            Console.WriteLine("Pressione ENTER para iniciar");
            Console.ReadLine();

            Console.WriteLine("Digite o seu nome: ");
            string User = Console.ReadLine();

            Console.WriteLine("Digite sua nota na disciplina de PORTUGUÊS.");
            float Portugues = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua nota na disciplina de MATEMÁTICA.");
            float Matematica = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua nota na disciplina de CIÊNCIAS.");
            float Ciencias = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua nota na disciplina de INGLÊS.");
            float Ingles = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua nota na disciplina de HISTÓRIA.");
            float Historia = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua nota na disciplina de GEOGRAFIA.");
            float Geografia = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua nota na disciplina de FILOSOFIA.");
            float Filosofia = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua nota na disciplina de LITERATURA.");
            float Literatura = float.Parse(Console.ReadLine());

            float soma = Portugues + Matematica + Ciencias + Historia + Geografia + Literatura + Filosofia + Ingles;
            float media = soma / 8;

            if (media >= 6)
            {
                Console.WriteLine(User + ", sua média é ****" + media + "****. Continue assim, parabéns!!!");
            }
            else if (media < 6)
            {
                Console.WriteLine( User + ", sua média é ****" + media + "****. Se dedique mais para melhorar!");
            }
            else
            {
                return;
            }

            Console.WriteLine("Execução finalizada. Pressione ENTER para encerrar");

        }
    }
}
