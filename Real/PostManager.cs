using Real.data;
using Real.models;

namespace Real.PostManager;

class PostManager{

    

    public static bool CreatePost(string title, string content, BloggingContext context){

        try{
         var post = new Post { Title = title, Content = content };
        context.Posts.Add(post);
        context.SaveChanges();

        return true;

        }

        catch (Exception){
            Console.WriteLine("Something went wrong while creating the post");
            return false;
        }

        
    }

    public static bool UpdatePost(int postId, string newTitle, string newContent, BloggingContext context)
    {
        var post = context.Posts.Find(postId);
        if (post == null)
            return false;

        post.Title = newTitle;
        post.Content = newContent;
        context.SaveChanges();
        return true;
    }

    public static bool DeletePost(int postId, BloggingContext context)
    {
        var post = context.Posts.Find(postId);
        if (post == null)
            return false;

        context.Posts.Remove(post);
        context.SaveChanges();
        return true;
    }

    public static Post RetrievePostById(int postId, BloggingContext context)
    {
        var post = context.Posts.Find(postId);
        return post;
    }

    
}

// public class PostManager
// {
//     public static bool CreatePost(string title, string content, BloggingContext context)
//     {
//         // Use the context object to interact with the database
//         // For example, you can create a new Post entity and add it to the context
       
//     }
// }