# Define base image
FROM mcr.microsoft.com/dotnet/core/aspnet AS build-env

# Copy project files
WORKDIR /source
COPY ["comp680.csproj", "./comp680.csproj"]

# Restore
RUN dotnet restore "./comp680.csproj"

# Copy all source code
COPY . .

# Publish
WORKDIR /source/src
RUN dotnet publish -c Release -o /publish

# Runtime
FROM microsoft/dotnet:3.1-aspnetcore-runtime
WORKDIR /publish
COPY --from=build-env /publish .
ENTRYPOINT ["dotnet", "comp680.dll"]
