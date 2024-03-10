using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Var10_Post
    {
        private string Name;
        
        public string name
        {
            get { return Name; }
            set => Name = value;
        }
        private string Salary;

        public string salary
        {
            get { return Salary; }
            set => Salary = value;
        }

        private Var11_Discipline division;
        
        public string Division
        {
            get { return division.ToString(); }
            set { division = Var11_Discipline.ToString(value); }
        }
        private Var10_Post(string Name, string salary,  string division)
        {            
            name = Name;
            Salary = salary;
            Division = division;
        }
        internal static Var10_Post ToString(string value)
        {
            throw new NotImplementedException();
        }
    }
}
