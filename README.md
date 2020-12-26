# Eau Claire's Salon: Stylist-Client Database

#### _A web app that tracks the vendors that purchase goods and the orders belonging to those vendors. 18/12/2020_

#### By _**Constantine Yakubovski**_ 

## Description 
_This web app will offer to add a vevdors and an ability to add orders to each vendor and keep track of them._

### SPECS: ###

1. SPEC: Create Vendor class with name, description and id.

**Input**: "Suzie's Cafe" , "Coffe shop" 

**Output**: "Suzie's Cafe" , "Coffe shop" , Id:1
____________________________________________________________________________________

2. SPEC: Create Order class with name, description, price, date and id.

**Input**:  "Suzie's Cafe" , "10 Croissants" , $10

**Output**: "Suzie's Cafe" , "10 Croissants" , $10 , Id:1
____________________________________________________________________________________

3. SPEC: Create iput forms for orders and  vendors and pages to navigate between them.

**Input**: 

**Output**: 
____________________________________________________________________________________


-  _Open Terminal_
-  `$ cd ~` - it will navigate to the user's home directory
-  `$ cd desktop`- it will navigate to the desktop
-  `$ git clone` ,then copy/paste https://github.com/faustlarsen/Vendor.Solution , then press enter - it will create the file on the desktop
-  `$ cd Vendor.Solution` - it will enter the folder
-  `$ code .` - it will launch VSCode ( text editor ) to open the file
-   Install  [.Net Core](https://dotnet.microsoft.com/download/dotnet-core/2.2)
-  `$ dotnet tool install -g dotnet-script`  - it will instal REPL to run the app
-  `$ dotnet build` - it will compile the app
-  `$ cd Vendor` - it will navigate to the launching directory
-  `$ dotnet run` - it will prep the app for launching. Then in console click on (localhost:5000/) to view the app in the browser
TESTING
- Navigate into Vendor directory
-  `$ ls` - to see which directory you are currently in
-  `$ cd ..` - to exit Vendor directory
-  `$ cd Vendor.Tests` - to navigate into Vendor.Tests directory.
-  `$ dotnet restor` then `$ dotnet build` - to make code is compiled and packages are installed
-  `$ dotnet test` to run test on all methods

## Known Bugs

## Support and contact details

__faustlarsen@gmail.com__

## Technologies Used

-  _C#_

-  _REPL_

-  _.NET Core 2.2_

-  _Written in VS Code_

### License

This software is licensed under the MIT license

Copyright (c) 2020 **_Constantine Yakubovski_**

