namespace Sarrof
{
    class Program
    {
        static void Main()
        {
            decimal sum = default;
            decimal dollars = default;

            Console.WriteLine("Hello, do you want to exchange many");
            Console.WriteLine("1. from Dollar to so'm : ");
            Console.WriteLine("2. from So'm to dollar : ");
            string message = Console.ReadLine();
            if(message == "1")
            {
                Console.Write("how many dollars : ");
                dollars = Convert.ToDecimal(Console.ReadLine());
                sum = dollars * 11600;
            }
            else if(message == "2")
            {
                Console.Write("how many So'm : ");
                sum = Convert.ToDecimal(Console.ReadLine());
                dollars = sum / 11600;
            }
            else
            {
                Console.WriteLine("Error message");
            }

            string finsh = (message == "1")
                         ? $"you can get {sum} So'm"
                         : (message == "2")
                         ? $"you can get {dollars} dollars"
                         : "Error message";

            Console.WriteLine(finsh);
        }
    }
}

