using Microsoft.Practices.Unity.Configuration;
using System;
using Unity;

namespace UnityDesignTimeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            UnityContainer container = new UnityContainer();
            container.LoadConfiguration();

            var employeeManager = container.Resolve<IEmployeeManager>();

            Console.WriteLine(employeeManager.GetSalary());
            employeeManager.SetSalary(10);
            Console.WriteLine(employeeManager.GetSalary());

            Console.ReadKey();
        }
    }
}
