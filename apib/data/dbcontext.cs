using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using  apib.Models;
namespace apib.Data;

public class ApiDbContext : DbContext{

    public virtual DbSet<Post> Posts {get; set;}

    public virtual DbSet<Comment> Comments {get; set;}

    public ApiDbContext(DbContextOptions options): base(options){


    }

     protected override void OnModelCreating(ModelBuilder modelBuilder){
        base.OnModelCreating(modelBuilder);

        //
        modelBuilder.Entity<Comment>(entity => {

            entity.HasOne(p => p.Post).WithMany(c=> c.Comments).HasForeignKey(x => x.PostId).OnDelete(DeleteBehavior.Restrict).HasConstraintName("Post");

        });

        modelBuilder.Entity<Post>().Property(p => p.CreatedAt)
            .HasDefaultValueSql("now()");
        
        modelBuilder.Entity<Comment>().Property(c => c.CreatedAt)
            .HasDefaultValueSql("now()");

    }



}