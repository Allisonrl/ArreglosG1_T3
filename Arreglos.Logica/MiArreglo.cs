using Arreglos.Logica;
//Console.WriteLine("Operaciones de pila");
//Console.WriteLine("Arreglo ");
MiArreglo oMiArreglo = new MiArreglo(500);
try
{
    Console.WriteLine("\nArreglo\n");
    var tiempo1 = DateTime.Now;
    oMiArreglo.Llenar(1, 999999);
    Console.WriteLine(oMiArreglo);
    var tiempo2 = DateTime.Now;

    var restaTiempo = tiempo2 - tiempo1;

    Console.WriteLine($"\nTiempo transcurrido: {restaTiempo.Minutes} minutos, {restaTiempo.Seconds} segundos, {restaTiempo.Milliseconds} milisegundos, {restaTiempo.Nanoseconds} nanosegundos");
    Console.ReadKey();

    //Console.WriteLine("\nPares\n");
    //var verPares = oMiArreglo.ObtenerPares();
    //Console.WriteLine(verPares);
    //Console.ReadKey();

    //Console.WriteLine("\nPares Ordenados\n");
    //verPares.Ordenar();
    //Console.WriteLine(verPares);
    //Console.ReadKey();

    Console.WriteLine("\nPrimos\n");
    var tiempop1 = DateTime.Now;
    var verPrimos = oMiArreglo.ObtenerPrimos();
    Console.WriteLine(verPrimos);
    var tiempop2 = DateTime.Now;
    var restaTiempop = tiempop2 - tiempop1;
    Console.WriteLine($"\nTiempo transcurrido: {restaTiempop.Minutes} minutos, {restaTiempop.Seconds} segundos, {restaTiempop.Milliseconds} milisegundos, {restaTiempop.Nanoseconds} nanosegundos");
    Console.ReadKey();

    Console.WriteLine("\nPrimos Ordenados\n");
    var tiempopo1 = DateTime.Now;
    verPrimos.Ordenar();
    Console.WriteLine(verPrimos);
    var tiempopo2 = DateTime.Now;
    var restaTiempopo = tiempopo2 - tiempopo1;
    Console.WriteLine($"\nTiempo transcurrido: {restaTiempopo.Minutes} minutos, {restaTiempopo.Seconds} segundos, {restaTiempopo.Milliseconds} milisegundos, {restaTiempopo.Nanoseconds} nanosegundos");
    Console.ReadKey();

    Console.WriteLine("Primos ordenados burbuja\n");
    verPrimos.Ordenar();
    Console.WriteLine(ver);
    Console.ReadKey();



}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

//try
//{
//    oMiArreglo.Agregar(7);
//    oMiArreglo.Agregar(-2);
//    oMiArreglo.Agregar(8);

//    Console.WriteLine(oMiArreglo);
//    Console.WriteLine("Insertar 500 en posición 1");
//    Console.ReadKey();
//    oMiArreglo.Insertar(500, 1);
//    Console.WriteLine(oMiArreglo);

//    Console.WriteLine("Eliminar 500 en posición 1");
//    Console.ReadKey();
//    oMiArreglo.Eliminar(1);
//    Console.WriteLine(oMiArreglo);

//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);

//}

//oMiArreglo.Llenar(1, 20);

//Console.WriteLine("Arreglo Desordenado");
//Console.WriteLine(oMiArreglo);

//Console.WriteLine("Arreglo Ordenado Ascendenete");
//oMiArreglo.Ordenar();
//Console.WriteLine(oMiArreglo);

//Console.WriteLine("Arreglo Ordenado Descendenete");
//oMiArreglo.Ordenar(false);
//Console.WriteLine(oMiArreglo);

Console.ReadKey();