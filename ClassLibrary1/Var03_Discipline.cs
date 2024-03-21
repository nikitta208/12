using System;

namespace ClassLibrary1
{
    private string name;
    private string abbreviation;

    public Discipline(string name, string abbreviation)
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

