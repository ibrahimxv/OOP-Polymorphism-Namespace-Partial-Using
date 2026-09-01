namespace Polymorphism
{
    internal class Program
    {
        static void Main()
        {
            OnlineOrder order = new OnlineOrder(1, "Televizor", 500, 2, 21);
            Console.WriteLine(order.GetDetail());
        }
    }
}
