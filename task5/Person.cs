class Person
{
    private string Name;
    private string Address;
    public Person(string name, string address)
    {
        Name = name;
        Address = address;
    }
    public string GetName()
    {
        return Name;
    }
    public string GetAddress()
    {
        return Address;
    }
    public void SetAddress(string address)
    {
        Address = address;
    }
    public override string ToString(){
        return $"Name: {Name},\nAddress: {Address}";
    }
}

