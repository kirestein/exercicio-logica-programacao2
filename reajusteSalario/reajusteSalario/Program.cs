using System;

namespace reajusteSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 0, taxa = 0, novoSalario = 0;
            string nome;
            do
            {
                Console.WriteLine("Digite o seu nome: ");
                nome = Console.ReadLine();
                Console.WriteLine("Digite o valor do seu salário atual: ");
                string entradaSalario = Console.ReadLine();
                salario = Convert.ToDouble(entradaSalario);
                Console.WriteLine("Digite o percentual do aumento: ");
                string entradaTaxa = Console.ReadLine();
                taxa = Convert.ToDouble(entradaTaxa);

                novoSalario = salario + (salario * (taxa / 100));

                Console.WriteLine("Olá " + nome + ", o seu novo salário é: R$" + Math.Round(novoSalario, 2));
            } while (nome != string.Empty);
        }
    }
}
