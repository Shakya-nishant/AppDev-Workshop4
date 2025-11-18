namespace Task_3;

public class Program
{
    public static void Main(string[] args)
    {
        ParameterDemo p = new ParameterDemo();

        int value = 5;
        p.Increase(ref value);
        Console.WriteLine("Increased Value: " + value);

        string myFullName;
        p.GetFullName(out myFullName);
        Console.WriteLine("Full Name: " + myFullName);

        int result = p.SumAll(10, 20, 30, 40);
        Console.WriteLine("Sum of Numbers: " + result);
    }
}