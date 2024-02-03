public abstract class Animal
{
    private string name { get; set; }
    public Animal(string name)
    {
        this.name = name;
    }
    public abstract void Greet();
}