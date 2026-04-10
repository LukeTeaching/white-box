@echo off
powershell -Command "Remove-Item './TestResults' -Recurse -Force -ErrorAction SilentlyContinue"
dotnet test --collect:"XPlat Code Coverage"
reportgenerator -reports:"TestResults/**/coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html
start coveragereport/index.html