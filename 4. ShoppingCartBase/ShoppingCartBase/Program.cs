
using ShoppingCartVisitorExample.Products;

namespace ShoppingCartBase
{
    class Program
    {
        public static void Main(string[] args)
        {
            Fruit apple = new Fruit(1, "Apple", "Delicious apple", "Red", 1, "Poland", true);
            Meat meat = new Meat(2, "T-Bone Steak", "Delicious steak", "Meat",30, true, "steak");
            Drink coke = new Drink(3, "Coke", "Delicious coca-cola", "Non-sugar",300,5, "Cherry");

            ShoppingCart cart = new ShoppingCart();

            cart.AddProduct(apple);
            cart.AddProduct(meat);
            cart.AddProduct(coke);

            Console.WriteLine($"Total cost of items in the shopping cart: {cart.GetCartValue()}"); 
        
        }
    }
}
