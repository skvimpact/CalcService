cd /pipeline/source/app/publish
dotnet CallService.dll --server.urls=http://0.0.0.0:${PORT-"8080"}