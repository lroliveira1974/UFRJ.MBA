var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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


app.MapGet("/autor/consulta/{cpf}", (
    string cpf) =>
{
    return Results.Ok($"Voce pesquisou pelo CPF {cpf}");
})
.WithName("consulta");

app.MapPost("/inserir", () =>
{
    return Results.Ok();
})
.WithName("inserir");

app.MapPut("/alterar", () =>
{
    return Results.Ok();
})
.WithName("alterar");


app.MapDelete("/delete", () =>
{
    return Results.Ok();
})
.WithName("delete");

app.Run();

