using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

public class ConnectionManager
{
    private string conString = @"Network Library=DBMSSOCN;" +
                                "Data Source=apv8jive40.database.windows.net,1433;" +
                                "database=team3-to8;" +
                                "User id=michael@apv8jive40;" +
                                "Password=Ditisonzedatabase!;";
    private static ConnectionManager instance;

    private ConnectionManager() {}

    public static ConnectionManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new ConnectionManager();
            }
            return instance;
        }
    }

    public SqlConnection CreateConnection()
    {
        return new SqlConnection(conString);
    }
}
