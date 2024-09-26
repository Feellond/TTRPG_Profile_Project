#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["TTRPG_Profile_Project/TTRPG_Project.Web.csproj", "TTRPG_Profile_Project/"]
RUN dotnet restore "./TTRPG_Profile_Project/TTRPG_Project.Web.csproj"

# Устанавливаем Node.js и npm
RUN apt-get update && \
    apt-get install -y curl && \
    curl -fsSL https://deb.nodesource.com/setup_18.x | bash - && \
    apt-get install -y nodejs && \
    npm install -g npm@latest && \
    node -v && npm -v

# Копируем остальные файлы проекта
COPY . .

# Устанавливаем зависимости npm и выполняем сборку
WORKDIR "/src/TTRPG_Profile_Project/ClientApp"
RUN rm -rf node_modules package-lock.json && \
    npm install && \
    npm run build

# Собираем проект
WORKDIR "/src/TTRPG_Profile_Project"
RUN dotnet build "./TTRPG_Project.Web.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./TTRPG_Project.Web.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

# Копируем скрипт в образ
COPY --from=build /src/wait-for-it.sh /usr/local/bin/wait-for-it
# Переключаемся на root для изменения прав доступа
USER root
# Изменяем права доступа в этапе сборки
RUN chmod +x /usr/local/bin/wait-for-it
# Возвращаем пользователя app обратно
USER app

# Заменяем ENTRYPOINT на wait-for-it с портом 3307
ENTRYPOINT ["wait-for-it", "mysql_db:3307", "--", "dotnet", "TTRPG_Project.Web.dll"]