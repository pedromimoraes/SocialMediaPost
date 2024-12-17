namespace SocialMediaPost.Entities
{
    class Post
    {
        public DateTime Moment { get; private set; }
        public string Title { get; private set; }
        public string Content { get; private set; }
        public int Likes { get; private set; }
        public List<Comment> Comment { get; private set; } = new List<Comment>();
        public Post(DateTime moment, string title, string content, int likes)
        {

        }


    }
}