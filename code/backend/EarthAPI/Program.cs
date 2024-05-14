using Gravity.Services;
using Microsoft.AspNetCore.Mvc;

const string CORS_POLICY = "SolarSystemCORSPolicy";

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddSingleton(i =>
    {
        string[] items = [
            "Earth isn’t actually round",
            "Coral reefs are Earth’s largest living structure",
            "Earth has a squishy interior",
            "Antarctica is home to the largest ice sheet on Earth",
            "The Moon is drifting away from Earth",
            "Atacama is the driest place on Earth",
            "Earth’s magnetic pole is creeping westward",
            "Europe is the second smallest continent in size but the third largest in population",
            "Tibetan plateau is Earth’s ‘third pole’",
            "Trees are breathers",
            "Length of Day: 23.9 hours",
            "Length of Year: 365.25 days",
            "Distance from Sun: 150,196,428 km",
            "One Way Light Time to Sun: 8.350022 minutes",
            "Earth is the only known planet to support life",
            "The highest point on Earth is Mount Everest, while the lowest point is the Mariana Trench",
            "The Earth's atmosphere is composed of roughly 78% nitrogen, 21% oxygen, and trace amounts of other gases",
            "Earth's rotation is gradually slowing down due to tidal forces",
            "The Earth's magnetic field protects it from harmful solar radiation",
            "The Earth has a liquid outer core and a solid inner core"
        ];
        return new FactRandomizer(items);
    });

    builder.Services.AddCors(options =>
    {
        options.AddPolicy(CORS_POLICY, builder =>
        {
            builder.WithOrigins("https://localhost:7660").WithMethods("GET", "OPTIONS");
        });
    });
}
var app = builder.Build();
{
    app.UseCors(CORS_POLICY);
    app.MapGet("/", () => "EarthAPI");
    app.MapGet("/lbhealth", () => "EarthAPI");
    // https://science.nasa.gov/solar-system/planet-sizes-and-locations-in-our-solar-system/
    app.MapGet("/api/intro", () => "Earth is the fifth largest planet in the solar system. It has an equatorial diameter of about 7,926 miles (12,756 kilometers). Earth is the third planet from the Sun, orbiting at an average distance of 93 million miles (149.7 million kilometers).");
    app.MapGet("/api/fact", ([FromServices] FactRandomizer factRandomizer) => factRandomizer.GetRandomFact());
}
app.Run();

/*
# https://science.nasa.gov/earth/facts/
Length of Day: 23.9 hours
Length of Year: 365.25 days
Distance from Sun: 150,196,428 km
One Way Light Time to Sun: 8.350022 minutes

# https://www.esa.int/Applications/Observing_the_Earth/10_remarkable_Earth_facts
10 Earth facts
Earth isn’t actually round
Coral reefs are Earth’s largest living structure 
Earth has a squishy interior
Antarctica is home to the largest ice sheet on Earth
The Moon is drifting away from Earth
Atacama is the driest place on Earth
Earth’s magnetic pole is creeping westward
Europe is the second smallest continent in size but the third largest in population
Tibetan plateau is Earth’s ‘third pole’
Trees are breathers
*/