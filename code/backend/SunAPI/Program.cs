using Gravity.Services;
using Microsoft.AspNetCore.Mvc;

const string CORS_POLICY = "SolarSystemCORSPolicy";
var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddSingleton<FactRandomizer>(i =>
    {
        string[] items = [
            "The Sun is a massive ball of hot gases primarily composed of hydrogen and helium.",
            "Solar flares, eruptions of magnetic energy from the Sun's surface, can release energy equivalent to millions of nuclear bombs.",
            "Sunspots, cooler areas on the Sun's surface, can be larger than Earth and are caused by intense magnetic activity.",
            "The Sun's energy is generated through nuclear fusion, where hydrogen atoms combine to form helium, releasing vast amounts of energy in the process.",
            "It takes sunlight about 8 minutes and 20 seconds to reach Earth, traveling at the speed of light.",
            "The Sun's magnetic field extends throughout the solar system, shaping the paths of charged particles in the solar wind.",
            "Solar wind, a stream of charged particles emanating from the Sun, interacts with Earth's magnetosphere, causing phenomena like auroras.",
            "The Sun's surface temperature ranges from about 5,973 degrees Celsius (10,742 degrees Fahrenheit) to over 15 million degrees Celsius (27 million degrees Fahrenheit) in the core.",
            "The Sun has an equator circumference of approximately 4,379,000 kilometers and a radius of 695,700 kilometers.",
            "The Sun is classified as a G-type main-sequence star, commonly referred to as a yellow dwarf.",
            "The average time taken for the Sun to rotate on its axis is about 27 Earth days.",
            "The Sun orbits around the center of the Milky Way galaxy at an average speed of 720, 000 kilometers per hour(200 kilometers per second)."
            ];
        return new FactRandomizer(items);
    });

    builder.Services.AddCors(options =>
    {
        options.AddPolicy(CORS_POLICY, builder =>
        {
            builder.WithOrigins("https://localhost:7660").WithMethods("GET","OPTIONS");
        });
    });
}
var app = builder.Build();
{
    app.UseCors(CORS_POLICY);
    app.MapGet("/", () => "SunAPI");
    app.MapGet("/lbhealth", () => "SunAPI");
    app.MapGet("/api/intro", () => "The Sun is the largest celestial body in our solar system, boasting a diameter of approximately 864,000 miles (1.4 million kilometers). Situated at the center of the solar system, it radiates warmth and light, making life on Earth possible. The Sun is a G-type main-sequence star, commonly referred to as a yellow dwarf, and it comprises over 99% of the solar system's mass. It resides at the heart of our system, around which all planets, including Earth, orbit. Located about 93 million miles (149.7 million kilometers) from Earth, the Sun serves as the primary energy source driving Earth's climate, weather, and the processes essential for sustaining life.");
    app.MapGet("/api/fact", ([FromServices] FactRandomizer factRandomizer) => factRandomizer.GetRandomFact());
}
app.Run();

/*
# https://science.nasa.gov/sun/facts/
# numerical facts about sun
Equator circumference: 4,379,000km.
Radius: 695,700km.
Temperature: 5,973°C to 15,000,000°C.
Average orbital speed around the Milky Way: 720,000km/h (200km/s)
Star type: Yellow dwarf.
Average time taken to rotate on axis: 27 Earth days.
The Sun is a massive ball of hot gases primarily composed of hydrogen and helium.
Solar flares, eruptions of magnetic energy from the Sun's surface, can release energy equivalent to millions of nuclear bombs.
Sunspots, cooler areas on the Sun's surface, can be larger than Earth and are caused by intense magnetic activity.
The Sun's energy is generated through nuclear fusion, where hydrogen atoms combine to form helium, releasing vast amounts of energy in the process.
It takes sunlight about 8 minutes and 20 seconds to reach Earth, traveling at the speed of light.
The Sun's magnetic field extends throughout the solar system, shaping the paths of charged particles in the solar wind.
Solar wind, a stream of charged particles emanating from the Sun, interacts with Earth's magnetosphere, causing phenomena like auroras.
The Sun's surface temperature ranges from about 5,973 degrees Celsius (10,742 degrees Fahrenheit) to over 15 million degrees Celsius (27 million degrees Fahrenheit) in the core.
The Sun has an equator circumference of approximately 4,379,000 kilometers and a radius of 695,700 kilometers.
The Sun is classified as a G-type main-sequence star, commonly referred to as a yellow dwarf.
The average time taken for the Sun to rotate on its axis is about 27 Earth days.
The Sun orbits around the center of the Milky Way galaxy at an average speed of 720,000 kilometers per hour (200 kilometers per second).
*/