# {{ cookiecutter.project_name }}

## Table of Contents

- [Summary](#summary)
- [References](#references)
- [Getting Started](#getting-started)
- [Author](#author)

## Summary

{{ cookiecutter.description }}

## References

- [Design a DDD-oriented microservice](https://learn.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/ddd-oriented-microservice)

## Getting Started

### Preconditions

- Preferably use the [dev container feature in VS Code IDE](https://code.visualstudio.com/docs/devcontainers/containers) to set up a development container. 
- If you plan to use Visual Studio for debugging, consider [installing it here](https://visualstudio.microsoft.com/). Afterward run the following commands to set up the solution file and associate the project files:

```sh
dotnet new sln -n {{cookiecutter.project_slug}}

dotnet sln {{cookiecutter.project_slug}}.sln add ./src/{{cookiecutter.project_slug}}.Application/{{cookiecutter.project_slug}}.Application.csproj
dotnet sln {{cookiecutter.project_slug}}.sln add ./src/{{cookiecutter.project_slug}}.Domain/{{cookiecutter.project_slug}}.Domain.csproj
dotnet sln {{cookiecutter.project_slug}}.sln add ./src/{{cookiecutter.project_slug}}.Infrastructure/{{cookiecutter.project_slug}}.Infrastructure.csproj
dotnet sln {{cookiecutter.project_slug}}.sln add ./src/{{cookiecutter.project_slug}}.Persistence/{{cookiecutter.project_slug}}.Persistence.csproj
dotnet sln {{cookiecutter.project_slug}}.sln add ./src/{{cookiecutter.project_slug}}.Web/{{cookiecutter.project_slug}}.Web.csproj

dotnet sln {{cookiecutter.project_slug}}.sln add ./test/{{cookiecutter.project_slug}}.ApplicationTest/{{cookiecutter.project_slug}}.ApplicationTest.csproj
dotnet sln {{cookiecutter.project_slug}}.sln add ./test/{{cookiecutter.project_slug}}.DomainTest/{{cookiecutter.project_slug}}.DomainTest.csproj
dotnet sln {{cookiecutter.project_slug}}.sln add ./test/{{cookiecutter.project_slug}}.InfrastructureTest/{{cookiecutter.project_slug}}.InfrastructureTest.csproj
dotnet sln {{cookiecutter.project_slug}}.sln add ./test/{{cookiecutter.project_slug}}.PersistenceTest/{{cookiecutter.project_slug}}.PersistenceTest.csproj
```

### Compiling C# source code 

Run in order to compile C# source files in the `src` folder:

```sh
make build
```

### Running xUnit tests

Run in order to compile and run xUnit tests:

```sh
# All tests
make test
# Individual tests
make test-individual subdir=<subdirectory in the test folder, e.g. {{cookiecutter.project_slug}}.ApplicationTest>
```

### Generating project documentation

Run:

```sh
make docs
```
### Auto-format and lint C# files

Run:

```sh
make format-and-lint
```

**NOTE:** Optionally it is recommended to set up a symbolic link via `cd .git/hooks && ln -s ../../devops/scripts/format_and_lint.sh pre-commit && sudo chmod +x pre-commit && cd -` and a validation automation workflow to ensure that the `format_and_lint.sh` script is executed with each commit.

### Clearing artifacts

Run:

```sh
make clean
```

## Author

{{ cookiecutter.author_name }}