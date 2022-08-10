using System.ComponentModel.DataAnnotations;

namespace AttributeProject  {
    public class UserInfo   {

        [RegularExpression(@"^[a-zA-Z]{1,30}$", ErrorMessage ="FirstName must be alpha only and less than 30 chars")]
        public string FirstName {set;get;}
       
        [NoJson]
        [Required]
        [RegularExpression(@"^[a-zA-Z]{1,30}$", ErrorMessage ="LastName must be alpha only and less than 30 chars")]
        public string LastName {set;get;}
       
        [Required]
        [EmailAddress]
        public string EmailAddress {set;get;}

        [Required]
        [Phone]
        [NoJson]
        public string PhoneNumber {set;get;}

        public override string ToString() {
            return $"{nameof(FirstName)}: {FirstName}, {nameof(LastName)}: {LastName}, {nameof(EmailAddress)}: {EmailAddress}, {nameof(PhoneNumber)}: {PhoneNumber}";
        }

    }
}
