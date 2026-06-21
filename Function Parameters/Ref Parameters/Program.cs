using System.Runtime.CompilerServices;

namespace Ref_Parameters;

class Program
{
    static void Main(string[] args)
    {
        // Rules:
        // The variable must be initialized before passing to ref.
        // Changes made inside the method reflect in the calling scope.

        // calling scope

        Console.WriteLine("Practice 1 to appreciate Ref Parameter");
        int num = 10;
        Increment(ref num);
        Console.WriteLine(num);

        Console.WriteLine("Practice 2 to appreciate Ref Parameter");
        string name = "Dog";
        Update(ref name);
        Console.WriteLine(name);

        Console.WriteLine("Practice 3 to appreciate Ref Paramete with multiple ref Parameters and arguments");
        int num1 = 10;
        int num2 = 20;
        int num3 = 30;
        int result = Add(ref num1, ref num2, ref num3);
        Console.WriteLine(result);
        

    }

    // Increment Method
    static void Increment(ref int value)
    {
        value++;
    }

    static void Update(ref string updateName)
    {
        if(updateName == "Dog")
        {
            Console.WriteLine("Matched!");
        }
        updateName = "Cat";
    }

    static int Add(ref int num1, ref int num2,  ref int num3)
    {       
        return num1 + num2 + num3;
    }
}
