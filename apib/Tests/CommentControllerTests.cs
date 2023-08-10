using apib.Controllers;
using apib.Data;
using apib.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace apib.Tests
{
    [TestFixture]
    public class CommentsControllerTests
    {
        private CommentsController _commentsController;
        private ApiDbContext _dbContext;

        [SetUp]
        public void Setup()
        {
            // Initialize the DbContext with an in-memory database
            var options = new DbContextOptionsBuilder<ApiDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;
            _dbContext = new ApiDbContext(options);

            // Seed the in-memory database with test data
            _dbContext.Comments.AddRange(new List<Comment>
            {
                new Comment { CommentId = 1, Text = "Comment 1" },
                new Comment { CommentId = 2, Text = "Comment 2" },
                new Comment { CommentId = 3, Text = "Comment 3" }
            });
            _dbContext.SaveChanges();

            _commentsController = new CommentsController(_dbContext);
        }

        [TearDown]
        public void Teardown()
        {
            // Clean up the in-memory database after each test
            _dbContext.Database.EnsureDeleted();
            _dbContext.Dispose();
        }

        [Test]
        public async Task Get_ReturnsAllComments()
        {
            // Act
            var result = await _commentsController.Get();

            // Assert
            Assert.IsInstanceOf<OkObjectResult>(result);
            var okResult = (OkObjectResult)result;
            Assert.IsInstanceOf<List<Comment>>(okResult.Value);
            var comments = (List<Comment>)okResult.Value;
            Assert.AreEqual(3, comments.Count);
        }

        [Test]
        public async Task Get_WithValidCommentId_ReturnsComment()
        {
            // Arrange
            int commentId = 2;

            // Act
            var result = await _commentsController.Get(commentId);

            // Assert
            Assert.IsInstanceOf<OkObjectResult>(result);
            var okResult = (OkObjectResult)result;
            Assert.IsInstanceOf<Comment>(okResult.Value);
            var comment = (Comment)okResult.Value;
            Assert.AreEqual(commentId, comment.CommentId);
        }

        [Test]
        public async Task Get_WithInvalidCommentId_ReturnsBadRequest()
        {
            // Arrange
            int commentId = 99;

            // Act
            var result = await _commentsController.Get(commentId);

            // Assert
            Assert.IsInstanceOf<BadRequestObjectResult>(result);
            var badRequestResult = (BadRequestObjectResult)result;
            Assert.AreEqual("Invalid CommentId", badRequestResult.Value);
        }

        // Add more tests for other controller actions (Post, Put, Delete) as needed
    }
}