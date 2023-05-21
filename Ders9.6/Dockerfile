
FROM mcr.microsoft.com/dotnet/sdk
WORKDIR /app
COPY . .
RUN dotnet restore
RUN dotnet publish Ders9.6.csproj -c Release -o out
WORKDIR out
ENV ASPNETCORE_URLS="http://*:1453"
ENTRYPOINT ["dotnet","Ders9.6"]