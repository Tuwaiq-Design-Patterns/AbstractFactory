FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["AbstractFactory/AbstractFactory.csproj", "AbstractFactory/"]
RUN dotnet restore "AbstractFactory/AbstractFactory.csproj"
COPY . .
WORKDIR "/src/AbstractFactory"
RUN dotnet build "AbstractFactory.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AbstractFactory.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AbstractFactory.dll"]
