# ASP.NET Framework Project Setup

Follow these steps to clone the ASP.NET Framework repository and set up the project using a Code-First approach.

## Clone the Repository

1. Open a terminal or command prompt.

2. Navigate to the directory where you want to clone the repository:

3. https://github.com/Sha12687/GorceryDeliveryApplication
   
## Update Connection String

1. Open the `Web.config` file.

2. Locate the `<connectionStrings>` section.

3. Update the connection string with your database server details, database name, and credentials. Find the following XML snippet:

    ```xml
    <add name="YourDbContext" connectionString="Data Source=YourServer;Initial Catalog=YourDatabase;Integrated Security=True;" providerName="System.Data.SqlClient" />
    ```

   Replace `YourDbContext`, `YourServer`, `YourDatabase`, and provide appropriate authentication details.

4. Save the changes to the `Web.config` file.

## Update Database

1. Open the Package Manager Console (PMC) in Visual Studio.

2. Run the following commands to apply migrations and update the database:

   ```bash
   Enable-Migrations
   Update-Database

