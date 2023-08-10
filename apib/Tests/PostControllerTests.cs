using apib.Controllers;
using apib.Data;
using apib.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apib.Tests
{
    [TestFixture]
    public class PostControllerTests
    {
        private PostController _postController;
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
            _dbContext.Posts.AddRange(new List<Post>
            {
                new Post { PostId = 1, Title = "Post 1" },
                new Post { PostId = 2, Title = "Post 2" },
                new Post { PostId = 3, Title = "Post 3" }
            });
            _dbContext.SaveChanges();

            _postController = new PostController(_dbContext);
        }

        [TearDown]
        public void Teardown()
        {
            // Clean up the in-memory database after each test
            _dbContext.Database.EnsureDeleted();
            _dbContext.Dispose();
        }

        [Test]
        public async Task Get_ReturnsAllPosts()
        {
            // Act
            var result = await _postController.Get();

            // Assert
            Assert.IsInstanceOf<OkObjectResult>(result);
            var okResult = (OkObjectResult)result;
            Assert.IsInstanceOf<List<Post>>(okResult.Value);
            var posts = (List<Post>)okResult.Value;
            Assert.AreEqual(3, posts.Count);
        }

        [Test]
        public async Task Get_WithValidPostId_ReturnsPost()
        {
            // Arrange
            int postId = 2;

            // Act
            var result = await _postController.Get(postId);

            // Assert
            Assert.IsInstanceOf<OkObjectResult>(result);
            var okResult = (OkObjectResult)result;
            Assert.IsInstanceOf<Post>(okResult.Value);
            var post = (Post)okResult.Value;
            Assert.AreEqual(postId, post.PostId);
        }

        [Test]
        public async Task Get_WithInvalidPostId_ReturnsBadRequest()
        {
            // Arrange
            int postId = 99;

            // Act
            var result = await _postController.Get(postId);

            // Assert
            Assert.IsInstanceOf<BadRequestObjectResult>(result);
            var badRequestResult = (BadRequestObjectResult)result;
            Assert.AreEqual("Invalid PostId", badRequestResult.Value);
        }

        // Add more tests for other controller actions (Post, Put, Delete) as needed
    }
}