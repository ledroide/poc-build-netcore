FROM microsoft/dotnet:latest
COPY ./netcorebuild/bin/Debug/netcoreapp1.0/publish /app
WORKDIR /app