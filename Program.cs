namespace Delegates
{
    internal class Program
    {
        public delegate void ShowMoney(double amount);

        static void Main(string[] args)
        {
            ShowMoney showMoney = ShowDollars;
            showMoney(100.50);

            showMoney = ShowEuros;
            showMoney(100.50);
        }

        public static void ShowDollars(double amount)
        {
            Console.WriteLine($"{amount.ToString("0.00")} $");
        }

        public static void ShowEuros(double amount)
        {
            Console.WriteLine($"{amount.ToString("0.00")} €");
        }
    }
}
