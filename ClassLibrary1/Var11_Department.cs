using System;

namespace ClassLibrary1
{
    class Department
    {
        private string _name;
        private Employee _manager;
        private Var12_Organisation _organization;

        public Department(string name, Employee manager, Var12_Organisation organization)
        {
            _name = name;
            _manager = manager;
            _organization = organization;
        }
    }
}
