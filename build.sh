#!/bin/bash

dotnet build

cd ./minicover-lab

dotnet minicover instrument --workdir ../ --assemblies minicover-lab.test/bin/**/*.dll --sources minicover-lab/*.cs

dotnet minicover reset

cd ..

dotnet test ./minicover-lab.test --no-build

cd ./minicover-lab

dotnet minicover report --workdir ../