using Patrones_de_diseño;
//Patrón de diseño para cuando dos o más clases heredan de una y dependiendo del contexto se llama a la clase correspondiente
//En este caso es por ejemplo para cuando tenemos 2 o más bases de datos
DataBases result =  HandleDataBase.Selector(HandleDataBase.SqlServer);
Console.WriteLine(result.DBSelected());
Console.ReadLine();