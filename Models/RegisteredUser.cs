using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Proj3_Aftaabuddin.Models
{
    public class RegisteredUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public String Address { get; set; }
        [Required]
        public String City { get; set; }

        [Required]
        public String Zip { get; set; }

        [Required]
        public String State { get; set; }
        [Required]
        [Range(0, 1000000, 
            ErrorMessage = "Value must be between 0 and 1000000.")]
        public int YearlySalary { get; set; }
        [Required]
        public Boolean dealerContact { get; set; }
        [Required]
        public String FirstTime { get; set; }
        [Required]
        public string MyOption { get; set; }
        [Required]
        public String Username { get; set; }

        [Required]
        public string Password { get; set; }
        public DateTime RegistrationDate { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "The password doesn't match, please try again.")]
        [NotMapped]
        public String PasswordConfirm { get; set; }
        [Required]
        public Boolean Newsletter { get; set; }
        
    }
    
}
