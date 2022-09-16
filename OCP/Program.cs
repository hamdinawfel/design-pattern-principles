using System.Threading.Channels;

namespace OCP;

class Program
{
    static void Main(string[] args)
    {

        List<PersonelModel> candidates = new List<PersonelModel>()
        {
             new PersonelModel { FirstName = "Craig", Lastname = "Doe" },
             new PersonelModel { FirstName = "Nawfel", Lastname = "Hamdi" },
        };

        List<EmployeeModel> employess = new List<EmployeeModel>();

        Accounts accountPressors = new Accounts();

        foreach (var person in candidates)
        {
            employess.Add(accountPressors.Create(person));
        }

        foreach (var employee in employess)
        {
            Console.WriteLine($"{employee.FirstName} {employee.Lastname} {employee.Email}");
        }
    }
}