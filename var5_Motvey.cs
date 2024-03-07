namespace Motvey
{
    public class Info
    {
        private string name = "";
        private string surname = "";
        private string patronymic = "";
        private string birthday = "";
        private string link = "";

        public Info(string name, string surname, string patronymic, string birthday, string link)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Birthday = birthday;
            Link = link;
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
        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        public string Link
        {
            get { return link; }
            set { link = value; }
        }
    }
}
