namespace PetShopApp.API.DTOs
{
    public class OrderDto
    {

        public Guid Id { get; set; }
        public DateTime? CreatedDate { get; set; }

        //Foreign Key

        public Guid UserID { get; set; }


        public Guid ProductID { get; set; }
    }
}
