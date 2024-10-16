public interface IDbConnection
{
    void ConnectToDatabase(string url);
}

public class DbConnectionFake : IDbConnection
{
    public void ConnectToDatabase(string url)
    {
        // no code needed here
    }
}

public class DatabaseAccess
{
    protected IDbConnection DbConn;

    public DatabaseAccess(IDbConnection dbConn)
    {
        DbConn = dbConn;
    }

    public string QueryDatabase(string query)
    {
        DbConn.ConnectToDatabase("...");
        // ...
        return "Hello World";
    }
}

// -------------------------------

public class Program
{
    public static void Main()
    {
        string query = "SELECT CompanyName FROM Customers ...";
        DatabaseAccess db = new(new DbConnectionFake());
        string result = db.QueryDatabase(query);
        if (result == "ABCD...")
        {

        }
    }
}

