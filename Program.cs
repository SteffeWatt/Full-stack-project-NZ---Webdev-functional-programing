using A1.Data;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);


/* watch lectures on this
private static void AddRecords() {
    {
        List<Product> products = new List<Product>
    {
        new Product { Id = "1", "bowlingball", "This is a bowling ball", "50$" }
    };
    }
}
*/


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//this line of code is gets the key from "appsettings.json
builder.Services.AddDbContext<A1DBContext>(options => options.UseSqlite(builder.Configuration["WebAPIConnection"]));

//not sure if there is suposed to be 2 of these in here ( was in lecturer's code)
builder.Services.AddControllers();

//Look into this, see lecture on api (3)
builder.Services.AddScoped<IA1Repo>();


    var app = builder.Build();




    // Configure the HTTP request pipeline.

    app.UseSwagger();
    app.UseSwaggerUI();


    app.UseHttpsRedirection();

    app.UseAuthentication();

    app.MapControllers();

    app.Run();


