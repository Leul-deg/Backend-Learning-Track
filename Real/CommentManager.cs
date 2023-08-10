using System;
using System.Linq;
using Real.data;
using Real.models;
namespace Real.CommentManager;

public class CommentManager
{
    public static bool CreateComment(string content, int postId, BloggingContext context)
    {
        var comment = new Comment { Content = content, PostId = postId };
        context.Comments.Add(comment);
        context.SaveChanges();
        return true;
    }

    public static bool UpdateComment(int commentId, string newContent, BloggingContext context)
    {
        var comment = context.Comments.Find(commentId);
        if (comment == null)
            return false;

        comment.Content = newContent;
        context.SaveChanges();
        return true;
    }

    public static bool DeleteComment(int commentId, BloggingContext context)
    {
        var comment = context.Comments.Find(commentId);
        if (comment == null)
            return false;

        context.Comments.Remove(comment);
        context.SaveChanges();
        return true;
    }

    public static Comment RetrieveCommentById(int commentId, BloggingContext context)
    {
        var comment = context.Comments.Find(commentId);
        return comment;
    }
}