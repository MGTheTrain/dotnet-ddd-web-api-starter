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

### Compiling C# source code 

Run:

```sh
make build subdir=<subdirectory in the src folder, e.g. {{cookiecutter.project_slug}}.Application>
```

### Running xUnit tests

Run:

```sh
make test subdir=<subdirectory in the test folder, e.g. {{cookiecutter.project_slug}}.ApplicationTest>
```

### Generating project documentation

Run:

```sh
make docs
```

### Clearing artifacts

Run:

```sh
make clean
```

## Author

{{ cookiecutter.author_name }}