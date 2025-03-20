using API.Models;
using Microsoft.AspNetCore.Mvc; //precisa para realizar o return na linha 16

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Carro> carros = [
    new Carro{Id = 1, Name = "Fusca",},
    new Carro{Id = 2, Name= "Ferrari"}
];
//Exemplo de requisição
app.MapGet("/", () => "Hello World!");

//GET: api/carros
app.MapGet("/api/carros", () => {
    return Results.Ok(carros);
});

app.Run();
