
namespace Task_3;

public class ParameterDemo
{
    public void Increase(ref int number)
    {
        number = number + 10;
    }

    public void GetFullName(out string fullname)
    {
        fullname = "Nishant Shakya";
    }

    public int SumAll(params int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum = sum + num;
        }
        return sum;
    }
}