
# _Dr. Sillystringz's Factory_

#### By **Aaron Brown**

#### A web site for tracking a Factory's machinery and engineers to maintain them.

## Technologies Used

* C#
* ASP.NET Core MVC
* MySQL

## Description
This utility allows for order creation and matching of machines and engineers to each other.


## Setup Requirements

* You'll need the .NET SDK installed on your system to run the app.  Documentation for the .NET SDK is available here.
* Install dotnet-ef globally to enable databse migrations using the following command
  ```bash
  $ dotnet tool install --global dotnet-ef --version 6.0.0
  ```
* In the production directory of the current project, add the package for Microsoft.EntityFrameworkCore.Design using the following command
  ```bash
  $ dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0
  ```
* For further database migration assistance, this [lesson](https://part-time-evening.learnhowtoprogram.com/c-and-net/many-to-many-relationships/code-first-development-and-migrations) from learnhowtoprogram.com is helpful.
* Clone the repository **git clone https://github.com/aaronvbrown/Factory.Solution.git**  in the terminal
* Navigate to this project's production directory "Factory"
* Create a file appsettings.json, adding the following code.  (Replace uid and pwd with your own username and password for MySQL)
  ```json
  {
    "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=aaron_brown;uid=[your-username];pwd=[your-password];"
    }
  }
  ```
* Run **dotnet ef database update** from the command line to create a database locally that the project can use.
* Run **dotnet run** in the command line to start the app
* Run **dotnet watch run** in the command line to load in development mode with a watcher
* Open the browser to **https://Localhost:5001**

## Known Bugs
* None at this time
* Please report any bugs at the [github repo issues page](https://github.com/aaronvbrown/Factory.Solution/issues)

## License
MIT License

Copyright (c) 2023 Aaron Brown