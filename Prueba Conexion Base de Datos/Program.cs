using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;

using (SqlConnection cn = new SqlConnection())
{
    cn.ConnectionString = GetConnectionString();
    cn.Open();
    Console.WriteLine(cn.State);
    //Console.ReadLine();

    string strSQL = "Select count(*) From Cliente";
    SqlCommand cmd = new SqlCommand(strSQL, cn);

    Console.WriteLine($"Cantidad " + cmd.ExecuteScalar());

    Console.ReadLine();

    //string strSQL = "Select Id, Nombre, Apellido From Cliente";
    //SqlCommand cmd = new SqlCommand(strSQL, cn);

    //using (SqlDataReader myDataReader = cmd.ExecuteReader())
    //{
    //    while (myDataReader.Read()) // Se itera mientras haya filas disponibles
    //    {
    //        Console.WriteLine("Id: {0} - Nombre: {1} - Apellido: {2}",
    //            myDataReader["Id"].ToString(),
    //            myDataReader["Nombre"].ToString(),
    //            myDataReader["Apellido"].ToString());
    //    }
    //}
}
// No necesariamente se necesita de using, es solo para el manejo de recursos. 

string GetConnectionString()
{
    return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\bocaj\source\repos\Programacion III\PruebasBaseDeDatos\PruebaBD.mdf"";Integrated Security=True";
}