using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

namespace ClassLibrary1
{
    public class Var01_Class 
    {
        internal static Var02_TheAudience ToString(string value)
        {
            throw new NotImplementedException();
        }

        private DateTime dateTime;
        private Var09_Employees employees;
        private Var02_TheAudience theAudience;
        private Var04_Group group;
        private Var07_Couple couple;
        private Var14_Classes classes;

        public string datetime
        {
            get { return dateTime.ToString(); }
            set { dateTime = DateTime.Parse(value); }
        }
        public string Employees
        {
            get { return employees.ToString(); }
            set { employees = Var09_Employees.ToString(value); }
        }
        public string TheAudience
        {
            get { return theAudience.ToString(); }
            set { theAudience = Var02_TheAudience.ToString(value); }
        }
        public string Group
        {
            get { return group.ToString(); }
            set { group = Var04_Group.ToString(value); }
        }
        public string Couple
        {
            get { return couple.ToString(); }
            set { couple = Var07_Couple.ToString(value); }
        }
        public string Classes
        {
            get { return classes.ToString(); }
            set { classes = Var14_Classes.ToString(value); }
        }

        public Var01_Class(string dateTime, string discipline, string employees, string theAudience, string group, string couple, string classes)
        {
            datetime = dateTime;
            Employees = employees;
            TheAudience = theAudience;
            Group = group;
            Couple = couple;
            Classes = classes;
        }


    }
}
