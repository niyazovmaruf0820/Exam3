namespace task6;
class Cat : Animal
{
    public Cat(string name) : base(name){}
    public override void Greet()
    {
        System.Console.WriteLine("Meow");
    }
}