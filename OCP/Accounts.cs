using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class Accounts
    {

        public EmployeeModel Create(PersonelModel person)
        {
            EmployeeModel output = new EmployeeModel();
            output.FirstName = person.FirstName;
            output.Lastname = person.Lastname;
            output.Email = $"{person.FirstName.Substring(0, 1)}-{person.Lastname}@campany.com";


          return output;
        }

    }
}
