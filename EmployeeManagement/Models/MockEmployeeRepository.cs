namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employees;
        public MockEmployeeRepository()
        {
            _employees = new List<Employee>() { 
                //Added phone number
                new Employee(){Id=1,Name="Robert",Department="IT",Email="Demo123@gmail.com",Phonenumber="123456789"},
                new Employee(){Id=2,Name="Angela",Department="IT",Email="Demo233@gmail.com",Phonenumber="232323232"},
                new Employee(){Id=3,Name="betty",Department="HR",Email="Demo007@gmail.com",Phonenumber="2323232323"},
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
