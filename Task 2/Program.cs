namespace Task_2;

public class Program
{
    public static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        calculator.WelcomeMessage();
        int sum = calculator.add(5, 10);
        int product1 = calculator.multiply(5);
        int product2 = calculator.multiply(5, 3);
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Product with one argument (5 * 1): {product1}");
        Console.WriteLine($"Product with two arguments (5 * 3): {product2}");
    }
}