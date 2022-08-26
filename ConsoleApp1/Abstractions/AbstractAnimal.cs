using ConsoleApp1.Interfaces;

namespace ConsoleApp1;

public class AbstractAnimal : IAudible
{
    public virtual string Name { get; } = "Fluffy";

    public virtual string Sound { get; } = "Shhhh";

    public virtual string MakeSound()
    {
        return Sound;
    }

}