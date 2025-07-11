# Etap bazowy do uruchamiania
FROM mcr.microsoft.com/dotnet/aspnet:9.0-preview AS base
WORKDIR /app

# Etap builda
FROM mcr.microsoft.com/dotnet/sdk:9.0-preview AS build
WORKDIR /src

COPY ./GymApp/GymApp.csproj GymApp/
RUN dotnet restore GymApp/GymApp.csproj

COPY . .
WORKDIR /src/GymApp
RUN dotnet publish GymApp.csproj -c Release -o /app/publish

# Finalny obraz
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "GymApp.dll"]
