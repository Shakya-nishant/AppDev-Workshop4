

namespace Task_2;

public class Calculator
{
    public void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the calculator!");
    }
    public int add(int num1, int num2)
    {
        return num1 + num2;
    }
    public int multiply(int num1, int num2 = 1)
    {
        return num1 * num2;
    }
}