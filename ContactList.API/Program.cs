using ContactList.Data.Data.Classes;
using ContactList.Data.Data.Context;
using ContactList.Data.Data.Intitializer;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add AppDbContext
builder.Services.AddDbContext<AppDbContext>();

// Connect Interfecees to classes
builder.Services.AddTransient<IContactListRepository, ContactListRepository>();

// Connect SPA frontend 
builder.Services.AddSpaStaticFiles(configuration => {
    configuration.RootPath = "clientApp/build";
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.UseSpaStaticFiles();


app.MapControllers();

app.UseSpa(spa => {
    spa.Options.SourcePath = "clientApp";
    if (builder.Environment.IsDevelopment())
    {
        spa.UseReactDevelopmentServer(npmScript: "start");
    }
});

app.Run();

AppInitializer.Seed(app);

