#!/bin/sh

dotnet publish --configuration Release --framework netcoreapp3.1 --runtime osx.10.12-x64 --self-contained true md2html.csproj

