namespace apib.Models;
using System;

// PostId (int): The unique identifier for the post.
// - Title (string): The title of the blog post.
// - Content (string): The content of the blog post.
// - CreatedAt (DateTime): The date and time when the post was created.
public class Post{

    public Post(){

        Comments = new HashSet<Comment>();
    }

    public int PostId {get; set;}

    public string Title {get; set;} = "";

    public  string  Content {get; set;} = "";

    public DateTime CreatedAt {get; set;}

    public virtual ICollection<Comment> Comments {get; set;}

}