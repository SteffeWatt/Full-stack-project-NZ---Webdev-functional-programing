using A1.Data;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);



// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//this line of code gets the key from "appsettings.json
builder.Services.AddDbContext<A1DBContext>(options => options.UseSqlite(builder.Configuration["WebAPIConnection"]));

//the builder uses the interface and the actual repo here
builder.Services.AddScoped<IA1Repo,A1Repo>();


    var app = builder.Build();




    // Configure the HTTP request pipeline.

    app.UseSwagger();
    app.UseSwaggerUI();


    app.UseHttpsRedirection();

    app.UseAuthentication();

    app.MapControllers();

    app.Run();


