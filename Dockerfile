# Define base image
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build

# Copy project files
WORKDIR /
COPY ["comp680.csproj", "./comp680.csproj"]

# Restore
RUN dotnet restore "./comp680.csproj"

# Copy all source code
COPY . .

# Publish
WORKDIR /
RUN dotnet publish -c Release -o /publish

# Runtime
FROM mcr.microsoft.com/dotnet/core/runtime:3.1 AS runtime
WORKDIR /bin/Debug/netcoreapp3.1/
COPY --from=build-env /bin/Debug/netcoreapp3.1/ .
ENTRYPOINT ["dotnet", "comp680.dll"]
