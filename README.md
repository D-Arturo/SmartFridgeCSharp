# Smart Fridge Kata

This project is an implementation of the [Smart Fridge Kata](https://www.codurance.com/katas/smart-fridge) in C#. The project for now includes unit and acceptance tests to ensure the correctness of the implementation.

## Contents

- [Overview](#overview)
- [Technologies Used](#technologies-used)
- [Getting Started](#getting-started)
    - [Prerequisites](#prerequisites)
    - [Installation](#installation)
    - [Running the Application](#running-the-application)
- [Running Tests](#running-tests)
- [Continuous Integration](#continuous-integration)
- [Contributing](#contributing)


## Overview

The Smart Fridge Kata is a coding exercise that involves implementing a system for checking items added to the fridge and being able to display whether an item has expired, and how many days are remaining for the expiration. The system is designed to handle this behaviour while maintaining clean and maintainable code.

The project has been developed using Test-Driven Development (TDD) cycles, ensuring that all functionalities are backed by tests from the beginning and that the implementation strictly adheres to the defined requirements.

## Technologies Used

- **.NET 8**: The base framework for the Web API.
- **xUnit**: The testing framework used for unit and acceptance tests.

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) installed on your machine.

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/D-Arturo/SmartFridgeCSharp.git
   cd smartFridge
   ```

2. Restore the dependencies:
   ```bash
   dotnet restore
   ```

## Running Tests

The solution includes both unit and acceptance tests to validate the implementation.

1. To run all tests, use the following command:
   ```bash
   dotnet test
   ```

2. To run tests for a specific project, navigate to the `tests` directory and run:
   ```bash
   dotnet test <ProjectName>.csproj
   ```

## Continuous Integration

This project includes a GitHub Actions CI workflow that automatically runs the tests whenever changes are pushed to the repository. The workflow is defined in the `.github/workflows/workflow.yml` file.

To customize or extend the CI pipeline, modify the `workflow.yml` file as needed.


### Future Enhancements

- Implementing advanced capabilities regarding the Kata specifications.

## Contributing

We welcome contributions to this project! If you'd like to contribute, please follow these steps:

1. Fork the repository.
2. Create a feature branch (`git checkout -b feature/YourFeatureName`).
3. Commit your changes (`git commit -m 'Add some feature'`).
4. Push to the branch (`git push origin feature/YourFeatureName`).
5. Open a pull request.

Please ensure that your code follows the existing coding conventions and passes all tests before submitting a pull request.