using Arreglos.Logica;
Console.WriteLine("Arreglo");
MiArreglo oMiArreglo = new MiArreglo(5);

try
{
    oMiArreglo.Agregar(7);
    oMiArreglo.Agregar(-2);
    oMiArreglo.Agregar(8);

    Console.WriteLine(oMiArreglo);
    Console.WriteLine("Insertar 500 en posicion 1");
    Console.ReadKey();
    oMiArreglo.Insertar(500, 1);
    Console.WriteLine(oMiArreglo);

    Console.WriteLine("Eliminar 500 en posicion 1");
    Console.ReadKey();
    oMiArreglo.Eliminar(1);
    Console.WriteLine(oMiArreglo);

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
Console.WriteLine(oMiArreglo);

MiArreglo oMyArreglo = new MiArreglo(100);
try
{

    Console.WriteLine("\nArreglo\n");
    oMyArreglo.Llenar():
    Console.WriteLine(oMyAreglo);
    Console.ReadKey();

    Console.WriteLine("\Pares\n");
    var verPares = oMyArreglo.btenerPares();
    Console.WriteLine(verPares);
    Console.ReadKey();

    Console.WriteLine("\Pares Ordenados\n");
    var verPares.Ordenar(true);
    Console.WriteLine(verPares);
    Console.ReadKey();


}

//oMiArreglo.Llenar(1, 20);
//Console.WriteLine("Arreglo desordenado \n");
//Console.WriteLine(oMiArreglo);
//Console.WriteLine("Arreglo ordenado ascendente \n");  
//oMiArreglo.Ordenar();
//Console.WriteLine(oMiArreglo);
//Console.WriteLine("Arreglo ordenado descendente \n");
//oMiArreglo.Ordenar(false);
//Console.WriteLine(oMiArreglo);
//Console.ReadKey();
