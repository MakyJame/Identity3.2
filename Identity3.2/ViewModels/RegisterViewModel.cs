using System.ComponentModel.DataAnnotations;

namespace Identity3._2.ViewModels
{
    public class RegisterViewModel
    {
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        public string FullName { get; set; }
    }
}
