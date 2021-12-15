cd /pipeline/source/app/publish
dotnet CalcService.dll --server.urls=http://0.0.0.0:${PORT-"8080"}