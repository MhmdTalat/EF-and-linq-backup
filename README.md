# EF-and-linq-backup

A console application demonstrating Entity Framework Core (EF Core) usage with LINQ queries, focusing on database operations and joins between Categories and Products.

## Description

This project showcases basic Entity Framework Core functionality in a .NET console application. It includes:

- Entity models for `Category` and `Product`
- Database context configuration using SQL Server
- EF Core migrations for database schema management
- LINQ query examples including inner joins and left joins

The application is designed as a learning tool or backup for EF Core and LINQ concepts.

## Prerequisites

- [.NET 10.0 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (LocalDB or full instance)
- Visual Studio 2022 or compatible IDE

## Installation

1. Clone or download the repository.
2. Navigate to the `EFCore` directory.
3. Restore NuGet packages:
   ```
   dotnet restore
   ```

## Database Setup

1. Ensure SQL Server is running and accessible.
2. Update the connection string in `EFCore/Data/Appcontext.cs` if needed (currently set to `Server=MUHAMMEDTA3AT;Database=EFCoreDb;...`).
3. Apply migrations to create the database schema:
   ```
   dotnet ef database update
   ```

## Usage

Run the application from the `EFCore` directory:

```
dotnet run
```

The application currently has commented-out code demonstrating LINQ joins. Uncomment the desired sections in `Program.cs` to see the output.

### Example Queries

The `Program.cs` file contains multiple commented-out examples demonstrating various LINQ and EF Core operations. Uncomment the desired section to run it. Each example outputs results in a formatted console box.

- **Inner Join**: Performs an inner join between Categories and Products on `c.Id == p.CategoryId`, selecting CategoryName, ProductName, and Price. Only matching records are included.

- **Left Join**: Joins Categories and Products with a left join, including all Categories even if they have no Products. Uses `DefaultIfEmpty()` to handle null Products.

- **Right Join**: Simulates a right join by starting from Products and joining to Categories, including all Products even if they have no matching Category.

- **Cross Join**: Creates a Cartesian product of all Categories and Products, combining every Category with every Product.

- **Order By**: Orders Products by Price in descending order and displays ProductName and Price.

- **First and FirstOrDefault**: Finds the first Product with Price > 100 and even (Price % 2 == 0). Uses `FirstOrDefault` to avoid exceptions if no match.

- **Update Part**: Updates the Price of the Product with Id == 1 to 200 and saves changes.

- **Add New Data**: Adds sample Categories ("Electronics", "Books") and Products ("Laptop", "Smartphone", "Novel") if no Products exist in the database.

- **Update Data by User Input**: Prompts the user for a Product Id and new Price, then updates the database. Includes input validation.

- **Add New Product by User Input**: Prompts for CategoryId, Product Name, and Price. Validates inputs and checks if Category exists before adding.

- **Add New Category by User Input**: Prompts for Category Name and adds a new Category to the database.

Output is displayed in a formatted console box for each result.

## Project Structure

- `EFCore.csproj`: Project file with EF Core dependencies
- `Program.cs`: Main application entry point with LINQ examples
- `Data/Appcontext.cs`: EF Core DbContext configuration
- `Model/Category.cs`: Category entity model
- `Model/Product.cs`: Product entity model
- `Migrations/`: EF Core migration files

## Dependencies

- Microsoft.EntityFrameworkCore (9.0.0)
- Microsoft.EntityFrameworkCore.SqlServer (9.0.0)
- Microsoft.EntityFrameworkCore.Tools (9.0.0)

## Contributing

This is a demonstration project. Feel free to modify and experiment with EF Core and LINQ queries.

## License

No specific license provided.
