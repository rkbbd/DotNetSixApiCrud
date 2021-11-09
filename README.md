# DotNetSixApiCrud
.Net 6.0 Api Crud


# .Net 6.0 Api Crud App
![.Net 6.0 Api Crud App - MD RAKIB HASAN](https://github.com/rkbbd/DotNetSixApiCrud/blob/master/project%20preview.png?raw=true)  

In this project, basically CRUD operations are handled. As an example, a product database has been created. There is a product table on this database. Simply listing, deleting, adding and updating operations on the product table are discussed.

## Getting Started
Before creating the project, .net 6.0 sdk must be downloaded and installed. After the necessary SDK installations, make sure to do version control on the command line with the `dotnet --version` command.
### Required packages
* [.Net 6.0 Preview 4 and above SDK](https://dotnet.microsoft.com/download/dotnet/6.0)  
* [Entity Framework Core In Memory Preview 4 and above SDK](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.InMemory/6.0.0-preview.4.21253.1)  
.Net CLI Installation Command :  `dotnet add package Microsoft.EntityFrameworkCore.InMemory --version 6.0.0-preview.4.21253.1`  

### Create a New MinApi Project
After making the necessary installations, run the following command on the command line to create a new project.  

`dotnet new web -o MinApi`   

To open the project in vs code after creating the project, first open the project directory on the command line with the `cd {ProjectFileName}` command, then `code .` you can open the project in a new vs code window with the command
<hr>

### Added swagger support to the project
https://oguzcangenc.medium.com/net-6-0-minapi-i%CC%87le-swagger-kullan%C4%B1m%C4%B1-40e318f78331
