
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
* Set up the database to run with the project.  Instructions are available [here](https://part-time-evening.learnhowtoprogram.com/c-and-net/database-basics/creating-a-test-database-exporting-and-importing-databases-with-mysql-workbench#creating-a-test-database) using the file aaron.brown.sql at the root folder for this repository.
* run **dotnet run** in the command line to start the app
* run **dotnet watch run** in the command line to load in development mode with a watcher
* Open the browser to **https://Localhost:5001**

## Known Bugs
* None at this time
* Please report any bugs at the [github repo issues page](https://github.com/aaronvbrown/Factory.Solution/issues)

## License
MIT License

Copyright (c) 2023 Aaron Brown