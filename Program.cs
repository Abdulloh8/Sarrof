
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


            switch(message)
            {
                case "1": Console.Write("how many dollars : ");
                          dollars = Convert.ToDecimal(Console.ReadLine());
                          sum = dollars * 11600;
                       break;
                case "2": Console.Write("how many So'm : ");
                          sum = Convert.ToDecimal(Console.ReadLine());
                          dollars = sum / 11600;
                       break;
                default : Console.WriteLine("Error message");
                       break;          
            }
            
            string finsh;
            switch (message)
            {
                case "1": finsh = $"you can get {sum} So'm";
                    break;
                case "2": finsh = $"you can get {dollars} dollars";
                    break;  
                default : finsh = "Error message"; 
                    break;   
            };

            Console.WriteLine(finsh);
        }
    }
}

