namespace Main.Observer
{
    public static class ObserverPractical
    {
        public static void Execute()
        {
            JohnPoliticalFigure lJohnPoliticalFigure = new JohnPoliticalFigure();
            lJohnPoliticalFigure.Attach(new Mike());
            lJohnPoliticalFigure.Attach(new Harry());

            lJohnPoliticalFigure.NewTweet("Lorem ipsum dolor sit amet, consectetur adipiscing");
            lJohnPoliticalFigure.NewTweet("Mauris vitae orci a dolor bibendum gravida");
        }
    }

    public abstract class TwitterProfile
    {
        protected List<TwitterFollower> _Followers = new List<TwitterFollower>();

        public void Attach(TwitterFollower prFollower)
        {
            _Followers.Add(prFollower);
        }

        public void Detach(TwitterFollower prFollower)
        {
            _Followers.Remove(prFollower);
        }

        protected void NotifyFollowers(string prTweet)
        {
            foreach (TwitterFollower lFollowerCurrent in _Followers)
            {
                lFollowerCurrent.NotifyNewTweet(prTweet);
            }
        }
    }

    public abstract class TwitterFollower
    {
        public abstract void NotifyNewTweet(string prTweet);
    }

    public class Mike : TwitterFollower
    {
        public override void NotifyNewTweet(string prTweet)
        {
            Console.WriteLine($"Notifying User \"Mike\"");
        }
    }

    public class Harry : TwitterFollower
    {
        public override void NotifyNewTweet(string prTweet)
        {
            Console.WriteLine($"Notifying User \"Harry\"");
        }
    }

    public class JohnPoliticalFigure : TwitterProfile
    {
        public void NewTweet(string prTweet)
        {
            Console.WriteLine("New Tweet from John: " + prTweet);
            NotifyFollowers(prTweet);
        }
    }
}