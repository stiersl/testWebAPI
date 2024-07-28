# Examples
Simple apps written in C# DotNet Core and Angular

## TestWeatherAPI
creating and calling Web Based Rest API.

## to startup the WeatherAPI from Terminal from solution directory
``` dotnet run --launch-profile saDev --project .\src\TestWeatherAPI\TestWeatherAPI.csproj```

## to Run this in Docker
from Directory
### to build the docker image
docker compose build
### to startup the container
docker compose up
### to start up the container in detached mode
docker compose up -d


## Call the rest API from chrome
https://localhost:6969/weatherforecast?Days=4