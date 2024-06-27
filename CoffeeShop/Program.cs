class CoffeeShop
{
    public static void Main(String[] args)
    {
        string drinkName = Console.ReadLine();
        string extra = Console.ReadLine();
        decimal price = 0m;


        if (drinkName == "coffee")
        {
            price = 1.00m;
        }
        else
        {
            price = 0.60m;
        }

        if (extra == "sugar")
        {
            price += 0.40m;
        }

        Console.WriteLine($"Final price: ${price:F2}");
    }
}
