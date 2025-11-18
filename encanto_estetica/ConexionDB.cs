using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

public class ConexionDB : IDisposable
{
    private MySqlConnection connection;
    private bool disposed = false;

    public ConexionDB()
    {
        string connectionString = "port=3306;server=127.0.0.1;database=encanto_estetica;user=root;password=091003";
        connection = new MySqlConnection(connectionString);
    }
    public async Task OpenAsync()
    {
        await connection.OpenAsync();
    }

    public MySqlConnection GetConnection()
    {
        return connection;
    }

    public void OpenConnection()
    {
        if (connection.State == System.Data.ConnectionState.Closed)
            connection.Open();
    }

    public void CloseConnection()
    {
        if (connection.State == System.Data.ConnectionState.Open)
            connection.Close();
    }



    // Implementación de IDisposable
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this); // Suprime el finalizador
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                // Liberar los recursos administrados
                if (connection != null)
                {
                    connection.Close();
                    connection.Dispose();
                }
            }
            disposed = true;
        }
    }

    ~ConexionDB()
    {
        Dispose(false); // Llamar a Dispose desde el finalizador
    }
}

