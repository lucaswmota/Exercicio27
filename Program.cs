using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o salario do funcionario: ");
            double salario = double.Parse(Console.ReadLine());

            Console.Write("Digite o % de INSS: ");
            double inss = double.Parse(Console.ReadLine());

            salario -= salario * (inss / 100);

            Console.Write("Digite o % de Pensão: ");
            double pensao = double.Parse(Console.ReadLine());

            salario -= salario * (pensao / 100);

            Console.Write("Salario FInal: " + salario.ToString("C"));

            Console.ReadKey();

        }
    }
}
