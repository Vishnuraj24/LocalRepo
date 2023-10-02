namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }

        //Adding the phone number by vishnuraj
        public string Phonenumber { get; set; }
    }
}
