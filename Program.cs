using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("ii23", "Matias", "male", 35000);
            Employee employee2 = new Employee("io34", "Teo", "male", 43000);
            Employee employee3 = new Employee("ia35", "Sara", "female", 65000);
            Employee employee4 = new Employee("ie49", "Anna", "female", 43000);
            Employee employee5 = new Employee("iu46", "Tina", "female", 37000);

            Stack<Employee> EmployeeStack = new Stack<Employee>();
            EmployeeStack.Push(employee);
            EmployeeStack.Push(employee2);
            EmployeeStack.Push(employee3);
            EmployeeStack.Push(employee4);
            EmployeeStack.Push(employee5);

            Console.WriteLine("Skriv ut alla värden");
            foreach (var item in EmployeeStack)
            {
                Console.WriteLine(item);
                Console.WriteLine($"Det finns {EmployeeStack.Count} kvar.");
            }


            Console.WriteLine("Hämtar alla objekt med Pop");
            while (EmployeeStack.Count > 0)
            {
                Console.WriteLine(EmployeeStack.Pop());
                Console.WriteLine($"Det finns {EmployeeStack.Count} kvar.");
            }

            Console.WriteLine();
            EmployeeStack.Push(employee);
            EmployeeStack.Push(employee2);
            EmployeeStack.Push(employee3);
            EmployeeStack.Push(employee4);
            EmployeeStack.Push(employee5);

            Console.WriteLine("Hämtar två objekt med Peek");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(EmployeeStack.Peek());
                Console.WriteLine($"Det finns {EmployeeStack.Count} kvar.");
            }
            Console.WriteLine(" Söker efter om Employee3 finns i stacken");
            if (EmployeeStack.Contains(employee3))
                Console.WriteLine("Employee3 finns i stacken.");
            else
                Console.WriteLine("Employee3 finns inte i stacken.");

            List<Employee> employeeList = new List<Employee> { employee, employee2, employee3, employee4, employee5 };

            Console.WriteLine("Kolla om Employee2 finns i listan");
            if (employeeList.Contains(employee2))
                Console.WriteLine("Employee2 finns i listan");
            else
                Console.WriteLine("Employee2 finns inte i listan.");

            Console.WriteLine();
            Console.WriteLine("Hitta första objektet med värde 'Male'");
            Employee newMale = employeeList.Find(x => x.Gender == "Male");
            if (newMale != null)
                Console.WriteLine($"Första manliga anställd: {newMale}");

            Console.WriteLine("Söker efter alla objekt med värde = 'Male'");
            List<Employee> resultMales = employeeList.FindAll(emp => emp.Gender == "Male");
            if (resultMales.Count > 0)
            {
                foreach (var maleEmployee in resultMales)
                {
                    Console.WriteLine(maleEmployee);
                }
            }
            else
            {
                Console.WriteLine("Inga manliga anställda hittades.");
            }
        }
    }
}



