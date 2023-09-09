FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Countdown/Countdown.csproj", "Countdown/"]
COPY ["Countdown.CountdownDLL/CountdownDLL.csproj", "Countdown.CountdownDLL/"]
RUN dotnet restore "Countdown/Countdown.csproj"
COPY . .
WORKDIR "/src/Countdown"
RUN dotnet build "Countdown.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Countdown.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Countdown.dll"]