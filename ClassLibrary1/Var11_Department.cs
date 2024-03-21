using System;

public class Var09_Employees
{
    public string Name { get; set; }
    public DateTime StartDate { get; set; }

    public Employee(string name, DateTime startDate)
    {
        Name = name;
        StartDate = startDate;
    }
}

public class Var12_Organisation
{
    public string Name { get; set; }

    public Organization(string name)
    {
        Name = name;
    }
}

public class Var11_Department
{
    private string _name;
    private Employee _manager;
    private Organization _organization;

    public Department(string name, Employee manager, Organization organization)
    {
        _name = name;
        _manager = manager;
        _organization = organization;
    }
}
