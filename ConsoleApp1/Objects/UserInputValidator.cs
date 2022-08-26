using ConsoleApp1.Interfaces;

namespace ConsoleApp1;

public class UserInputValidator
{
    public static readonly List<Type> AllowedTypes = new() { typeof(string), };

    public static bool Validate(object objectToValidate, ref bool isRunning)
    {
        bool isValid = false;
        
        var type = objectToValidate.GetType();

        foreach (var typeAllowed in AllowedTypes)
        {
            if (type == typeAllowed)
            {
                isValid = true;
                break;
            }
        }

        if (objectToValidate is string && (string)objectToValidate == "/q")
        {
            isRunning = false;
        }

        return isValid;
    }
}