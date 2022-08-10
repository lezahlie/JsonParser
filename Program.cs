using System;

namespace AttributeProject  {
    public class Program {
        static void Main(string[] args) {

            UserLogin ul1 = new UserLogin() {
                Id = 1,
                UserName = "Lezahlie",
                Password = "P@$$w0rd",
            };

            UserInfo ui1 = new UserInfo() {
                FirstName= "Leslie",
                LastName = "Horace",
                PhoneNumber = "123-45-6789",
                EmailAddress= "lezalie@domain.com"
            };
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine($"User Login: {ul1}");
            string jsonStr1 = MyJsonParser.parse(ul1);
            Console.WriteLine($"MyJsonParser Results: {jsonStr1}");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine($"User Info: {ui1}");
            string jsonStr2 = MyJsonParser.parse(ui1);
            Console.WriteLine($"MyJsonParser Results: {jsonStr2}");
            Console.WriteLine("--------------------------------------------------------------------------------------");
        }
    }
}
