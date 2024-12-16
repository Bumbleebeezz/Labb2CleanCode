using Dataccess;
using Dataccess.Repositories.Feedbacks;
using FeedbackService.Sevices;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IFeedbackService, FeedbackService.Sevices.FeedbackService>();
builder.Services.AddScoped<IFeedbackRepository, FeedbackRepository>();

// Add DbContext with SQL Server or any other provider
//builder.Services.AddDbContext<FeedbackDbContext>(options =>
//   options.UseSqlServer(Environment.GetEnvironmentVariable("ConnectionStrings_DefaultConnection")));

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<FeedbackDbContext>(options =>
   options.UseSqlServer(connectionString));

var app = builder.Build();

// Apply migrations on startup
if (!app.Environment.IsDevelopment())
{
    using (var scope = app.Services.CreateScope())
    {
        var dbContext = scope.ServiceProvider.GetRequiredService<FeedbackDbContext>();

        dbContext.Database.Migrate();
    }

}

//if (app.Environment.IsDevelopment())
//{
app.UseSwagger();
app.UseSwaggerUI();
//}

app.MapControllers();

app.Run();
