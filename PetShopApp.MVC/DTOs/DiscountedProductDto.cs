namespace PetShopApp.MVC.DTOs
{
    public class DiscountedProductDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountedPrice { get; set; }
        public int Percent { get; set; }
        public bool IsActive { get; set; }

        public int ProductID { get; set; }
    }
}
