using System;
using seiteAPI.Services;
using seiteAPI.Services.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<StudentService>();
builder.Services.AddScoped<PasswordService>();
builder.Services.AddScoped<GoalService>();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(connectionString));

// Cors Policy
builder.Services.AddCors(options => {
    options.AddPolicy("BlogPolicy",
    builder => {
        builder.WithOrigins("http://localhost:5173", "http://localhost:5020", "https://new-seite-client-fimt.vercel.app/")
        .AllowAnyHeader()
        .AllowAnyMethod();
    }
    );
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("BlogPolicy");


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
