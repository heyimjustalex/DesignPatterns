
namespace ShoppingCartVisitorExample.Products
{
    public class Fruit : ProductBase
    {
        public string Origin { get; set; }
        public bool IsOrganic { get; set; }
        public Fruit(int code, string name, string description, string category, string origin, bool isOrganic) : base(code, name, description, category)
        {
            Origin = origin;
            IsOrganic = isOrganic;
        }
        public bool IsFresh()
        {
            // Checking the origin, weight, and shelf life.
            return true;
        }
    }
}
