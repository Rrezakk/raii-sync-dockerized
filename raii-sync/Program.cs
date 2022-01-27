var port = Environment.GetEnvironmentVariable("PORT");
var s = false;
if (port == null)
{
    s = true;
    port = "5001";
}
var url = $"http{(s?"s":"")}://localhost:{port}";
Console.WriteLine($"started service on url: {url}");
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

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

app.Urls.Add(url);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

