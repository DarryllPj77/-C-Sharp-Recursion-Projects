namespace Value_Parameters;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Practice 1 to appreciate Different Parameter Types");
        int num1 = 10;
        Increment(num1);
        Console.WriteLine(num1);

        // Implement the ref parameter
        int num2 = 10;
        Increment(ref num2);
        Console.WriteLine(num2);

        // Implement the out parameter
        int num3;
        IncrementA(out num3);
        Console.WriteLine(num3);

        // Implement the in parameter
        int num4 = 100;
        IncrementB(num4);
        Console.WriteLine(num4);
    }

    static void Increment(int value)
    {
        value++;
    }

    static void Increment(ref int value)
    {
        value++;
    }

    static void IncrementA(out int value)
    {
        value = 40;
        value += value;
    }

    static void IncrementB(in int value)
    {
        //Console.WriteLine(value);
    }
}
