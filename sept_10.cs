sept_10.cs
// Variables

int age = 30;
string name = "Thomas";
bool active = true;

// control flow
if (age > 25)
{
    Console.WriteLine("Older than 25");
}
else
{
    Console.WriteLine("25 or younger");,
}

// loop
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}

// working with data
using System.Data.SqlClient;

string connectionString = "Server=.;Database=MyDB;Trusted_Connection=True;";
string query = "SELECT TOP 5 Name, Age FROM Customers";

using (SqlConnection conn = new SqlConnection(connectionString))
{
    SqlCommand cmd = new SqlCommand(query, conn);
    conn.Open();

    SqlDataReader reader = cmd.ExecuteReader();
    while (reader.Read())
    {
        Console.WriteLine(reader["Name"] + " - " + reader["Age"]);
    }
}

// data mapping
public class Customer
{
    public string Name { get; set; }
    public int Age { get; set; }
}