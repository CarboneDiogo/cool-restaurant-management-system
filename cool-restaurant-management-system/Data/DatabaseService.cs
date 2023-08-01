namespace cool_restaurant_management_system.Data;
using SQLite;
using System.IO;
using System.Runtime.InteropServices;

public class DatabaseService
{
    public static SQLiteAsyncConnection GetDatabaseConnection(string dbName, string folderPath)
    {
        var dbPath = Path.Combine(folderPath, dbName);

        var connection = new SQLiteAsyncConnection(dbPath);

        return connection;
    }
}