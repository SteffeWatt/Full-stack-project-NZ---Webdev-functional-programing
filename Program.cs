using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//this line of code is gets the key from "appsettings.json"
builder.Services.AddDbContext<A1DBContext>(options => options.UseSqlite(builder.Configuration["WebAPIConnection"]));

//Look into this, see lecture on api (3)
//builder.Services.AddScoped<IA1Repo>(); - might be because the classes are not implemented.


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthentication();

app.MapControllers();

app.Run();
