namespace ClassLibrary1
{
    using System;

    public class Disciplina
    {
        private string name;
        private string abbreviation;

        public Disciplina(string name, string abbreviation)
        {
            this.name = name;
            this.abbreviation = abbreviation;
        }

        public string GetName()
        {
            return name;
        }

        public string GetAbbreviation()
        {
            return abbreviation;
        }
    }
}
