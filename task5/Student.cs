class Student : Person
{
    private string Program;
    private int Year;
    private double Fee;
    public Student(string name, string address, string program, int year, double fee) : base(name, address) 
    {
        Program = program;
        Year = year;
        Fee = fee;
    }
    public string GetProgram()
    {
        return Program;
    }
    public void SetProgram(string program)
    {
        Program = program;
    }
    public int GetYear()
    {
        return Year;
    }
    public void SetYear(int year)
    {
        Year = year;
    }
    public double GetFee()
    {
        return Fee;
    }
    public void SetFee(double fee)
    {
        Fee = fee;
    }
    public override string ToString()
    {
        return $"{base.ToString()}\nProgram: {Program}\nYear: {Year}\nFee: {Fee}";
    }
}