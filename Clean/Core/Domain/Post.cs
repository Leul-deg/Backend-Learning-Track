namespace Clean.models;
using Clean.BaseEntity;


public class Post : BaseEntity{


    public string Title{get; set;} = ""; 
    public ICollection<Comment> Comments { get; } = new List<Comment>(); // Collection navigation containing dependents
}
