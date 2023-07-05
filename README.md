JSON Value Checker API Test Project
-

Description
-
The JSON Value Checker API is a basic test project that verifies the correctness of specific values within JSON responses.
Users can define expected values for specific fields and ensure that the JSON response matches those values.

Technologies used:
- 
  1. RestSharp: An open-source HTTP Client library that we can use to consume APIs
  2. NewtonSoft.Json: An open-source library for JSON (JavaScript Object Notation) serialization and deserialization in the .NET ecosystem
  3. JSON Schema: JSON Schema is utilized to define validation rules and ensure the correctness of JSON payloads.

Prerequisites
-
- Visual Studio 2022
- .NET Framework
- NuGet Package Manager (RestSharp 110.2.0 and NewtonSoft.Json 13.0.3)

Getting Started
-
1. Clone or download the repository to your local machine.
2. Open the solution file (**API_Testing.sln**) in Visual Studio.
3. Right-click on the solution and select **Build Solution** to restore NuGet packages and compile the project.
4. Open the test file (**RegressionTests.cs**) located in the **API_Testing** folder.
5. Run the tests using the Test Explorer in Visual Studio or via the command line using a test runner such as dotnet test.
6. View the test results and ensure that the field value checks pass for the specified API responses.

Troubleshooting
-
- Ensure that the API endpoint is correct and accessible.
- Double-check the field names and values you are validating against the API response.
- Review the error messages or exceptions thrown during the test execution for clues.

Contact
-
For any questions or inquiries, please contact <mercadosophia1224@gmail.com>

Acknowledgments
-
The creators and contributors of Visual Studio and the .NET Framework for providing a robust development environment for C# projects.
The open-source community for their valuable contributions to libraries and frameworks used in this project.

