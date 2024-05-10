var builder = WebApplication.CreateBuilder(args);
{

}
var app = builder.Build();
{
    app.MapGet("/", () => "SunAPI");
    app.MapGet("/lbhealth", () => "SunAPI");
}
app.Run();
