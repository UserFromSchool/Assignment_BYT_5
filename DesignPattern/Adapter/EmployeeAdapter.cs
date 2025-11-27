// In case you need some guidance: https://refactoring.guru/design-patterns/adapter
namespace DesignPattern.Adapter
{
    public class EmployeeAdapter : ITarget
    {
        private readonly BillingSystem billingSystem = new();

        public void ProcessCompanySalary(string[,] employees)
        {
            List<Employee> employeesList = new List<Employee>();

            for (int i = 0; i < employees.GetLength(0); i++)
            {
                int id = int.Parse(employees[i, 0]);
                string name = employees[i, 1];
                string designation = employees[i, 2];
                decimal salary = decimal.Parse(employees[i, 3]);

                employeesList.Add(new Employee(id, name, designation, salary));
            }
            billingSystem.ProcessSalary(employeesList);
        }
    }
}
