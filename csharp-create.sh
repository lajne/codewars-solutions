#! /bin/bash

read -r -p "Folder name: " name
cd CSharp
mkdir -p "$name"
cd "$name"
touch main.cs