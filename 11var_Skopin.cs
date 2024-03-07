using System;

public class Podrazdelenie
{
    private string name;
    private Employee head;
    private Organization organization;

    public Podrazdelenie(string name, Employee head, Organization organization)
    {
        this.name = name;
        this.head = head;
        this.organization = organization;
    }

    public string GetName()
    {
        return name;
    }

    public Employee GetHead()
    {
        return head;
    }

    public Organization GetOrganization()
    {
        return organization;
    }
}