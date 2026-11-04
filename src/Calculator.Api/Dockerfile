# ---------- Stage 1: build ----------
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

COPY global.json nuget.config Directory.Build.props .editorconfig ./
COPY src/Calculator.Core/Calculator.Core.csproj src/Calculator.Core/packages.lock.json src/Calculator.Core/
COPY src/Calculator.Api/Calculator.Api.csproj src/Calculator.Api/packages.lock.json src/Calculator.Api/
RUN dotnet restore src/Calculator.Api/Calculator.Api.csproj --locked-mode

COPY src/Calculator.Core/ src/Calculator.Core/
COPY src/Calculator.Api/ src/Calculator.Api/
RUN dotnet publish src/Calculator.Api/Calculator.Api.csproj -c Release --no-restore -o /app

# ---------- Stage 2: runtime ----------
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build /app .
USER $APP_UID
EXPOSE 8080
ENTRYPOINT ["dotnet", "Calculator.Api.dll"]