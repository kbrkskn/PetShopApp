namespace PetShopApp.API.DTOs
{
    public class UserWithOrdersDto:UserDto
    {
        public ICollection<OrderDto> Orders { get; set; }
    }
}
