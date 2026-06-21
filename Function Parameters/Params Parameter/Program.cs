namespace Params_Parameter;

class Program
{
    static void Main(string[] args)
    {
        // numbers of data to be input
        Console.WriteLine("Params Parameter");
        int[] numberValue;
        while (true)
        {
            Console.Write("Enter the numbers of data to be inputed: ");
            if(int.TryParse(Console.ReadLine(), out int numbersOfData))
            {
                Console.WriteLine($"The numbers of data you will input is only {numbersOfData}. ");
                numberValue = new int[numbersOfData];
                break;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }


        // number's value to be input
        for (int i = 0; i < numberValue.Length; i++)
        {

            while (true)
            {
                Console.Write($"Enter number #{i + 1}:");
                if(int.TryParse(Console.ReadLine(), out int num))
                {
                    numberValue[i] = num;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }

        int result = Sum(numberValue);
        Console.Write("Results: ");
        Console.Write(result);

        //int a = Sum(1,2,3,4,5);
        // Console.Write("Result: ");
        // Console.Write(result);
    }

    static int Sum(params int[] numbers)
    {
        int total = 0;
        foreach (int n in numbers)
        {
            total += n;
        }
        return total;
    }
}
