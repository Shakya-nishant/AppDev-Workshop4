namespace Task_1;

public class Program
{
    public static void Main(string[] args)
    {
        Student S1 = new Student();
        Student S2 = new Student();

        S1.Name = "Ram";
        S1.Age = 21;
        S1.Address = "Dharan, Nepal";

        S2.Name = "Shyam";
        S2.Age = 22;
        S2.Address = "Kathmandu, Nepal";

        Console.WriteLine("Student 1 Details:");
        Console.WriteLine("Name: " + S1.Name);
        Console.WriteLine("Age: " + S1.Age);
        Console.WriteLine("Address: " + S1.Address);

        Console.WriteLine("\nStudent 2 Details:");
        Console.WriteLine("Name: " + S2.Name);
        Console.WriteLine("Age: " + S2.Age);
        Console.WriteLine("Address: " + S2.Address);

        Console.WriteLine("\nCollege Name: " + Student.CollegeName);
    }
}
