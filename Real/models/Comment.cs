namespace Real.models;

public class Comment{

    public int Id{get; set;}

    public string Content{get; set;} = "";
    public int PostId { get; set; } // Required foreign key property
    public Post Post { get; set; } = null!; // R



}