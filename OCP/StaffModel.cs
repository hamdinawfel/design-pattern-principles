using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class StaffModel: IApplicantModel
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public IAccounts AccountProcessor { get; set; } = new StaffAccounts();
    }
}
