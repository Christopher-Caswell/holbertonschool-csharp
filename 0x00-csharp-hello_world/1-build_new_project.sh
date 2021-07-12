#!/usr/bin/env bash
# Write a Bash script that initializes and builds
# a new C# project inside a folder titled 1-new_project

mkdir 1-new_project
cd 1-new_project
dotnet new console
dotnet build
