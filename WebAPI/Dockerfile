FROM mcr.microsoft.com/dotnet/sdk:6.0
WORKDIR /app
COPY . .
COPY ["Yoklama/Entities/Entities.csproj", "WebAPI/"]
COPY ["Yoklama/DataAccess/DataAccess.csproj", "WebAPI/"]
COPY ["Yoklama/Business/Business.csproj", "WebAPI/"]
RUN dotnet restore
RUN dotnet publish WebAPI.csproj -c Release -o out
WORKDIR out
ENV ASPNETCORE_URLS="http://*:1453"
ENTRYPOINT ["dotnet", "WebAPI.dll"]