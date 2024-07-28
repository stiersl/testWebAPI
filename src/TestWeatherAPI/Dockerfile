# Docker build File for dotnet Core 8.0 web API apps
#
# version 0.0.3 7-28-2024 Steven Stier - Initial Release
#
# start with DotNet sdk debian based Bookworm slim image-everything we need to develop and build
# Build Image
FROM mcr.microsoft.com/dotnet/sdk:8.0-bookworm-slim AS build
WORKDIR /src

# Copy the .csproj and restore the project dependancies
COPY *.csproj ./
RUN dotnet restore

# Building the Runtime Image (note:it will be in the /app/publish direcotry)

#copy Everything else and Build and publish
COPY . ./
RUN dotnet publish -c Release -o /app/publish

#move the publish directory from the build container and put in the final container
FROM mcr.microsoft.com/dotnet/aspnet:8.0-bookworm-slim AS final
WORKDIR /app
COPY --from=build /app/publish .

# setup the entry point for the container.
ENTRYPOINT ["dotnet", "TestWeatherAPI.dll"]