
namespace ShoppingCartVisitorExample.Products
{
    public class Fruit : ProductBase
    {
        public string Origin { get; set; }
        public bool IsOrganic { get; set; }
        public Fruit(int code, string name, string description, string category, double price, string origin, bool isOrganic) : base(code, name, description, category, price)
        {
            Origin = origin;
            IsOrganic = isOrganic;
        }
        public bool IsFresh()
        {
            // Checking shelf life.
            return true;
        }
    }
}
