using System.ComponentModel.DataAnnotations;

namespace PetShopApp.MVC.DTOs
{
    public class ProductDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        public string? Name { get; set; }
        [Range(1, double.MaxValue, ErrorMessage ="{0} alanı 0 dan büyük olmalıdır." )]
        public decimal Price { get; set; }
        [Range(1, double.MaxValue, ErrorMessage = "{0} alanı 0 dan büyük olmalıdır.")]
        public int Stock { get; set; } = 0;
        public string? Brand { get; set; }
        public string? Barcode { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsDeleted { get; set; } = false;

        public int SubCategoryID { get; set; }
        public int CategoryID { get; set; }







    }
}
