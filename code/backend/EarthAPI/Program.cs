var builder = WebApplication.CreateBuilder(args);
{

}
var app = builder.Build();
{
    app.MapGet("/", () => "EarthAPI");
    app.MapGet("/lbhealth", () => "EarthAPI");
}
app.Run();
