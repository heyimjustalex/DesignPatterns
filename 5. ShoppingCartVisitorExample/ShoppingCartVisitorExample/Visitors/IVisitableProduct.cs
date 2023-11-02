using ShoppingCartVisitorExample.Products;

namespace ShoppingCartVisitorExample.Visitors
{
    public interface IVisitableProduct
    {
        public void Visit(Drink drink);
        public void Visit(Fruit fruit);
        public void Visit(Meat meat);
    }
}
