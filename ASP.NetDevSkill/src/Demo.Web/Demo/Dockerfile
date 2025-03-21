# ASP.Net Docker base Image
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build

WORKDIR /src
RUN apt update && apt install -y nodejs
COPY ["Demo/Demo.csproj", "Demo/"]
RUN dotnet restore "Demo/Demo.csproj"

COPY . .
WORKDIR "/src/Demo"
RUN dotnet build "Demo.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Demo.csproj" -c Release -o /app

FROM build AS final
WORKDIR /app
COPY --from=publish /app .

EXPOSE 80
ENTRYPOINT [ "dotnet", "Demo.dll" ]

