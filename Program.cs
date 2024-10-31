public class Homework_8
{
    public static void Main()
    {
        int example = 0;

        WithoutRef(example);
        Console.WriteLine(example); 
        
        WithRef(ref example);
        Console.WriteLine(example);

        WithIn(example);
        Console.WriteLine(example);

        WithOut(out example);
        Console.WriteLine(example);
    }


    private static void WithoutRef(int value)
    {
        value += 5;
    }

    private static void WithRef(ref int value)
    {
        value += 10;
    }

    private static void WithIn(in int value)
    {
        Console.WriteLine("Can't be change");
        //value += 0; ERROR
    }

    private static void WithOut(out int value)
    {
        Console.WriteLine("Should be change");
        value = 5;
    }
}