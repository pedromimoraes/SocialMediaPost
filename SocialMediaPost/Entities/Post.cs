using System.Text;

namespace SocialMediaPost.Entities
{
    class Post
    {
        public DateTime Moment { get; private set; }
        public string Title { get; private set; }
        public string Content { get; private set; }
        public int Likes { get; private set; }
        public List<Comment> Comments { get; private set; } = new List<Comment>();
        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }
        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }
        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(Title);
            builder.Append(Likes);
            builder.Append(" Likes - ");
            builder.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            builder.AppendLine(Content);
            builder.AppendLine("Comments:");

            foreach (Comment comment in Comments)
            {
                builder.AppendLine(comment.Text);
            }
            return builder.ToString();
        }
    }
}