# Variables
DOTNET = dotnet

# Directories
DOCS_DIR = docs
SRC_DIR = src
TEST_DIR = test

# Commands
.PHONY: start-docker-cmp stop-docker-cmp run-unit-tests run-integration-tests run-individual-test run clean docs format-and-lint help

help:
	@echo "Available make commands:"
	@echo "  start-docker-cmp           - Start the Docker Compose services"
	@echo "  stop-docker-cmp            - Stop the Docker Compose services"
	@echo "  run-unit-tests             - Run all unit tests"
	@echo "  run-integration-tests      - Run all integration tests"
	@echo "  run-individual-test        - Run an individual test (provide subdir=<subdirectory>)"
	@echo "  run                        - Start the web server"
	@echo "  clean                      - Clean up generated files"
	@echo "  docs                       - Build and serve the documentation"
	@echo "  format-and-lint            - Format and lint C# files"
	@echo "  help                       - Display this help message"

start-docker-cmp:
	cd devops/docker-compose && docker-compose up -d --build

stop-docker-cmp:
	cd devops/docker-compose && docker-compose down -v

# Run tests
run-unit-tests:
	@folders=$$(find ./test/Unit -type f -name '*.csproj' -exec dirname {} \;); \
	for folder in $${folders}; do \
		echo "Running tests in folder: $${folder}"; \
		dotnet test "$${folder}"; \
	done

run-integration-tests:
	@folders=$$(find ./test/Integration -type f -name '*.csproj' -exec dirname {} \;); \
	for folder in $${folders}; do \
		echo "Running tests in folder: $${folder}"; \
		dotnet test "$${folder}"; \
	done

run-individual-test:
	@if [ -z "$(subdir)" ]; then \
		echo "Please provide a subdirectory in the test folder using 'make run-individual-test subdir=<subdirectory>'"; \
	else \
		$(DOTNET) test $(TEST_DIR)/$(subdir); \
	fi

# Start Kestrel server
run:
	cd src/{{cookiecutter.project_slug}}.Web && dotnet run

# Clean up generated files
clean:
	rm -rf $(DOCS_DIR)/_build
	rm -rf ${DOCS_DIR}/{{cookiecutter.project_slug}}/_site
	rm -rf ${DOCS_DIR}/{{cookiecutter.project_slug}}/.jekyll-cache
	find $(SRC_DIR) $(TEST_DIR) -type d \( -name 'obj' -o -name 'bin' \) -exec rm -rf {} +

# Build and serve documentation
docs:
	cd docs/{{cookiecutter.project_slug}} && jekyll serve && echo "Visit in a browser of choice localhost:4000"

# Format and lint C# files
format-and-lint:
	cd devops/scripts && ./format_and_lint.sh