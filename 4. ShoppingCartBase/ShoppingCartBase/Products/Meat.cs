

namespace ShoppingCartVisitorExample.Products
{
    public class Meat : ProductBase
    {
         public bool IsFresh { get; set; }
        public string Type { get; set; }
        public Meat(int code, string name, string description, string category, double price, bool isFresh, string type)
            : base(code, name, description, category, price )
        {   
            IsFresh = isFresh;
            Type = type;    
        }

        public bool IsSuitableForGrilling()
        {
            return IsFresh && Type.ToLower().Contains("steak");
        }
    }
}
