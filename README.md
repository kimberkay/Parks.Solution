# Parks API

#### By: Kim Brannian

#### _An API to list national and state parks._

## Technologies Used
* C#
* .NET5
* NuGet
* ASP.NET Core
* Swagger
* git
* GitHub
* MySQL
* MySQL Workbench
* Google Sheets
* Cors

## Description
_An api with full CRUD so a user may create, read, update and delete a list of national and state parks with brief descriptions._

## Setup/Installation Instructions
* Download, install, and configure MySQL
* Open the terminal on your desktop
* Once in the terminal, use it to navigate to your desktop folder
* Once inside your desktop folder, use the command `git clone https://github.com/kimberkay/Parks.Solution.git`
* After cloning the project, navigate into it using the command `cd Parks.Solution/Parks`
* Create a file named "appsettings.json" in the `Parks` directory
* Add the following code to appsettings.json and add your MySQL user ID and password:
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=parks;uid=[YOUR MYSQL USER ID];pwd=[YOUR MYSQL PASSWORD];"
  }
}
```
* Then run the command `dotnet ef database update`
* After creating the database, you'll need to populate it with the data in the .csv file.
* Go to MySQL Workbench and navigate to the table `parks`. Click on the arrow on the left to open the schema details. 
* Right click on `parks` table and select "Table Data Import Wizard"
* Navigate to where you cloned the project and select the file `parks.csv`
* Click next through the following windows to import the data
* If you need help, see this article: https://towardsdatascience.com/how-to-import-a-csv-file-into-mysql-workbench-17cb120169c8 
* After importing the data, return to your terminal
* Then run the command `dotnet restore` to install project dependencies
* Then run the command `dotnet run` to start the server

## API endpoints
#### HTTP Requests
```
GET /api/Parks
POST /api/Parks
GET /api/Parks{id}
DELETE /api/Parks{id}
```

#### Path Parameters
| Parameter | Type | Description |
| :---: | :---: | --- |
| Name | string | Returns any park by name |
| Type | string | Returns any park by type (national or state) |
| State | string | Returns any park by state |


#### Example Query
```
http://localhost:5000/api/parks/?state=alaska&type=national
```

#### Sample JSON
```
{
        "parkId": 1,
        "name": "Denali National Park",
        "type": "National",
        "state": "Alaska",
        "established": "February 26, 1917",
        "acres": "4,740,911",
        "overView": "Centered on Denali, the tallest and highest prominent mountain in North America, Denali is serviced by a single road leading to Wonder Lake. denali and other peaks of the Alaska Range are covered with long glaciers and boreal forest. Wildlife includes grizzly bears, dall sheep, porcupine, caribou and wolves."
    }
```

#### Swagger Instructions
This API uses [Swagger](https://swagger.io/tools/swagger-ui/) REST API Documentation

* Navigate to http://localhost:5000/index.html to access Swagger and view API endpoints
* Note: the server must be running to access Swagger and test out parameters

## Known Bugs
* Can only be locally run

## License
_MIT License: https://opensource.org/licenses/MIT_

Copyright (c) _2022_ _Kim Brannian_
