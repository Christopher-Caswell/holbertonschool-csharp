#!/usr/bin/env bash
# Write a Bash script that initializes, builds, and
# runs a new C# project from a folder titled 2-new_project.

mkdir 2-new_project
cd 2-new_project
dotnet new console
dotnet build
dotnet run
