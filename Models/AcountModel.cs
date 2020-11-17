using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace VAII.Models
{
    public class AcountModel
    {
        public AcountModel()
        {
            Username = "";
            Password = "";
            LastName = "";
            FirstName = "";
        }
        public AcountModel(UserRegistrationModel userModel)
        {
            Username = userModel.Username;
            Password = userModel.Password;
            LastName = userModel.LastName;
            FirstName = userModel.FirstName;
        }
        [Key]
        [NotNull]
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [NotNull]
        public string Password { get; set; }
    }
}
