namespace PetShopApp.MVC.DTOs
{
    public class UserWithOrdersDto:UserDto
    {
        public ICollection<OrderDto> Orders { get; set; }
    }
}
