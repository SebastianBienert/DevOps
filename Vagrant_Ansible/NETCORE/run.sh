#!/usr/bin/env bash

cd src
sudo dotnet build
cd EducationalProgram
sudo dotnet ef database update
sudo dotnet run
