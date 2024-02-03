public class Dog : Animal
{
    public Dog(string name) : base(name){}
    public override void Greet()
    {
        System.Console.WriteLine("Woof");
    }
    public virtual void Greet(Dog dog)
    {
        System.Console.WriteLine("Woooof");
    }
}