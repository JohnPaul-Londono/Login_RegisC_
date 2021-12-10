using System;
using System.ComponentModel.DataAnnotations;


namespace Login_RegisC_.Models
{
    public class LogUser
    {

        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}