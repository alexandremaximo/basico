using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExeFuncionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionarios> lista = new List<Funcionarios>();

            Console.Write("How many employees will be registered? ");
            int emp = int.Parse(Console.ReadLine());

            for (int cnt = 1; cnt <= emp; cnt++)
            {
                Console.WriteLine("Emplyoee #" + cnt);

                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                lista.Add(new Funcionarios(id, name, salary));

            }

            Console.WriteLine("List of employee: ");
            foreach(Funcionarios obj in lista)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
            Console.Write("Enter the employee id that will have salary increase: ");
            emp = int.Parse(Console.ReadLine());

            Funcionarios func = lista.Find(x => x.Id == emp);

            if (func != null)
            {
                Console.Write("Enter the percentage: ");
                func.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Funcionarios obj in lista)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
