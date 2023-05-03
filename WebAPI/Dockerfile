FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim
WORKDIR /app
COPY . .
RUN dotnet restore
RUN dotnet publish TestApi.csproj -c Release -o out
WORKDIR out
ENV ASPNETCORE_URLS="http://*:1453"
ENTRYPOINT ["dotnet", "TestApi.dll"]