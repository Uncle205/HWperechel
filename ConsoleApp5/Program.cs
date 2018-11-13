using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*Создать массив сотрудников.Длина массива задается пользователем, заполнение массива производится им же.Выполнить следующее:
вывести полную информацию обо всех сотрудниках;
найти в массиве всех менеджеров, зарплата которых больше средней зарплаты всех клерков, вывести на экран полную информацию о таких менеджерах отсортированной по их фамилии.
распечатать информацию обо всех сотрудниках, принятых на работу позже босса, отсортированную в алфавитном порядке по фамилии сотрудника.*/
namespace StructuereHW
{
    struct Worker
    {
        public string name;
        public int Salary;
        public DateTime DateOfStartWork;
        public Vacancies Vacancy;
    }
    public enum Vacancies //перечисление
    {
        Manager, Boss, Clerk, Salesman
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Worker> employeers = new List<Worker>();
            Console.WriteLine("Введите размерность массива");
            int a = int.Parse(Console.ReadLine());
            int n = Convert.ToInt32(a);
            
            for (int i = 0; i < n; i++)

            {Console.WriteLine("Введите имя");
                employeers.Add(new Worker()
                {
                    name = Console.ReadLine()
                });
                Console.WriteLine("Введите зарплату");
                employeers.Add(new Worker()
                {
                    Salary = Convert.ToInt32(Console.ReadLine())
                });
                Console.WriteLine("Введите ДАТУПОСТУПЛЕНИЯ");
                employeers.Add(new Worker()
                {
                    DateOfStartWork = DateTime.Parse(Console.ReadLine()),
                });
                Console.WriteLine("Введите Вакансию");
                employeers.Add(new Worker()
                {
                    Vacancy = (Vacancies)Convert.ToInt32(Console.ReadLine())
                });
               

               
                i++;
                if (employeers[i].Vacancy == Vacancies.Boss)
                {
                    DateTime date = employeers[i].DateOfStartWork;
                    if (employeers[i++].DateOfStartWork > date)
                    {
                        Console.WriteLine(employeers[i++].name);
                        Console.WriteLine(employeers[i++].Salary);
                        Console.WriteLine(employeers[i++].Vacancy);
                    }
                }





                //employeers[n].vacancy=(Console.ReadLine());
                //Console.WriteLine("Введите дату принятия на работу");
                //employeers[n].DateOfStartWork = Console.ReadLine();
            }
            Console.WriteLine("Введите среднюю зарплату клерка ");
            string clerk = Console.ReadLine();
            int clerkzp = int.Parse(clerk);
            if (employeers[n].Salary > clerkzp)
            {
                Console.WriteLine("Менеджеры у которых зп больше чем я клерка:");
                Console.WriteLine(employeers[n].name, employeers[n].Salary, employeers[n].Vacancy, employeers[n].DateOfStartWork);
            }

        }

    }
}





