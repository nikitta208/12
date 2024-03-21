using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Var02_TheAudience
    {
        private string name;
        private Var01_Class employee;
        private string Places;
        private string window;
        private Var01_Class equipment;
        internal static Var02_TheAudience ToString(string value)
        {
            throw new NotImplementedException();
        }

        public Var02_TheAudience(string name, Var01_Class employee, string Places, string window, Var01_Class equipment)
        {
            this.name = name;
            this.employee = employee;
            this.Places = Places;
            this.window = window;
            this.equipment = equipment;
        }

    }
}

