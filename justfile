
#!/usr/bin/env just --justfile

# Use PowerShell 7+ for recipes, you may need to install it first.
set shell := ["pwsh", "-NoLogo", "-NoProfileLoadTime", "-Command"]

# List available recipes
default:
    just --list

# Restore solution
restore:
    dotnet restore

# Build solution
build:
    dotnet build

# Clean solution
clean:
    dotnet clean

# Run solution tests
test:
    cd tests/AtomFeed.Tests && dotnet test --no-restore --logger "console;verbosity=detailed" 

# Run FeedReader example
run-feed-reader:
    dotnet run --project src/AtomFeed.FeedReader

# Run FeedServer example
run-feed-server:
    dotnet run --project src/AtomFeed.FeedServer --launch-profile "http"