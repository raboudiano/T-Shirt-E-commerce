using System.ComponentModel.DataAnnotations;

namespace T_Shirt_E_commerce.ViewModels
{
    public class LoginViewModel
    {
        [Required] public string Username { get; set; }
        [Required][DataType(DataType.Password)] public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}