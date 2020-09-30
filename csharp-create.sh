#! /bin/bash

read -r -p "Folder name: " name
read -r -p "Difficulty: " diff
cd CSharp
cd "$diff"
mkdir -p "$name"
cd "$name"
touch main.cs