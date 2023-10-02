namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employees;
        public MockEmployeeRepository()
        {
            _employees = new List<Employee>() { 
                new Employee(){Id=1,Name="Robert",Department="IT",Email="Demo123@gmail.com"},
                new Employee(){Id=2,Name="Angela",Department="IT",Email="Demo233@gmail.com"},
                new Employee(){Id=3,Name="betty",Department="HR",Email="Demo007@gmail.com"},
            };
        }

        public List<Employee> GetAllEmployees()
        {
            return _employees;
        }

        public Employee GetEmployee(int id)
        {
            return _employees.FirstOrDefault(e => e.Id == id);
        }
    }
}
