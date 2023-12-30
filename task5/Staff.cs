class Staff : Person
{
    private string School;
    private double Pay;
    public Staff(string name, string address, string school, double pay) : base(name, address) 
    {
        School = school;
        Pay = pay;
    }
    public string GetSchool()
    {
        return School;
    }
    public void SetSchool(string school)
    {
        School = school;
    }
    public double GetPay()
    {
        return Pay;
    }
    public void SetPay(double pay)
    {
        Pay =pay;   
    }
    public override string ToString()
    {
        return $"{base.ToString()}\nShool: {School}\nPay: {Pay}";
    }
}