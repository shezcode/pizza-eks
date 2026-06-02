FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
# .NET 8 images default to port 8080; pin to 80 so it matches the manifests.
ENV ASPNETCORE_URLS=http://+:80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["PizzeriaApi.csproj", "."]
RUN dotnet restore "./PizzeriaApi.csproj"
COPY . .
RUN dotnet publish "PizzeriaApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PizzeriaApi.dll"]
