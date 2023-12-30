public abstract class Animal
{
    private string Name { get; set; }
    public Animal(string name)
    {
        Name = name;
    }
    public abstract void Greet();
}