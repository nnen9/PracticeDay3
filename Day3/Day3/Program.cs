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

            void TaskA1(double argument)
            {
                double up = 0;
                double arg = argument;
                foreach (var emp in employees)
                {
                    up = emp.Salary * arg;
                    Console.WriteLine("Зарплата " + emp.Fio + " повышена до " + up);
                }
            }

            void TaskB1()
            {
                Console.WriteLine("Напишите отдел для определения минимальной зарплаты: ");
                double depart = Convert.ToDouble(Console.ReadLine());
                double min = 999999;
                foreach (var emp in employees)
                {
                    if (emp.Salary < min)
                    {
                        if (emp.Department == depart)
                        {
                            min = emp.Salary;
                        }
                    }
                }
                Console.WriteLine("Минимальная зарплата отдела: " + min);
            }

            void TaskB2()
            {
                Console.WriteLine("Напишите отдел для определения максимальной зарплаты: ");
                double depart = Convert.ToDouble(Console.ReadLine());
                double max = 0;
                foreach (var emp in employees)
                {

                    if (emp.Salary > max)
                    {
                        if (emp.Department == depart)
                        {
                            max = emp.Salary;
                        }
                    }
                }
                Console.WriteLine("Максимальная зарплата отдела: " + max);
            }

            void TaskB3()
            {
                Console.WriteLine("Напишите отдел для определения средней зарплаты: ");
                int count = 0;
                double sum = 0;
                double depart = Convert.ToDouble(Console.ReadLine());
                foreach (var emp in employees)
                {
                    if (emp.Department == depart)
                    {
                        count++;
                        sum += emp.Salary;
                    }
                }
                Console.WriteLine($"Средняя зарплата отдела: {sum / count}");
            }

            void TaskB4(double argument)    
            {
                Console.WriteLine("Напишите отдел для увеличения зарплаты: ");
                double depart = Convert.ToDouble(Console.ReadLine());
                double up = 0;
                double arg = argument;
                foreach (var emp in employees)
                {
                    if (emp.Department == depart)
                    {
                        up = emp.Salary * arg;
                        Console.WriteLine("Зарплата " + emp.Fio + " увеличина до " + up);
                    }
                }
            }

            void TaskB5()
            {
                Console.WriteLine("");
                Console.WriteLine("Напишите отдел для показа сотрудников: ");
                double depart = Convert.ToDouble(Console.ReadLine());
                foreach (var emp in employees)
                {
                    if (emp.Department == depart)
                    {
                        Console.WriteLine($"Id: {employee.Id()} ФИО: {emp.Fio}, Зарплата: {emp.Salary}");
                    }
                }
            }

            void TaskC1()
            {
                Console.WriteLine("Вывод зарплат меньше чем: ");
                double val = Convert.ToDouble(Console.ReadLine());
                foreach (var emp in employees)
                {
                    if (emp.Salary < val)
                    {
                        Console.WriteLine($"Id: {employee.Id()} ФИО: {emp.Fio}, Зарплата: {emp.Salary}");
                    }
                }
            }

            void TaskC2()
            {
                Console.WriteLine("Вывод зарплат больше чем: ");
                double val = Convert.ToDouble(Console.ReadLine());
                foreach (var emp in employees)
                {
                    if (emp.Salary > val)
                    {
                        Console.WriteLine($"Id: {employee.Id()} ФИО: {emp.Fio}, Зарплата: {emp.Salary}");
                    }
                }
            }

            TaskA1(1.1);
            Console.WriteLine();
            TaskB1();
            Console.WriteLine();
            TaskB2();
            Console.WriteLine();
            TaskB3();
            Console.WriteLine();
            TaskB4(1.1);
            Console.WriteLine();
            TaskB5();
            Console.WriteLine();
            TaskC1();
            Console.WriteLine();
            TaskC2();
            Console.WriteLine();
        }
    }
}