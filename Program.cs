using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1
{
    
    class Person
    {
        public string name;
        public int age;
        public Person()
        {
            name = "неизвестно";
            age = 0;
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Персона: {0}, Возраст: {1}", name, age);
        }
    }
    class Employee : Person
    {
        public string department;
        public int salary;
        public Employee() : base()
        {
            department = "не указан";
            salary = 0;
        }

        public Employee(string name, int age, string department, int salary)
            : base(name, age)
        {
            this.department = department;
            this.salary = salary;
        }
        public new void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Должность: Служащий, Отдел: {0}, Зарплата: {1}", department, salary);
        }
    }
    class Worker : Employee
    {
        public string position;
        public string shift;
        public Worker() : base()
        {
            position = "рабочий";
            shift = "дневная";
        }

        public Worker(string name, int age, string department, int salary,
                     string position, string shift)
            : base(name, age, department, salary)
        {
            this.position = position;
            this.shift = shift;
        }
        public new void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Должность: {0}, Смена: {1}", position, shift);
        }
    }
    class Engineer : Employee
    {
        public string specialty;
        public int projectsCount;
        public Engineer() : base()
        {
            specialty = "инженер";
            projectsCount = 0;
        }

        public Engineer(string name, int age, string department, int salary,
                       string specialty, int projectsCount)
            : base(name, age, department, salary)
        {
            this.specialty = specialty;
            this.projectsCount = projectsCount;
        }
        public new void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Специальность: {0}, Проектов: {1}", specialty, projectsCount);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Иван Иванов", 35);
            Employee employee = new Employee("Петр Петров", 28, "Отдел кадров", 50000);
            Worker worker = new Worker("Алексей Сидоров", 42, "Цех №1", 45000, "Слесарь", "Дневная");
            Engineer engineer = new Engineer("Мария Козлова", 31, "Конструкторское бюро", 75000, "Механик", 12);
            Console.WriteLine("Иерархия классов: Служащий, Персона, Рабочий, Инженер");
            Console.WriteLine("=====================================================");

            Console.WriteLine("\n1. Персона:");
            person.DisplayInfo();

            Console.WriteLine("\n2. Служащий:");
            employee.DisplayInfo();

            Console.WriteLine("\n3. Рабочий:");
            worker.DisplayInfo();

            Console.WriteLine("\n4. Инженер:");
            engineer.DisplayInfo();
        }
    }
}