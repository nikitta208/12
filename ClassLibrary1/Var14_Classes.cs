using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal class Var14_Classes
    {
        internal static Var14_Classes ToString(string value)
        {
            throw new NotImplementedException();
        }
          
        private string name;

        public Var14_Classes(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return $"Вид занятия:{name}";
        }
    }
}
    

