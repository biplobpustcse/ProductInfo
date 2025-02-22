# ProductInfo

#### 1. Ensure Proper File Properties for appsettings.json
Right-click on the appsettings.json file in Solution Explorer, and ensure the following properties are set:

Build Action: Content
Copy to Output Directory: Copy if newer or Copy always
These settings ensure that the file is treated as content (not a code file) and is copied to the output directory when you build your project.

#### 2. Install Required NuGet Package
Since we are using Dapper, install it via NuGet:
```
dotnet add package Dapper
```
#### 3. Create SQL Table (If Not Already Created)
```
CREATE TABLE Products (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(255) NOT NULL,
    Price DECIMAL(18,2) NOT NULL
);
```
