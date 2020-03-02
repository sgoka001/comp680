# Define base image
FROM microsoft/dotnet:2.2-sdk AS build-env

# Copy project files
WORKDIR /source
COPY ["src/Example.Presentation/Example.Presentation.csproj", "./Example.Presentation/Example.Presentation.csproj"]

# Restore
RUN dotnet restore "./Example.Presentation/Example.Presentation.csproj"

# Copy all source code
COPY . .

# Publish
WORKDIR /source/src
RUN dotnet publish -c Release -o /publish

# Runtime
FROM microsoft/dotnet:2.2-aspnetcore-runtime
WORKDIR /publish
COPY --from=build-env /publish .
ENTRYPOINT ["dotnet", "Example.Presentation.dll"]
