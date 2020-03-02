# Define base image
FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build

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
FROM mcr.microsoft.com/dotnet/core/runtime:3.0 AS runtime
WORKDIR /publish
COPY --from=build-env /publish .
ENTRYPOINT ["dotnet", "comp680.dll"]
