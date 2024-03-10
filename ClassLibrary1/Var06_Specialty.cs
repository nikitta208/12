using System;

public class Var06_Specialty
{
    private string name;
    private string sokrash;
    private DateTime date;
    
    public Var06_Specialty(string name, string sokra, DateTime? date = null)
    {
        name = name;
        sokra = sokra;
        date = date ?? DateTime.Today;
    }
    
    public string Name()
    {
        return name;
    }
    
    public string Sokr()
    {
        return sokrash;
    }
    
    public DateTime Date()
    {
        return date;
    }
}
