using apib.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

Console.WriteLine("Connecting");

builder.Services.AddEntityFrameworkNpgsql()
    .AddDbContext<ApiDbContext>(opt => 
        opt.UseNpgsql(builder.Configuration.GetConnectionString("SampleDbConnection")));

// ApiDbContext dbContext = new(optionsBuilder.Options);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
// var posts = dbContext.Posts.ToList();
// Console.WriteLine(posts);

Console.WriteLine("Connected");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();