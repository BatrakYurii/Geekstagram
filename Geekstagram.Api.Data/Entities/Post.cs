using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geekstagram.Api.Data.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string? Subscription { get; set; }
        public DateTime Created { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Like> Likes { get; set; }
    }
}
