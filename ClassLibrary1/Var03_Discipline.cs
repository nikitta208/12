namespace ClassLibrary1
{
    class Var03_Discipline
    {
        private string name;
        private string abbreviation;

        public Var03_Discipline(string name, string abbreviation)
        {
            this.name = name;
            this.abbreviation = abbreviation;
        }

        public string GetDisciplineInfo()
        {
            string disciplineInfo = "Дисциплина: " + name + "\n" + "Сокращение: " + abbreviation;
            return disciplineInfo;
        }
    }
}

