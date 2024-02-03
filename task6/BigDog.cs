namespace task6;
public class BigDog : Dog
{
    public BigDog(string name) : base(name){}
    public override void Greet()
    {
        System.Console.WriteLine("Wooow");
    }
    public override void Greet(Dog dog)
    {
        System.Console.WriteLine("Woooooow");
    }
    public void Greet(BigDog bigDog)
    {
        System.Console.WriteLine("Wooooooooow");
    }
}