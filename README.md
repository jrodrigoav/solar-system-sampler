# Solar System Sampler

To showcase container applications that may or may not talk to each other and use other services like RabbitMQ or databases

All microservices are coded in .NET and there is a SPA coded in React and Angular

# To Setup
```
dotnet dev-certs https -ep ./development_cert.pem --format Pem -np
openssl pkcs12 -inkey .\development_cert.key -in .\development_cert.pem -export -out development_cert.pfx
```

# To run with docker compose

docker compose -f .\docker-compose.yaml --project-name solarsystem build