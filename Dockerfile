
FROM microsoft/dotnet:sdk AS build-env
WORKDIR /app

# copy csproj and restore as distinct layers
#COPY *.csproj ./

# copy everything else and build
COPY . ./
WORKDIR /app/Recipe.NetCore
RUN dotnet build
WORKDIR /app/FerozeTextileMills.Core
RUN dotnet build
WORKDIR /app/FerozeTextileMills.Repository
RUN dotnet build
WORKDIR /app/FerozeTextileMills.Service
RUN dotnet build
WORKDIR /app/FerozeTextileMills.API
RUN dotnet restore
RUN dotnet publish -c Release -o out

# build runtime image
FROM microsoft/dotnet:aspnetcore-runtime
WORKDIR /app/FerozeTextileMills.API
COPY --from=build-env /app/FerozeTextileMills.API/out .
ENTRYPOINT ["dotnet", "FerozeTextileMills.API.dll"]