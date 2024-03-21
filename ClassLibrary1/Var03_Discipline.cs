using System;

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

        // Метод для получения информации о дисциплине
        public void GetDisciplineInfo()
        {
            Console.WriteLine("Дисциплина: " + name);
            Console.WriteLine("Сокращение: " + abbreviation);
        }
    }
}


