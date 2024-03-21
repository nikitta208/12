using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal class Var02_TheAudience
    {
        private string name;
        private Var1_Class employee;
        private string Places;
        private string window;
        private Var1_Class equipment;
        internal static Var02_TheAudience ToString(string value)
        {
            throw new NotImplementedException();
        }

        public Var02_TheAudience(string name)
        {
            this.employee = employee;
        }
        public Var02_TheAudience(Var1_Class employee)
        {
            this.employee = employee;
        }
        public Var02_TheAudience(string Places)
        {
            this.Places = Places;
        }
        public Var02_TheAudience(string window)
        {
            this.window = window;
        }
        public Var02_TheAudience(Var1_Class equipment)
        {
            this.equipment = equipment;
        }

    }
}
