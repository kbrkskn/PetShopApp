namespace PetShopApp.MVC.DTOs
{
    public class OrderDto
    {

        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }

        //Foreign Key

        public int UserID { get; set; }


        public int ProductID { get; set; }
    }
}
