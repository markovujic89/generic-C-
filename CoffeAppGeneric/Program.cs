
using System;
using CoffeeAppGeneric.Data;
using CoffeeAppGeneric.Entities;
using CoffeeAppGeneric.Extensions;
using CoffeeAppGeneric.Repositories;

namespace CoffeeAppGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            // First part of Tutorial (only implementation of Generic class SimpleStack<T>
            StackDoubles();
            StackStrings();
            Console.WriteLine("========================================");
            // Second part
            PrintOrganizationAndEmployees();

            Console.ReadLine();
        }

        private static void PrintOrganizationAndEmployees()
        {
            var employees = new SQLRepository<Employee>(new StorageAppDbContext());
            AddEmployees(employees);
            AddManager(employees);
            GetByIdExample(employees);

            employees.Save();
            WriteAllToConsole(employees);
            Console.WriteLine("=============================================");
            var organizations = new SQLRepository<Organization>(new StorageAppDbContext());
            AddOrganizations(organizations);

            organizations.Save();
            WriteAllToConsole(organizations);
        }

        private static void WriteAllToConsole(ISqlReadRepository<EntityBase> repository)
        {
            var items = repository.GetAll();

            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        private static void GetByIdExample(ISqlRepository<Employee> _items)
        {
            var employee = _items.GetById(1);

            Console.WriteLine($"Employee with id 1: {employee.Name}");
        }

        private static void AddOrganizations(ISqlRepository<Organization> organizationRepository)
        {
            var organizations = new[]
            {
                new Organization { Name = "enjoy.ing" },
                new Organization { Name = "ATT" }

            };

            organizationRepository.AddBatch(organizations);
            
        }

        private static void AddEmployees(ISqlRepository<Employee> employeeRepository)
        {
            var employees = new[]
            {
                new Employee { Name = "Marko" },
                new Employee { Name = "Katarina" },
                new Employee { Name = "Katarina" }

            };

            employeeRepository.AddBatch(employees);
        }

        

        

        private static void AddManager(ISqlWriteRepository<Manager> managers)
        {
            managers.Add(new Manager { Name = "Styv" });
        }

        private static void StackDoubles()
        {
            var simpleStack = new SimpleStack<double>();
            simpleStack.Push(1.2);
            simpleStack.Push(4.6);
            simpleStack.Push(7.1);

            var sum = 0.0;

            while (simpleStack.Count > 0)
            {
                var item = simpleStack.Pop();
                Console.WriteLine($"Items: {item}");
                sum += item;
            }

            Console.Write($"Sum: {sum}");
        }

        private static void StackStrings()
        {
            var simpleStack = new SimpleStack<string>();

            simpleStack.Push("marko");
            simpleStack.Push("katarina");
            simpleStack.Push("sofija");

            while (simpleStack.Count > 0)
            {
                var item = simpleStack.Pop();
                Console.WriteLine($"{item}");
            }
        }
    }
}
