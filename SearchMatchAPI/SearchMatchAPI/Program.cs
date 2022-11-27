using Microsoft.EntityFrameworkCore;
using SearchMatchAPI.DbContexts;
using SearchMatchAPI.Repositories;
using SearchMatchAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.




builder.Services.AddHttpClient<MatchServices>();
builder.Services.AddTransient<IMatchService,
    MatchServices>();
builder.Services.AddSingleton<IPatientRepository, InMemPatientRepository>();
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
