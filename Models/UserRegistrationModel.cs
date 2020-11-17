using System.ComponentModel.DataAnnotations;

namespace VAII.Models
{
    public class UserRegistrationModel
    {
        public UserRegistrationModel()
        {
            UsernameV = "";
            Username = "";
            FirstName = "";
            LastName = "";
            Password = "";
            ConfirmPassword = "";
        }

        public string UsernameV { get; set; }
        public string PasswordV => Password == null || (Password.Length < 5 || Password.Length > 25) ? "Password must be between 5 - 25" : "";
        public string ConfirmPasswordV => Password == null || (Password == "" || Password.Equals(ConfirmPassword)) ? "" : "The password and confirmation password do not match.";

        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

    }

}
