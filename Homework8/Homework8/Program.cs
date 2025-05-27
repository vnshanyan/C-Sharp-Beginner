using static System.Net.Mime.MediaTypeNames;
using System.Buffers.Text;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Reflection;
using System.Xml.Linq;
using System;
using System.ComponentModel;

namespace Homework8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1: Age Group Categorizer(Conditional Operator `?:`)
            //**Scenario * *: You’re helping a clinic categorize patients based on age.
            //Requirements:
            //Ask the user to input their age.
            //Use the ** conditional operator ** to determine their group:
            //       *Age < 13 → "Child"
            //       * Age 13–17 → "Teenager"
            //       * Age 18–64 → "Adult"
            //       * Age 65 + → "Senior"
            //📌 **Output example * *:
            //Enter your age: 45
            //You are an: Adult
            //```
            //> 🔁 Use nested conditional operators for multiple conditions.

            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            string status = "";
            status = age >= 65 ? status = "Senior" : age >= 18 ? status = "Adult" : age >= 13 ? status = "Teenager" : status = "Child";
            Console.WriteLine(status);

            //Task 2: Optional Discount Code(Null - Coalescing `??`)
            //* *Scenario * *: An online store allows users to enter an optional discount code.
            //Requirements:
            //*Ask the user to input a discount code(or press Enter to skip).
            //* Use `??` to replace a `null` or empty string with `"NO CODE ENTERED"`.
            //*Display the discount code used.
            //📌 **Output example * *:
            //Enter discount code: [User presses Enter]
            //Discount applied: NO CODE ENTERED
            //> 💡 Hint: Use `string.IsNullOrWhiteSpace()` + `??` for robustness.

            Console.WriteLine("Enter discount code:");
            string input = Console.ReadLine();
            string discountCode = string.IsNullOrWhiteSpace(input) ? null : input;
            discountCode = discountCode ?? "NO CODE ENTERED";
            Console.WriteLine(discountCode);

            //Task 3: Product Description Fallback(`?.` and `??`)
            //* *Scenario * *: A shopping cart may have some missing product descriptions.
            //Requirements:
            //*Create a `Product` class with :
            //  * `Name` (string)
            //  * `Description` (string?, nullable)
            //* Create 2–3 product instances, some with `Description = null`.
            //* Use the **null-conditional operator ** (`?.`) and**null-coalescing operator ** (`??`) to display:
            //  * `product.Description ?? "No description available"`
            //📌 **Output example**:
            //Product: Headphones
            //Description: High-quality sound
            //Product: Cable
            //Description: No description available

            Product product1 = new Product();
            product1.Name = "Headphones";
            product1.Description = "High-quality sound";
            Console.WriteLine(product1.Name);
            Console.WriteLine(product1.Description ?? "No description available");

            Product product2 = new Product();
            product2.Name = "Cable";
            product2.Description = null;
            Console.WriteLine(product2.Name);
            Console.WriteLine(product2.Description ?? "No description available");

            //Task 4: Fallback Username (Chained `??`)**
            //**Scenario**: An app generates display names with multiple fallback options.
            //Requirements:
            //* Ask the user for: `preferredName`, `nickname`, and `username`.
            //* Use **chained `??` operators** to display the first available:
            //  * `preferredName ?? nickname ?? username ?? "Guest"`
            //📌 **Output example**:
            //Preferred name: [empty]
            //Nickname: [empty]
            //Username: john_doe
            //Hello, john_doe!

            Console.WriteLine("Preferred name: ");
            string preferredName = Console.ReadLine();
            Console.WriteLine("Nickname: ");
            string nickname = Console.ReadLine();
            Console.WriteLine("Username: ");
            string username = Console.ReadLine();

            string info = string.IsNullOrWhiteSpace(preferredName) ? null : preferredName;
            info = info ?? (string.IsNullOrWhiteSpace(nickname) ? null : nickname);
            info = info ?? (string.IsNullOrWhiteSpace(username) ? null : username);
            info = info ?? "Guest";
            Console.WriteLine($"Hello {info}");

            //Task 5: Safe Object Access with Null - Conditional Operator(`?.`) * *
            //**Scenario * *: You’re accessing a property from a possibly null object.
            //Requirements:
            //*Create a `User` class with a nullable `Profile` property.
            //* `Profile` contains a string `Bio`.
            //* Use `?.` to safely access `user.Profile?.Bio`.
            //* Use `??` to provide a fallback if `Bio` is null.
            //📌 **Output example**:
            //User bio: No bio set.

            User user1 = new User();
            user1.Profile = null;
            User user2 = new User();
            user2.Profile = new Profile();
            user2.Profile.Bio = "Profile111";
            User user3 = new User();
            user3.Profile = new Profile();
            user3.Profile.Bio = null;

            Console.WriteLine("User1: " + (user1.Profile?.Bio ?? "No bio set."));
            Console.WriteLine("User2: " + (user2.Profile?.Bio ?? "No bio set."));
            Console.WriteLine("User3: " + (user3.Profile?.Bio ?? "No bio set."));
        }
    }

    internal class Product
    {
        public string Name { set; get; }
        public string? Description { set; get; }

    }

    internal class User
    {
        public Profile? Profile { get; set; }
    }

    internal class Profile
    {
        public string? Bio { get; set; }
    }
}
