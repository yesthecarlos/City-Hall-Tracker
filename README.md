# _City Hall Tracker_

#### _Government activity tracking app using C#/.NET 5_

#### By _**Carlos Mendez**_

## Technologies Used

* C#
* .NET 5
* Entity Framework Core 5
* Identity 
* MySQL

## Description

_This project uses dotnet new mvc to bootstrap a program that allows the user to view government actions by parsing city hall business meeting minutes and storing them in a database for recall by the user._


## Setup and Use

### Prerequisites
* [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
* A text editor like [VS Code](https://code.visualstudio.com/)
* A web browser to run and interact with the web app.

### Installation
1. Clone the repository: `$ git clone https://github.com/yesthecarlos/city-hall-tracker`
2. Navigate to the `city-hall-tracker/` directory on your computer
3. Open with your preferred text editor to view the code base
4. Create a file named appsettings.json and save it in the project's root directory. It should contain the following code:
```c#
{
  "ConnectionStrings": 
  {
    "DefaultConnection": "Server=localhost;Port=3306;database=carlos_mendez;uid=[user];pwd=[password];"
  }
}
```
5. To run the web app:
    * Run the command `dotnet restore` to restore the dependencies that are listed in the .csproj
    * Run the commmand `dotnet build` to build the project and its dependencies into a set of binaries
    * Run the command `dotnet ef database update` to build the database using the Migrations folder
    * Run the command `dotnet run` to run the project
    * Finally, open the project in your web browser, using the specified address (default is localhost:5000)


## Known Bugs

_This app is still in the initial development stages._


## License

_Copyright 2021 Carlos Mendez_

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

_

## Contact Information

_carlosmendez86@gmail.com_