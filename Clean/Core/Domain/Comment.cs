namespace Clean.models;
using Clean.BaseEntity;

public class Comment : BaseEntity{

    public int PostId { get; set; } // Required foreign key property
    public Post Post { get; set; } = null!; // R 
}
