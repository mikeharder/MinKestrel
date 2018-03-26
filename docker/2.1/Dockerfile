FROM microsoft/dotnet-nightly:2.1-sdk AS build
WORKDIR /app

# copy minimum and restore
COPY NuGet.config ./
COPY *.sln ./
COPY MinKestrel/*.csproj ./MinKestrel/
RUN dotnet restore

# copy everything else and build
COPY . ./
RUN dotnet publish -f netcoreapp2.1 --no-restore -c Release -o out

# build runtime image
FROM microsoft/dotnet-nightly:2.1-runtime
WORKDIR /app
COPY --from=build /app/MinKestrel/out ./
ENTRYPOINT ["dotnet", "MinKestrel.dll"]
