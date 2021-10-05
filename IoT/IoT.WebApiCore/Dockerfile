#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["IoT/IoT.WebApiCore/IoT.WebApiCore.csproj", "IoT/IoT.WebApiCore/"]
COPY ["Common/Common.IdentityManagementCore/Common.IdentityManagementCore.csproj", "Common/Common.IdentityManagementCore/"]
COPY ["Common/Common.Services.Infrastructure/Common.Services.Infrastructure.csproj", "Common/Common.Services.Infrastructure/"]
COPY ["Common/Common.DTO/Common.DTO.csproj", "Common/Common.DTO/"]
COPY ["Common/Common.Entities/Common.Entities.csproj", "Common/Common.Entities/"]
COPY ["Common/Common.Utils/Common.Utils.csproj", "Common/Common.Utils/"]
COPY ["IoT/IoT.Services.Infrastructure/IoT.Services.Infrastructure.csproj", "IoT/IoT.Services.Infrastructure/"]
COPY ["IoT/IoT.Entities/IoT.Entities.csproj", "IoT/IoT.Entities/"]
COPY ["IoT/IoT.DTO/IoT.DTO.csproj", "IoT/IoT.DTO/"]
COPY ["IoT/IoT.DIContainerCore/IoT.DIContainerCore.csproj", "IoT/IoT.DIContainerCore/"]
COPY ["IoT/IoT.DataAccess.EFCore/IoT.DataAccess.EFCore.csproj", "IoT/IoT.DataAccess.EFCore/"]
COPY ["Common/Common.DataAccess.EFCore/Common.DataAccess.EFCore.csproj", "Common/Common.DataAccess.EFCore/"]
COPY ["IoT/IoT.Services/IoT.Services.csproj", "IoT/IoT.Services/"]
COPY ["Common/Common.Services/Common.Services.csproj", "Common/Common.Services/"]
COPY ["Common/Common.WebApiCore/Common.WebApiCore.csproj", "Common/Common.WebApiCore/"]
RUN dotnet restore "IoT/IoT.WebApiCore/IoT.WebApiCore.csproj"
COPY . .
WORKDIR "/src/IoT/IoT.WebApiCore"
RUN dotnet build "IoT.WebApiCore.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "IoT.WebApiCore.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "IoT.WebApiCore.dll"]
