using System;
using System.Globalization;

namespace LiçãoIBM_05_08_2022 {
    class Program {
        static void Main(string[] args) {

            int NumFunc = Convert.ToInt32(Console.ReadLine());
            int QtdHoras = Convert.ToInt32(Console.ReadLine());
            double ValorHora = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Salario = (ValorHora * QtdHoras);

            Console.WriteLine($"Number = {NumFunc}");
            Console.WriteLine($"Salary = U$ {Salario.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.ReadKey();

        }
    }
}
