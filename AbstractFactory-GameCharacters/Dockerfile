FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["AbstractFactory-GameCharacters/AbstractFactory-GameCharacters.csproj", "AbstractFactory-GameCharacters/"]
RUN dotnet restore "AbstractFactory-GameCharacters/AbstractFactory-GameCharacters.csproj"
COPY . .
WORKDIR "/src/AbstractFactory-GameCharacters"
RUN dotnet build "AbstractFactory-GameCharacters.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AbstractFactory-GameCharacters.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AbstractFactory-GameCharacters.dll"]
