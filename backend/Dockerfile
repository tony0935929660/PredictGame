# 使用 .NET SDK 建構階段
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# 複製 csproj 並還原
COPY *.sln .
COPY backend/*.csproj ./backend/
RUN dotnet restore

# 複製其餘內容並建置
COPY backend/. ./backend/
WORKDIR /app/backend
RUN dotnet publish -c Release -o out

# 運行階段
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/backend/out ./
ENTRYPOINT ["dotnet", "backend.dll"]
