using System;
using Microsoft.EntityFrameworkCore;
using Real.models;
using Real.data;

namespace Real.Main;
public class Program
{
    public static void Main()
    {
        using (var context = new BloggingContext())
        {
            // Create a new blog
            // var post = new Post { Title = "Some Title" , Content = "Some Content" };
            // context.Posts.Add(post);
            // context.SaveChanges();

            // Retrieve all blogs
            // var posts = context.Posts.ToList();
            // foreach (var b in posts)
            // {
            //     Console.WriteLine($"Post Id: {b.Id}, Title: {b.Title}");
            // }

            
        }
    }
}