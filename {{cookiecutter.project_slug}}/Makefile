# Variables
DOTNET = dotnet

# Directories
DOCS_DIR = docs
SRC_DIR = src
TEST_DIR = test

# Commands
.PHONY: all build test clean docs

# Default target
all: build test

# Build the source code
build:
	$(DOTNET) build $(SRC_DIR)

# Run tests
test:
	$(DOTNET) test $(TEST_DIR)

# Clean up generated files
clean:
	rm -rf $(DOCS_DIR)/_build
	rm -rf ${DOCS_DIR}/{{cookiecutter.project_slug}}/_site
	rm -rf ${DOCS_DIR}/{{cookiecutter.project_slug}}/.jekyll-cache
	$(DOTNET) clean $(SRC_DIR)
	$(DOTNET) clean $(TEST_DIR)

# Build and serve documentation
docs:
	cd docs/{{cookiecutter.project_slug}} && jekyll serve && echo "Visit in a browser of choice localhost:4000"