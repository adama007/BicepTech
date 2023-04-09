var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "taw takhrali fih");

app.Run();
