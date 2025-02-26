FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8040

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY /src/UserService/UserService.csproj ./
RUN dotnet restore

COPY /src/UserService/ ./
RUN dotnet publish -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "UserService.dll"]
