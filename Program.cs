using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

List<Administrador> administradores = new();

app.MapGet("/", () => "✅ DIO Minimal API Completa!");

app.MapGet("/administradores", () => administradores);

app.MapPost("/administradores", (Administrador admin) =>
{
    admin.Id = administradores.Count + 1;
    administradores.Add(admin);
    return Results.Created($"/administradores/{admin.Id}", admin);
});

app.MapGet("/administradores/{id}", (int id) =>
{
    var admin = administradores.FirstOrDefault(a => a.Id == id);
    return admin != null ? Results.Ok(admin) : Results.NotFound();
});

app.MapPut("/administradores/{id}", (int id, Administrador input) =>
{
    var admin = administradores.FirstOrDefault(a => a.Id == id);
    if (admin == null) return Results.NotFound();
    
    admin.Email = input.Email;
    admin.Senha = input.Senha;
    admin.Ativo = input.Ativo;
    return Results.Ok(admin);
});

app.MapDelete("/administradores/{id}", (int id) =>
{
    var admin = administradores.FirstOrDefault(a => a.Id == id);
    if (admin == null) return Results.NotFound();
    
    administradores.Remove(admin);
    return Results.NoContent();
});

app.Run();

public class Administrador
{
    public int Id { get; set; }
    public string Email { get; set; } = "";
    public string Senha { get; set; } = "";
    public bool Ativo { get; set; }
}
