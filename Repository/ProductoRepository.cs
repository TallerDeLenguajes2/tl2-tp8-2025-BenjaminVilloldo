using System.Data.Common;
using Microsoft.Data.Sqlite;

public class ProductoRepository
{
    private string conexion = "DATA Source = db/Tienda_final.db";
    public List<Productos> getAll()
    {
        string selectQuery = "SELECT * FROM productos";
        List<Productos> productos = []; // creas una nueva lista para devolver
        using var conection = new SqliteConnection(conexion);
        conection.Open(); //abrimos la conexion definida en el string: conexion (la base de datos)
        var command = new SqliteCommand(selectQuery, conection); //inicializas un comando
        using (SqliteDataReader reader = command.ExecuteReader())
        {
             
            while (reader.Read())
            {
                var _producto = new Productos
                {
                    idProducto = Convert.ToInt32(reader["idProducto"]),
                    descripcion = reader["Descripcion"].ToString(),
                    precio = Convert.ToInt32(reader["Precio"])
                };
            productos.Add(_producto);
            };

            conection.Close();
            return productos;
        }
    }

} 