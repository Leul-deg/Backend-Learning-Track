using NUnit.Framework;
using Real.CommentManager;
using Real.data;

[TestFixture]
public class CommentManagerTests
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
    public void CreateComment_ShouldCreateNewComment()
    {
        // Arrange
        var initialCommentCount = _context.Comments.Count();
        var postId = 1;
        var content = "Test comment";

        // Act
        var result = CommentManager.CreateComment(content, postId, _context);

        // Assert
        Assert.IsTrue(result);
        Assert.AreEqual(initialCommentCount + 1, _context.Comments.Count());
    }

    [Test]
    public void UpdateComment_ShouldUpdateExistingComment()
    {
        // Arrange
        var commentId = 1;
        var newContent = "Updated comment";

        // Act
        var result = CommentManager.UpdateComment(commentId, newContent, _context);

        // Assert
        Assert.IsTrue(result);
        var updatedComment = _context.Comments.Find(commentId);
        Assert.AreEqual(newContent, updatedComment.Content);
    }

    [Test]
    public void DeleteComment_ShouldDeleteExistingComment()
    {
        // Arrange
        var commentId = 1;
        var initialCommentCount = _context.Comments.Count();

        // Act
        var result = CommentManager.DeleteComment(commentId, _context);

        // Assert
        Assert.IsTrue(result);
        Assert.AreEqual(initialCommentCount - 1, _context.Comments.Count());
        var deletedComment = _context.Comments.Find(commentId);
        Assert.IsNull(deletedComment);
    }

    [Test]
    public void RetrieveCommentById_ShouldRetrieveExistingComment()
    {
        // Arrange
        var commentId = 1;
        var expectedContent = "Test comment";

        // Act
        var retrievedComment = CommentManager.RetrieveCommentById(commentId, _context);

        // Assert
        Assert.IsNotNull(retrievedComment);
        Assert.AreEqual(expectedContent, retrievedComment.Content);
    }
}