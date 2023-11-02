using ShoppingCartVisitorExample.Products;

namespace ShoppingCartBase
{
    public class ShoppingCart
    {
        List<ProductBase> _products; 
       
        public ShoppingCart() {
            _products = new List<ProductBase>();    
        }   

        public void AddProduct(ProductBase product)
        {
            _products.Add(product); 
        }

        public double GetCartValue()
        {
            double value = 0;
            foreach(ProductBase product in _products) {

                value += product.Price;
            
            }
            return value;        
        }

    }
}
