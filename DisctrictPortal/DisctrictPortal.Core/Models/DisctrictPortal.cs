using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisctrictPortal.Core.Models
{
    public class Post
    {
        public int Id { get; set; } 
        public string Title { get; set; } = ""; 
        public string Content { get; set; } = ""; 
        public string? ImageUrl { get; set; } 
        public string Address { get; set; } = "";
        public DateTime CreatedAt { get; set; }

        public PostCategory Category { get; set; } 
        public string AuthorId { get; set; } = ""; 
        public User? Author { get; set; } 

        public List<Comment> Comments { get; set; } = new();
    }

    public enum PostCategory
    {
        News,       
        Problem,     
        Sale,        
        Service,     
        LostAndFound 
    }

    public class User
    {
        public string Id { get; set; } = "";
        public string Name { get; set; } = "";
        public string Phone { get; set; } = "";
        public string Address { get; set; } = ""; 

        public List<Post> Posts { get; set; } = new();
        public List<Comment> Comments { get; set; } = new();
    }

    public class Comment
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string Text { get; set; } = "";
        public string AuthorId { get; set; } = "";
        public DateTime CreatedAt { get; set; }

        public Post? Post { get; set; } 
        public User? Author { get; set; } 
    }

    public class MapMarker
    {
        public int Id { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Description { get; set; } = "";
        public string? PhotoUrl { get; set; }

        public MarkerStatus Status { get; set; } 
    }

    public enum MarkerStatus
    {
        New,       
        InProgress, 
        Resolved    
    }

}

