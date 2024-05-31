FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

MAINTAINER {{cookiecutter.author_name}}

# ARG NUGET_SOURCE_NAME="PLACEHOLDER_NUGET_SOURCE_NAME"
# ARG NUGET_USERNAME="PLACEHOLDER_NUGET_USERNAME"
# ARG NUGET_PASSWORD="PLACEHOLDER_NUGET_PASSWORD"
# ARG NUGET_REPOSITORY_SRC="PLACEHOLDER_ARG NUGET_REPOSITORY_SRC"

WORKDIR /app
COPY . .
WORKDIR /app/{{cookiecutter.project_slug}}.Web

# RUN dotnet nuget add source --name ${NUGET_SOURCE_NAME} --username ${NUGET_USERNAME} --password ${NUGET_PASSWORD} --store-password-in-clear-text ${NUGET_REPOSITORY_SRC}
RUN dotnet restore ./{{cookiecutter.project_slug}}.Web.csproj
RUN dotnet publish ./{{cookiecutter.project_slug}}.Web.csproj -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine
WORKDIR /app
COPY --from=build /app/{{cookiecutter.project_slug}}.Web/out .
EXPOSE 8080
ENTRYPOINT ["dotnet", "{{cookiecutter.project_slug}}.Web.dll"]