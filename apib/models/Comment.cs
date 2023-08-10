namespace apib.Models;

// Comment Entity:
// - CommentId (int): The unique identifier for the comment.
// - PostId (int): The foreign key to associate the comment with its parent post.
// - Text (string): The content of the comment.
// - CreatedAt (DateTime): The date and time when the comment was created.

public class Comment{

    public int PostId {get; set; }

    public int CommentId {get; set;}

    public string Text {get; set;} = "";

    public DateTime CreatedAt {get; set; } 

    public virtual  Post Post {get; set;} 
}
