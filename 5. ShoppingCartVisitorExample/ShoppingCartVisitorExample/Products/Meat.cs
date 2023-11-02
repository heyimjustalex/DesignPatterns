

namespace ShoppingCartVisitorExample.Products
{
    public class Meat : ProductBase
    {
        public double PricePerKilogram { get; set; }
        public bool IsFresh { get; set; }
        public string Type { get; set; }
        public Meat(int code, string name, string description, string category, double pricePerKilogram, bool isFresh, string type)
            : base(code, name, description, category)
        {
            PricePerKilogram = pricePerKilogram;
            IsFresh = isFresh;
            Type = type;    
        }

        public bool IsSuitableForGrilling()
        {
            return IsFresh && Type.ToLower().Contains("steak");
        }
    }
}
