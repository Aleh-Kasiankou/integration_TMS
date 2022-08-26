// See https://aka.ms/new-console-template for more information

using ConsoleApp1;

public class Program
{
    public static void Main()
    {
        bool isRunning = true;

        while (isRunning)
        {
            const string startMessage = "Hello, dear son. Today you are 14 and " +
                                        "we'd like to give you a little fluffy gift. This is your dog, how should we call it?";

            const string exitHint = "To reject a gift, please type '/q'";
            
            System.Console.WriteLine($"{startMessage}\n\n{exitHint}");
            
            string? name = System.Console.ReadLine();
            if (UserInputValidator.Validate(name, ref isRunning))
            {
                Dog YourDog = new Dog(name); 
                System.Console.WriteLine($"{YourDog.Name} is extremely happy and says {YourDog.MakeSound()}");
            }

        }
    }
}