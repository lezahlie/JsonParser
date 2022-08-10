using System.ComponentModel.DataAnnotations;

namespace AttributeProject  {
    public class UserLogin   {

        [Key]
        [Required]
        public int Id {set;get;}

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_]{5,25}$", ErrorMessage = "UserName requires 5-25 length with alphanumic and '_' chars only")]
        public string UserName {set;get;}
   
        [NoJson]
        [Required]
        [RegularExpression(@"^(?=.*?[A-Z])(?=.*?[0-9])[a-zA-Z0-9!@#$%&*.]{8,}$", ErrorMessage ="Password requires 8 length, 1 Capital, 1 Digit no spaces. Special Allowed={'!','#','$','%','&','*','.'}")]
        public string Password {set;get;}


        public override string ToString() {
            return $"{nameof(Id)}: {Id}, {nameof(UserName)}: {UserName}, {nameof(Password)}: {Password}";
        }

    }
}




