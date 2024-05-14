FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine3.19 as builder
WORKDIR /build
COPY . .
RUN dotnet publish EarthAPI/EarthAPI.csproj --configuration Release --output publish
FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine3.19
WORKDIR /app
COPY --from=builder /build/publish/ .
EXPOSE 80
EXPOSE 443
ENV ASPNETCORE_ENVIRONMENT=Development
ENV ASPNETCORE_HTTP_PORTS=80
ENV ASPNETCORE_HTTPS_PORTS=443
ENTRYPOINT ["dotnet", "EarthAPI.dll"]