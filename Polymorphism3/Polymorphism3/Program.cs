namespace Polymorphism3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Abbas Quliyev", "A123", 20);

            Console.WriteLine($"Full Name: {student.FullName}");
            Console.WriteLine($"Group No: {student.GroupNo}");
            Console.WriteLine($"Age: {student.Age}");
        }
    }
}
