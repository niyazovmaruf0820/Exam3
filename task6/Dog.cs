class Dog : Animal
{
    public Dog(string name) : base(name){}
    public override void Greet()
    {
        System.Console.WriteLine("Woof");
    }
    public void Greet(Dog dog)
    {
        System.Console.WriteLine("Woooooooof");
    }
}