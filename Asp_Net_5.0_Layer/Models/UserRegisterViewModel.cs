using System.ComponentModel.DataAnnotations;

namespace Asp_Net_5._0_Layer.Models
{
    public class UserRegisterViewModel
    {
        [Display(Name ="Name Surname")]
        [Required(ErrorMessage ="Please enter name and surname")]
        public string NameSurname { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please enter password")]
        public string Password { get; set; }

        [Display(Name = "ConfirmPassword")]
        [Required(ErrorMessage = "Cannot confirm password!")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Gmail Adress")]
        [Required(ErrorMessage = "Please enter gmail adress")]
        public string Mail { get; set; }

        [Display(Name = "User Name")]
        [Required(ErrorMessage = "Please enter User Name")]
        public string UserName { get; set; }

    }
}
