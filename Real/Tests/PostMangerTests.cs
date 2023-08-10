using NUnit.Framework;
using Real.data;
using Real.PostManager;

[TestFixture]
public class PostManagerTests
{
    private BloggingContext _context;

    [SetUp]
    public void SetUp()
    {
        _context = new BloggingContext();
    }

    [TearDown]
    public void TearDown()
    {
        _context.Dispose();
    }

    [Test]
    public void CreatePost_ShouldCreateNewPost()
    {
        // Arrange
        var initialPostCount = _context.Posts.Count();
        var title = "Test Post";
        var content = "This is a test post.";

        // Act
        var result = PostManager.CreatePost(title, content, _context);

        // Assert
        Assert.IsTrue(result);
        Assert.AreEqual(initialPostCount + 1, _context.Posts.Count());
    }

    [Test]
    public void UpdatePost_ShouldUpdateExistingPost()
    {
        // Arrange
        var postId = 1;
        var newTitle = "Updated Post";
        var newContent = "This post has been updated.";

        // Act
        var result = PostManager.UpdatePost(postId, newTitle, newContent, _context);

        // Assert
        Assert.IsTrue(result);
        var updatedPost = _context.Posts.Find(postId);
        Assert.AreEqual(newTitle, updatedPost.Title);
        Assert.AreEqual(newContent, updatedPost.Content);
    }

    [Test]
    public void DeletePost_ShouldDeleteExistingPost()
    {
        // Arrange
        var postId = 1;
        var initialPostCount = _context.Posts.Count();

        // Act
        var result = PostManager.DeletePost(postId, _context);

        // Assert
        Assert.IsTrue(result);
        Assert.AreEqual(initialPostCount - 1, _context.Posts.Count());
        var deletedPost = _context.Posts.Find(postId);
        Assert.IsNull(deletedPost);
    }

    [Test]
    public void RetrievePostById_ShouldRetrieveExistingPost()
    {
        // Arrange
        var postId = 1;
        var expectedTitle = "Test Post";
        var expectedContent = "This is a test post.";

        // Act
        var retrievedPost = PostManager.RetrievePostById(postId, _context);

        // Assert
        Assert.IsNotNull(retrievedPost);
        Assert.AreEqual(expectedTitle, retrievedPost.Title);
        Assert.AreEqual(expectedContent, retrievedPost.Content);
    }
}