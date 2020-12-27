# Eau Claire's Salon: Stylist-Client Database

#### _A web app that . 26/12/2020_

#### By _**Constantine Yakubovski**_ 

## Description 
_This web app will allow a hair salon owner to track stylists and their clients. User will be able to add new stylists, view list of existing stylists, assign  new clients to existing stylists, see clients details and update their info._

### SPECS: ###

1. SPEC: To display a splash page with Eau Claire's Salon

**Input**: `dotnet run`

**Output**: Welcome to Eau Claire's Salon (splash page)
____________________________________________________________________________________

2. SPEC: Ability to add stylists and clients 

**Input**: click on "Add New Stylist" , "Add New Client"

**Output**: forms to add new Stylist or client
____________________________________________________________________________________

3. SPEC: Ability to view current stylists and their clients

**Input**: click on "stylist List" , "Client List"

**Output**: list of stylists or their clients
____________________________________________________________________________________

## Setup/Installation Requirements
STEP 1
- Install [MySQL Workbench](https://dev.mysql.com/downloads/file/?id=484391)
- Open MySQL Workbench and select the _Local instance 3306_ server.
- Install  [.Net Core](https://dotnet.microsoft.com/download/dotnet-core/2.2)
- `$ dotnet tool install -g dotnet-script` - use Terminal to Install REPL 

STEP 2
-  `$ cd ~` - it will navigate to the user's home directory
-  `$ cd desktop`- it will navigate to the desktop
-  `$ git clone` ,then copy/paste https://github.com/faustlarsen/HairSalon , then press enter - it will create the file on the desktop
-  `$ cd HairSalon.Solution` - it will enter the folder
-  `$ code .` - it will launch VSCode ( text editor ) to open the file
-  `$ touch appsettings.json` - create this file in root directory
- Copy this and paste in appsettings.json file: 
{
  "ConnectionStrings": { "DefaultConnection": "Server=localhost;Port=3306;database=constantine_yakubovski;uid=root;pwd=epicodus;"
  }
}
-  `$ dotnet restore`
    
STEP 3 
## DATABASE SETUP 
Copy and Paste the following commands in the terminal. (exclude '$' and '>')
-  `$ mysql -uroot -pepicodus ` - start MySQL Server 
-  `> CREATE DATABASE constantine_yakubovski; ` 
-  `> USE constantine_yakubovski; `
-  `> CREATE TABLE clients (ClientId INT(11) PRIMARY KEY NOT NULL AUTO_INCREMENT, Name VARCHAR (255) DEFAULT NULL, Description VARCHAR (255), StylistId INT(11) DEFAULT NULL, Appointment DATETIME DEFAULT NULL); `
-  `> CREATE TABLE stylists (StylistId INT(11) PRIMARY KEY NOT NULL AUTO_INCREMENT, Name VARCHAR (255) DEFAULT NULL, Specialty VARCHAR (255) DEFAULT NULL); `
- `> exit ` - to exit MySQL
- `$ dotnet watch run ` - to run app the app
- Then in console click on (localhost:5000) to view the app in the browser


## Known Bugs

- Time doesn't update

## Support and contact details

__faustlarsen@gmail.com__

## Technologies Used

-  _C#_

-  _ASP.NET_

-  _MVC_

-  _My SQL_

-  _HTML_

- _ Entity_

-  _Written in VS Code_

### License

This software is licensed under the MIT license

Copyright (c) 2020 **_Constantine Yakubovski_**

