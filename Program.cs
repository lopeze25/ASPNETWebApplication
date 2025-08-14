var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//  wwwroot/index.html at "/"
app.UseDefaultFiles();   // index.html, default.htm, etc.
app.UseStaticFiles();    // static files from wwwroot


app.MapGet("/api/hello", () => "Hello from API"); // move off "/"

app.Run();
