/*	Program that calculates the take-home pay for an employee. 
 *	The two types of employees are salaried and hourly. 
 *	Allow the user to input the employee’s first and last name, id, and type. 
 *	If an employee is salaried, allow the user to input the salary amount. 
 *	If an employee is hourly, allow the user to input the hourly rate and the number of hours clocked for the week. 
 *	For hourly employees, overtime is paid for hours over 40 at a rate of 1.5 of the base rate. 
 *	For all employees’ take-home pay, federal tax of 18% is deducted. 
 *	A retirement contribution of 10% and a Social Security tax rate of 6% should also be deducted.
 */


using System;

namespace Question4.WEEK5
{
    class Program
    {
        static void Main(string[] args)
        {
            string yn;
            Employee employee = new Employee();

            Console.WriteLine("Enter the Employee's first name: ");
            employee.FirstName = Console.ReadLine();

            Console.WriteLine("Enter the Employee's last name: ");
            employee.LastName = Console.ReadLine();

            Console.WriteLine("Enter the Employee's ID number: ");
            employee.EmpID = Console.ReadLine();

            Console.WriteLine("Is the Employee paid hourly? (y/n): ");
            yn = Console.ReadLine();
            if (yn == "y" || yn == "Y")
            {
                employee.Salary = 0;
                Console.WriteLine("Enter how many dollars per hour the emploee makes: ");
                employee.Hourly = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter how many hours the employee clocked in: ");
                employee.HoursClocked = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                employee.Hourly = 0;
                Console.WriteLine("Enter the employee's salary: ");
                employee.Salary = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(employee.ToString());
        }
    }
}
