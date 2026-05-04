namespace ProductsApp_Task2.Models
{
    public class ProductModel
    {
             public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }
        public CategoryModel Category { get; set; }


    }
}
