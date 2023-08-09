using System;

namespace BaiTapVeMang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Enter number
            try
            {
                Console.WriteLine("Enter the number of employees (1-100): ");
                byte n = byte.Parse(Console.ReadLine());
                Employee[] employees = new Employee[n];


                if (n <= 100)
                {
                    for (int i = 0; i < employees.Length; i++)
                    {
                        employees[i] = new Employee(); // Create a new Employee object

                        employees[i].ID = (i + 1);

                        Console.WriteLine("\n");

                        Console.Write("Enter name: ");
                        employees[i].Name = Console.ReadLine();

                        Console.Write("Enter age: ");
                        employees[i].Age = byte.Parse(Console.ReadLine());

                        Console.Write("Enter salary: ");
                        employees[i].Salary = double.Parse(Console.ReadLine());
                    }


                    // List employees
                    Console.WriteLine("\nList employees: ");

                    for (int i = 0; i < employees.Length; i++)
                    {
                        Console.WriteLine($"Employee: {i + 1}: ID = {employees[i].ID}:" +
                            $" Name = {employees[i].Name}: Age = {employees[i].Age}:" +
                            $" Salary = {employees[i].Salary}");
                    }


                    // Sort the array by salary in desc order
                    Console.WriteLine("\nSort the array by salary in desc order: ");

                    Array.Sort(employees, (x, y) =>
                    {
                        return y.Salary.CompareTo(x.Salary);
                    });


                    for (int i = 0; i < employees.Length; i++)
                    {
                        Console.WriteLine($"Employee: {i + 1}: ID = {employees[i].ID}:" +
                            $" Name = {employees[i].Name}: Age = {employees[i].Age}:" +
                            $" Salary = {employees[i].Salary}");
                    }


                    Console.Write("\nEnter a name to search for: ");
                    string searchName = Console.ReadLine();

                    bool found = false;
                    for (int i = 0; i < employees.Length; i++)
                    {
                        if (employees != null && employees[i].Name == searchName)
                        {
                            Console.WriteLine($"Employee: {i + 1}: ID = {employees[i].ID}:" +
                           $" Name = {employees[i].Name}: Age = {employees[i].Age}:" +
                           $" Salary = {employees[i].Salary}");
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine("\nEmployee not found.");
                    }
                }
                else
                {
                    Console.WriteLine("Employee count must be between 1 and 100.");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }


            Console.ReadLine();
        }
    }
}
