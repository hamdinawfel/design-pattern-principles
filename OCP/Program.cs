using System.Threading.Channels;

namespace OCP;

class Program
{
    static void Main(string[] args)
    {

        List<IApplicantModel> candidates = new List<IApplicantModel>()
        {
             new PersonModel { FirstName = "Craig", Lastname = "Doe" },
             new ManagerModel { FirstName = "Nawfel", Lastname = "Hamdi"},
             new StaffModel { FirstName = "Nao", Lastname = "Erics"},
        };

        List<EmployeeModel> employees = new List<EmployeeModel>();


        foreach (var person in candidates)
        {
            employees.Add(person.AccountProcessor.Create(person));
        }

        foreach (var employee in employees)
        {
            Console.WriteLine($"{employee.FirstName} {employee.Lastname} {employee.Email} IsManager : {employee.IsManager} IsExecutive : {employee.IsExecutive} IsStaff={employee.IsStaff}");
        }
    }
}