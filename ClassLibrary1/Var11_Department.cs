using System;


public class Department
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

