using System;
using System.Collections.Generic;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("fio", 10000, 1);
            List<Employee> employees = new List<Employee>()
            {
                new ("Мельникова Ксения Витальевна", 15000, 2),
                new ("Иванова София Ивановна", 21500, 1),
                new ("Буракшаева Юлия Сергеевна", 335050, 4),
                new ("Фурсова Елизавета Владимировна", 400000, 5),
                new ("Сапсай Иван Алексеевич", 23000, 1),
                new ("Богословский Артем Михайлович", 60000, 3),
                new ("Самбикина Юлия Владимировна", 410000, 5),
                new ("Шпак Ангелина Эдуардовна", 25000, 2),
                new ("Пименов Максим Евгеньевич", 40000, 3),
                new ("Сигида Валерия Романовна", 65000, 4)
            };

            void TaskA()
            {
                Console.WriteLine("Task A");
                foreach (var emp in employees)
                {

                    Console.WriteLine($"Id: {employee.Id()} ФИО: {emp.Fio}, Зарплата: {emp.Salary}, Отдел: {emp.Department}");
                }
            }

            void TaskB()
            {
                Console.WriteLine("Task B");
                double summa = 0;
                foreach (var emp in employees)
                {
                    summa += emp.Salary;
                }
                Console.WriteLine($"Сумма затрат на зарплату в месяц: {summa}");
            }

            void TaskC()
            {
                Console.WriteLine("Task C");
                double min = 99999999999;
                foreach (var emp in employees)
                {
                    if (emp.Salary < min)
                    {
                        min = emp.Salary;
                    }
                }
                Console.WriteLine("Минимальная зарплата " + min);
            }

            void TaskD()
            {
                Console.WriteLine("Task D");
                double max = 0;
                foreach (var emp in employees)
                {
                    if (emp.Salary > max)
                    {
                        max = emp.Salary;
                    }
                }
                Console.WriteLine("Максимальная зарплата " + max);
            }

            void TaskE()
            {
                Console.WriteLine("Task E");
                int count = 0;
                double summa = 0;
                foreach (var emp in employees)
                {
                    count++;
                    summa += emp.Salary;
                }
                Console.WriteLine($"Среднее значение зарплаты: {summa / count}");
            }

            void TaskF()
            {
                Console.WriteLine("Task F");
                foreach (var emp in employees)
                {
                    Console.WriteLine("ФИО " + emp.Fio);
                }
                Console.ReadKey();
            }

            TaskA();
            Console.WriteLine();
            TaskB();
            Console.WriteLine();
            TaskC();
            Console.WriteLine();
            TaskD();
            Console.WriteLine();
            TaskE();
            Console.WriteLine();
            TaskF();
        }
    }
}