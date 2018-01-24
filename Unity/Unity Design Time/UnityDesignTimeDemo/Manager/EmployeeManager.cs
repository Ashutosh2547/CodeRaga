using System;

namespace UnityDesignTimeDemo
{
    public class EmployeeManager: IEmployeeManager
    {

        private IEmployee employee;

        public EmployeeManager(IEmployee employee)
        {
            this.employee = employee;
        }


        public int GetSalary()
        {
            return employee.GetEmployeeSalary();
        }

        public void SetSalary(int salary)
        {
            employee.SetEmployeeSalary(salary);
        }

    }
}