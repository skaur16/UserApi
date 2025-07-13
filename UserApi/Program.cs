using Microsoft.EntityFrameworkCore;
using UserApi.Database;
using UserApi.Models;


var builder = WebApplication.CreateBuilder(args);

//  Use SQL Server DB (not InMemory)
builder.Services.AddDbContext<RecordContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//  Seed data on startup
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<RecordContext>();
    db.Database.EnsureCreated();

    // Only seed if empty
    if (!db.Records.Any())
    {
        db.Records.AddRange(
            new Record
            {
                Name = "Ali Raza",
                Email = "ali@example.com",
                PhoneNumber = "03001234567",
                DateOfBirth = new DateTime(1995, 4, 21)
            },
            new Record
            {
                Name = "Sara Ahmed",
                Email = "sara@example.com",
                PhoneNumber = "03111234567",
                DateOfBirth = new DateTime(1997, 6, 15)
            }
        );
        db.SaveChanges();
    }
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
