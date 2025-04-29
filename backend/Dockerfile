# 使用 .NET SDK 建構階段
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# 複製 sln 和 csproj
COPY *.sln ./
COPY Backend/*.csproj ./Backend/

# 還原相依套件
RUN dotnet restore

# 複製所有程式碼
COPY Backend/. ./Backend/

# 切換到 Backend 資料夾
WORKDIR /app/Backend

# 發佈為 Release
RUN dotnet publish -c Release -o /app/out

# -------------------------------------------------------

# 運行階段
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

# 複製發佈的結果
COPY --from=build /app/out ./

# 告訴 Docker 這個容器會有環境變數可以吃（這裡不用寫死）
# （環境變數會透過 docker-compose 或 docker run 傳進來）

ENTRYPOINT ["dotnet", "Backend.dll"]
