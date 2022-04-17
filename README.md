# Code Review 11 (Sweet Market)

## by _**Jonathan Delcid**_

### _April 9, 2022_

#### _In this website, a user is able to log in, log out and add thier favorite sweets and flavors!_

## Technologies Used
- _C#_
- _.Net 5_
- _REPL_
- _MySQL_
- _Razor_
- _ASP.NET Core_

## Project Title: Factory

## Project Setup/Installation Instructions <a id="setup"></a>

### Install C#, .NET, MySQL Community Server and MySQL Workbench

- Open the terminal on your local machine
- If [C#](https://docs.microsoft.com/en-us/dotnet/csharp/) and [.NET](https://docs.microsoft.com/en-us/dotnet/) are not installed on your local device, follow the instructions here [here](https://www.learnhowtoprogram.com/c-and-net-part-time/getting-started-with-c/installing-c-and-net).
- If [MySQL Community Server](https://dev.mysql.com/downloads/mysql/) and [MySQL Workbench](https://www.mysql.com/products/workbench/) are not installed on your local device, follow the instructions [here](https://www.learnhowtoprogram.com/c-and-net-part-time/getting-started-with-c/installing-and-configuring-mysql).
- If [dotnet-ef](https://docs.microsoft.com/en-us/ef/core/cli/dotnet) is not installed on your local device, install it globally with the terminal command ```dotnet tool install --global dotnet-ef --version 5.0.2```.

### Clone the project

- Open the terminal on your local computer.
- Navigate to the parent directory of your preference.
- Clone this project using `$ git clone https://github.com/delcidj22/Code-Review-11`


### Scaffold and connect the database

- Launch the MySQL server with the command `mysql -uroot -p[YOUR-PASSWORD-HERE]`
- Navigate to the directory: `$ cd Code-Review-11`
- Open in Vs code: `$ code .`
- Navigate to the project directory SweetMarket: `$ cd SweetMarket` and type the following command in the terminal `$ touch appsettings.json`
- In the appsettings.json file enter the following code:

```
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=jonathan_delcid;uid=root;pwd=[YOUR-PASSWORD-HERE];"
    }
}
```
- Recreate project environment and install required dependencies with terminal command `$ dotnet restore`
- Build the program with the command `$ dotnet build`
- Scaffold the database with the command ```$ dotnet ef database update```

### Run the project
- Run the program with the command `$ dotnet run`


## Known Bugs
- None



## License
[MIT License](https://opensource.org/licenses/MIT) Published _**2022**_ _**Jonathan Declid**_

## Contact Information
_If you encounter any issues with this site, please contact Jonathan Delcid at [jdelcid23@gmail.com]_
Copyright (c) _04/09/2022_ _Jonathan Delcid_