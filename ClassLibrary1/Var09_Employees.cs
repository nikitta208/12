using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Var09_Employees
    {
        private string name = "";
        private string surname = "";
        private string patronymic = "";
        private Var10_Post post;

        public Var09_Employees(string name, string surname, string patronymic, string post)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Post = post;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Patronymic
        {
            get { return patronymic; }
            set { patronymic = value; }
        }
        public string Post
        {
            get { return post.ToString(); }
            set { post = Var10_Post.ToString(value); }
        }
        internal static Var09_Employees ToString(string value)
        {
            throw new NotImplementedException();
        }
    }
}
