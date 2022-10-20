#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Graduation_LHL_API/Graduation_LHL_API.csproj", "Graduation_LHL_API/"]
RUN dotnet restore "Graduation_LHL_API/Graduation_LHL_API.csproj"
COPY . .
WORKDIR "/src/Graduation_LHL_API"
RUN dotnet build "Graduation_LHL_API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Graduation_LHL_API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Graduation_LHL_API.dll"]