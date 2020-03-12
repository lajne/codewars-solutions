#!/bin/bash

read -r -p 'Commit message: ' desc      # prompt user for commit message
read -r -p 'Branch: ' branch
git add .                               # stage
git commit -m "$desc"                   # commit with message
git push origin "$branch"               #push to origin master