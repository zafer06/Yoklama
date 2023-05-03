#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/sdk:6.0
WORKDIR /app
COPY . .
RUN dotnet restore "Yoklama/WebAPI/WebAPI.csproj"
RUN dotnet build "WebAPI.csproj" -c Release -o /app/build

RUN dotnet restore "Yoklama/Entities/Entities.csproj"
RUN dotnet build "Entities.csproj" -c Release -o /app/build

RUN dotnet restore "Yoklama/DataAccess/DataAccess.csproj"
RUN dotnet build "DataAccess.csproj" -c Release -o /app/build

RUN dotnet restore "Yoklama/Business/Business.csproj"
RUN dotnet build "Business.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_URLS="http://*:1453"
ENTRYPOINT ["dotnet", "WebAPI.dll"]