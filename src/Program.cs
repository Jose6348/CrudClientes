using CrudClient.Application.UseCases.Expanses.Get;
using CrudClient.Application.UseCases.Expanses.Register;
using CrudClient.Domain.Repositories;
using CrudClient.Infrastructure.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<RegisterExpansesUseCase>();
builder.Services.AddScoped<IClientRepository, ClientRepository>();
builder.Services.AddScoped<GetAllExpansesUseCase>();

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
