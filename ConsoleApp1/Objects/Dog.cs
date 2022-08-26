namespace ConsoleApp1;

public class Dog: AbstractAnimal
{
    public override string Name { get; }
    public override string Sound { get; }

    public Dog(string name, string dogSound = "Bark")
    {
        Name = name;
        Sound = dogSound;
    }

    // public void MakeSound()
    // {
    //     System.Console.WriteLine(Sound);
    // }
    
}