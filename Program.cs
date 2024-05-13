using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5numInfluencer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Influencer
            List<Influencer> influencers = new List<Influencer>()
            {
                new Influencer("The Clashers", 1200000, "Top 10"),
                new Influencer("MartoStudio", 20, "Gaming"),
                new Influencer("RadoDanceBg", 890, "Dance"),
                new Influencer("VikataTuber", 2960, "Music"),
                new Influencer("Dude Perfect", 10000000, "Photography"),
                new Influencer("ZnakaProds", 999, "Dance")
            };

            // descending
            var sortedInfluencers = influencers.OrderByDescending(i => i.CountOfSubscribers);
            Console.WriteLine("Influencers sorted by subscriber count (descending):");
            foreach (var influencer in sortedInfluencers)
            {
                Console.WriteLine(influencer);
            }

            // with > 1000 subscribers
            var influencersWithMoreThan1000Subs = influencers.Where(i => i.CountOfSubscribers > 1000);
            Console.WriteLine("\nInfluencers with > 1000 subscribers: ");
            foreach (var influencer in influencersWithMoreThan1000Subs)
            {
                Console.WriteLine(influencer);
            }

            //  Dance or Photography
            var influencersInDanceOrPhotography = influencers.Where(i => i.SubjectOfInfluence == "Dance" || i.SubjectOfInfluence == "Photography");
            Console.WriteLine("\nInfluencers in Dance or Photography:");
            foreach (var influencer in influencersInDanceOrPhotography)
            {
                Console.WriteLine(influencer);
            }
        }
    }
}
