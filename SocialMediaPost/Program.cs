using SocialMediaPost.Entities;
using System.Globalization;
using System.Net.NetworkInformation;

namespace SocialMediaPost
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Beautiful place!");
            Comment c2 = new Comment("Have a nice trip");
            Comment c3 = new Comment("I really love this place!");

            Post p1 = new Post(
                DateTime.ParseExact("10/07/2024 18:33:41","dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                "Traveling to Brazil",
                "I'm going to visit Rio de Janeiro in Brazil!",
                25
            );

            p1.AddComment(c1);
            p1.AddComment(c2);
            p1.AddComment(c3);

            System.Console.WriteLine(p1);
        }
    }
}


