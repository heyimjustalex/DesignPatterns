
namespace ShoppingCartVisitorExample.Products
{
    public class Drink : ProductBase
    {
        public int VolumeInMilliliters { get; set; }
        public string Flavor { get; set; }
        public Drink(int code, string name, string description, string category, int volumeInMilliliters, string flavor) : base(code, name, description, category)
        {
            VolumeInMilliliters = volumeInMilliliters;
            Flavor = flavor;    
        }

        public string GetShortDescription()
        {
            return $"{Name} -> {Flavor} {VolumeInMilliliters}ml";
        }

    }
}
