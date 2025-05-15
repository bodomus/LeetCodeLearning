FROM mcr.microsoft.com/dotnet/runtime:9.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["LeetCodeConsoleApp/LeetCodeConsoleApp.csproj", "LeetCodeConsoleApp/"]
RUN dotnet restore "LeetCodeConsoleApp/LeetCodeConsoleApp.csproj"
COPY . .
WORKDIR "/src/LeetCodeConsoleApp"
RUN dotnet build "./LeetCodeConsoleApp.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./LeetCodeConsoleApp.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LeetCodeConsoleApp.dll"]
