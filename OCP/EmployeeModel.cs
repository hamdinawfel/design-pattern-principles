using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class EmployeeModel
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }

        public bool IsManager { get; set; } = false;
        public bool IsExecutive { get; set; } = false;
        public bool IsStaff { get; set; } = true;

    }
}
