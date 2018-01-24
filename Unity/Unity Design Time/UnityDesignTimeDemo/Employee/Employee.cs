using UnityDesignTimeDemo;

namespace UnityDesignTimeDemo
{
    public class Employee : IEmployee
    {
        private int employeeSalary;

        public void SetEmployeeSalary(int salary)
        {
            this.employeeSalary = salary;
        }

       public int GetEmployeeSalary()
        {
            return this.employeeSalary;
        }
    }
}

