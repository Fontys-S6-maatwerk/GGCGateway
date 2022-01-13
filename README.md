# GGCGateway
De gateway runt op port 5011 (http) en 5001 (https), zie evt. [launchSettings.json](https://github.com/Fontys-S6-maatwerk/GGCGateway/blob/main/GGCGateway/Properties/launchSettings.json). Om deze service te gebruiken in docker kan een image lokaal worden gebuild met `docker build -t ocelot-gateway .` of de [github package](https://github.com/orgs/Fontys-S6-maatwerk/packages?repo_name=GGCGateway) worden gebruikt. 
Een voorbeeld van docker compose ziet er als volgt uit:

`
version: '3.8'
services:

  ocelot-gateway:
    image: ghcr.io/fontys-s6-maatwerk/ggcgateway:main
    container_name: ocelot-gateway
    ports:
      - "5011:80"
    depends_on:
      - solution-service
      - overige services ..
      
  ...
`

# Endpoints
Voor interfacing tussen Ocelot en de microservices hebben we duidelijke afspraken nodig over het coderen van endpoints en het formaat van de URL's waarmee Ocelot downstream zal communiceren. 

Belangrijk is dat Ocelot geen gRPC ondersteunt. Dit betekent dat de communicatie tussen Ocelot en de services via HTTP moet verlopen. De communicatie tussen microservices kan echter hetzelfde blijven. 

Voorbeeld van interfacedocumentatie voor de Solutions-service (SolutionController en SDGsController) 
| Upstream URL (client to gateway) | Downstream URL (gateway to service) | HTTP verb  | codes               |
-----------------------------------|-------------------------------------|------------|---------------------|
| solutions                        | api/solutions                       | GET        | 200                 |
| solutions                        | api/solutions                       | POST       | 201, 401, 400       |
| solutions/{id}                   | api/solutions{id}                   | PUT        | 204, 401, 404, 400  |
| solutions/{id}                   | api/solutions{id}                   | DELETE     | 204, 404            |
| sdgs                             | api/sdgs                            | GET        | 200                 |
