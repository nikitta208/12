using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal class Var08_Smena
    {
        private string name;

        public Var08_Smena(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return $"Название смены: {name}";
        }

    }

}
