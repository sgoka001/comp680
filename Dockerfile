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
WORKDIR /
COPY --from=build-env / .
ENTRYPOINT ["dotnet", "comp680.dll"]
