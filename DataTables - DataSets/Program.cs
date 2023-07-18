
using System.Data;


// Primer DataTable
DataTable inventoryTable = new DataTable("Inventory");

DataColumn carIDColumn = new DataColumn("CarID", typeof(int));
inventoryTable.Columns.Add(carIDColumn);
//DataColumn custIDFKColumn = new DataColumn("CustIDFK", typeof(int));
//inventoryTable.Columns.Add(custIDFKColumn);

// Algunas propiedades
carIDColumn.Caption = "Car ID";
carIDColumn.ReadOnly = true;
carIDColumn.AllowDBNull = false;
carIDColumn.Unique = true;
carIDColumn.AutoIncrement = true;
carIDColumn.AutoIncrementSeed = 0;
carIDColumn.AutoIncrementStep = 1;

// Forma alternativa
DataColumn carMakeColumn = new DataColumn("Make", typeof(string));
DataColumn carColorColumn = new DataColumn("Color", typeof(string));
inventoryTable.Columns.AddRange(new DataColumn[] { carMakeColumn, carColorColumn });

DataRow carRow = inventoryTable.NewRow();
carRow["Make"] = "BMW";
carRow["Color"] = "Black";
//carRow["CustIDFK"] = 0; // Corrección aquí
inventoryTable.Rows.Add(carRow);

// Segundo DataTable

DataTable customerTable = new DataTable("Customer");

DataColumn customerIDColumn = new DataColumn("CustID", typeof(int));
customerTable.Columns.Add(customerIDColumn);

customerIDColumn.Caption = "Customer ID";
customerIDColumn.ReadOnly = true;
customerIDColumn.AllowDBNull = false;
customerIDColumn.Unique = true;
customerIDColumn.AutoIncrement = true;
customerIDColumn.AutoIncrementSeed = 0;
customerIDColumn.AutoIncrementStep = 1;

DataColumn customerNameColumn = new DataColumn("Name", typeof(string));
customerTable.Columns.AddRange(new DataColumn[] { customerNameColumn });

DataRow customerRow = customerTable.NewRow();
customerRow["Name"] = "Lionel";
customerTable.Rows.Add(customerRow);

//Recorrido de primer data table
foreach (DataRow dr in inventoryTable.Rows)
{
    Console.WriteLine("ID: " + dr[0] + " Marca: " + dr[1] + " Color: " + dr[2]);
}

// Recorrido de segundo data table
foreach (DataRow dr in customerTable.Rows)
{
    Console.WriteLine("ID: " + dr[0] + " Nombre: " + dr[1]);
}

// Creacion de dataset y agregar datatables
DataSet carInventoryDS = new DataSet("Car Inventory");
carInventoryDS.Tables.Add(inventoryTable);
carInventoryDS.Tables.Add(customerTable);

// Creacion de la relacion
DataRelation relation = new DataRelation("Buy", customerTable.Columns["CustID"], inventoryTable.Columns["CarID"], true);

// Agregar una data relation
carInventoryDS.Relations.Add(relation);

// Recorrer una data relation
foreach (DataRow drPadre in customerTable.Rows)
{
    Console.WriteLine("ID: " + drPadre[0] + " Name: " + drPadre[1]);

    foreach (DataRow drHijo in drPadre.GetChildRows(relation))
    {
        Console.WriteLine("\tID: " + drHijo[0] + " Make: " + drHijo[1] + " Color: " + drHijo[2]);
    }
}