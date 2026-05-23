using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList casoList = new CasoList();

        Alumno alumno1 = new Alumno(58463, "Catalina", 9.0);
        Alumno alumno2 = new Alumno(58202, "Marcos", 8.50);
        Alumno alumno3 = new Alumno(57900, "Lara", 9.50);

        casoList.AgregarAlumno(alumno1);
        casoList.AgregarAlumno(alumno2);
        casoList.AgregarAlumno(alumno3);

        Console.WriteLine("Lista de Alumnos");
        foreach (var alumno in casoList.GetAlumnos())
        {
            Console.WriteLine(alumno);
        }

        Console.WriteLine("\nBuscar Alumno por Nombre");

        Alumno? alumnoBuscado = casoList.BuscarAlumno("Lara");
        if(alumnoBuscado != null)
        {
            Console.WriteLine(alumnoBuscado);
        }
        else
        {
            Console.WriteLine("Error: No existe alumno");
        }

        Console.WriteLine("\nBuscar Alumno por Nombre que no Exista");

        Alumno? alumnoNoExiste = casoList.BuscarAlumno("Florencia");
        if (alumnoNoExiste != null)
        {
            Console.WriteLine(alumnoNoExiste);
        }
        else
        {
            Console.WriteLine("Error: No existe alumno");
        }

        Console.WriteLine("\nEliminar Alumno");

        casoList.EliminarAlumno(alumno2);

        Console.WriteLine("Listado Actualizado");

        foreach(var alumno in casoList.GetAlumnos())
        {
            Console.WriteLine(alumno);
        }

        Console.WriteLine("\nEliminar Alumno por Posición");

        casoList.EliminarAlumnoPorPosicion(0);

        Console.WriteLine("Listado Actualizado");

        foreach (var alumno in casoList.GetAlumnos())
        {
            Console.WriteLine(alumno);
        }
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary casoDictionary = new CasoDictionary();

        casoDictionary.agregarAlumno(new Alumno(58463, "Catalina", 9.0));
        casoDictionary.agregarAlumno(new Alumno(58202, "Marcos", 8.50));
        casoDictionary.agregarAlumno(new Alumno(57900, "Lara", 9.50));

        Console.WriteLine("Lista de Alumnos");
        foreach (var alumno in casoDictionary.getDiccionario())
        {
            Console.WriteLine(alumno.Value);
        }
        Console.WriteLine();

        Console.WriteLine("\nBuscar Alumno por Clave");
        Alumno? alumnoBuscado = casoDictionary.buscarPorClave(57900);
        if (alumnoBuscado != null)
        {
            Console.WriteLine(alumnoBuscado);
        }
        else
        {
            Console.WriteLine("Error: No existe el alumno");
        }
        Console.WriteLine();

        Console.WriteLine("\nBuscar Alumno por Clave que no Exista");
        Alumno? alumnoNoExiste = casoDictionary.buscarPorClave(58000);
        if (alumnoNoExiste != null)
        {
            Console.WriteLine(alumnoNoExiste);
        }
        else
        {
            Console.WriteLine("Error: No existe el alumno");
        }
        Console.WriteLine();

        Console.WriteLine("\nEliminar Alumno por Clave");
        casoDictionary.eliminarAlumno(58202);
        foreach (var alumno in casoDictionary.getDiccionario())
        {
            Console.WriteLine(alumno.Value);
        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq casoLinq = new CasoLinq();

        Console.WriteLine("1- Obtener el Primero");
        var primero = casoLinq.GetPrimero();
        Console.WriteLine($"Primer libro: {primero?.Titulo ?? "No hay libros"}");

        Console.WriteLine("\n2- Obtener el Ultimo");
        var ultimo = casoLinq.GetUltimo();
        Console.WriteLine($"Ultimo libro: {ultimo?.Titulo ?? "No hay libros"}");

        Console.WriteLine("\n3- Obtener el Precio Total");
        decimal totalPrecios = casoLinq.GetTotalPrecios();
        Console.WriteLine($"Suma total de precios: {totalPrecios:C}");

        Console.WriteLine("\n4- Obtener el Precio Promedio");
        decimal promedioPrecios = casoLinq.GetPromedioPrecios();
        Console.WriteLine($"Promedio de precios: {promedioPrecios:C}\n");

        Console.WriteLine("\n5- Obtener Libros con ID mayor a 15");
        var librosByIdMayorA15 = casoLinq.GetListById();
        foreach (var libro in librosByIdMayorA15)
        {
            Console.WriteLine($"   - {libro.Titulo} (Id: {libro.Id})");
        }

        Console.WriteLine("\n6- Obtener el Listado de Libros por Título y Precio");
        var librosConFormato = casoLinq.GetLibros();
        foreach (var libro in librosConFormato)
        {
            Console.WriteLine($"   - {libro}");
        }

        Console.WriteLine("\n7- Obtener el Libro con el precio mas Alto");
        var libroMasCaro = casoLinq.GetMayorPrecio();
        Console.WriteLine($"Libro con el precio mas alto: {libroMasCaro?.Titulo} ({libroMasCaro?.Precio:C})");

        Console.WriteLine("\n8- Obtener el Libro con el precio mas Bajo");
        var libroMasBarato = casoLinq.GetMenorPrecio();
        Console.WriteLine($"Libro con el precio mas bajo: {libroMasBarato?.Titulo} ({libroMasBarato?.Precio:C})");

        Console.WriteLine("\n9- Obtener Libros con precio mayor al promedio:");
        var librosMayorAlPromedio = casoLinq.GetMayorPromedio();
        foreach (var libro in librosMayorAlPromedio)
        {
            Console.WriteLine($"   - {libro.Titulo} ({libro.Precio:C})");
        }

        Console.WriteLine("\n10- Obtener Libros ordenados por título de forma descendente:");
        var librosOrdenadosDesc = casoLinq.GetLibrosOrdenados();
        foreach (var libro in librosOrdenadosDesc)
        {
            Console.WriteLine($"   - {libro.Titulo}");
        }

    }
}
