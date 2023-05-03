FROM mcr.microsoft.com/dotnet/sdk:6.0
WORKDIR /app

COPY app/*.csproj ./

RUN dotnet restore
COPY app/. ./
RUN dotnet publish WebAPI.csproj -c Release -o out
WORKDIR out
ENV ASPNETCORE_URLS="http://*:1453"
ENTRYPOINT ["dotnet", "WebAPI.dll"]