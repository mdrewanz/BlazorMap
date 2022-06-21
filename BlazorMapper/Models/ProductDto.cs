namespace BlazorMapper.Models
{
    public class ProductDto
    {
        public string ProductNumber { get; set; }
        public string ProductSearchName { get; set; }
        public string ProductName { get; set; }

        //public static Func<Product, ProductDto> ProductFunc = (product) =>
        //    new ProductDto
        //    {
        //        ProductNumber = product.ProductNumber,
        //        ProductSearchName = product.ProductSearchName,
        //        ProductName = product.ProductName
        //    };
    }
}
