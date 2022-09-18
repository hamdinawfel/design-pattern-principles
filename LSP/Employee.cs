﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class Employee : BaseEmployee, IManaged
    {

        public IEmployee Manager { get; set; }
        
        public virtual void AssignManager(IEmployee manager)
        {
            Manager = manager;
        }

    }
}
