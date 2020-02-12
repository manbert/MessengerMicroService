FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY MessengerMicroService/MessengerMicroService.csproj MessengerMicroService/
RUN dotnet restore MessengerMicroService/MessengerMicroService.csproj
COPY . .
WORKDIR /src/MessengerMicroService
RUN dotnet build MessengerMicroService.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish MessengerMicroService.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MessengerMicroService.dll"]
