using System;

namespace _5numInfluencer
{
    public class Influencer
    {
        public string Nickname { get; set; }
        public int CountOfSubscribers { get; set; }
        public string SubjectOfInfluence { get; set; }

        public Influencer(string nickname, int countOfSubscribers, string subjectOfInfluence)
        {
            Nickname = nickname;
            CountOfSubscribers = countOfSubscribers;
            SubjectOfInfluence = subjectOfInfluence;
        }

        public override string ToString()
        {
            return $"Channel Name: {Nickname}, Subscribers Count: {CountOfSubscribers}, Subject: {SubjectOfInfluence}";
        }
    }
}
