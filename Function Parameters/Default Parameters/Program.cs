namespace Default_Parameters;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Default (Optional) Parameters");
        // default parameter
        Print();
        Print("Darryll");

        // Named parameter
        AddString(first: "Darryll ", last: " J ", middle: "Pajaganas");
        
        // Params Parameter
        int a = Sum(1,2,3,4,5);


        Console.WriteLine("Params Result");
        Console.WriteLine(a);

    }

    static void Print(string name = "Pogi") // default parameter
    {
        Console.WriteLine(name);
    }

    static void AddString(string first, string middle, string last)
    {
        Console.WriteLine(first+middle+last);
    }

    static int Sum(params int[] numbers)
    {
        int total = 0;
        foreach (var n in numbers)
        {
            total += n;
        }
        return total;
    }
}
