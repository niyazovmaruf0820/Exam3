using task6;

Cat cat = new Cat("Eyva");
cat.Greet();

System.Console.WriteLine();

Dog dog1 = new Dog("Bublic");
dog1.Greet();

Dog dog2 = new Dog("Bublic");
dog2.Greet(dog1);

System.Console.WriteLine();

BigDog bigDog1 = new BigDog("Polvon");
bigDog1.Greet();
bigDog1.Greet(dog1);

BigDog bigDog2 = new BigDog("Polvon");
bigDog2.Greet(bigDog1);


