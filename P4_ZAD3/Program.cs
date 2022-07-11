using System;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using P4_ZAD3;

var connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
using SqlConnection connection = new SqlConnection(connectionString) ;


var regions = connection.Query<Region>("Select * from Region");

foreach (var item in regions)
{
    Console.WriteLine($"{item.RegionId}: {item.RegionDescription}");
}

var query = connection.Query<Territories, Region, Territories>(@"SELECT * FROM Territories t JOIN Region r  ON t.RegionID = r.RegionID WHERE t.RegionID LIKE @regionNr",
    (territories, region) =>
    {
        territories.Region = region;
        return territories;
    },
    new { regionNr = "1" },
    splitOn: "RegionID");


foreach (var item in query)
{
    Console.WriteLine($"{ item.territoryDescription } RegionID: {item.Region.RegionId}");
}
