using System;
using System.Collections.Generic;

// Crear objetos de las clases Maestros, Alumnos y Administrativos
Maestros maestros = new Maestros();
Alumnos alumnos = new Alumnos();
Administrativos administrativos = new Administrativos();

// Mostrar menú y pedir selección al usuario
Console.WriteLine("¿Qué información deseas ver?");
Console.WriteLine("1. Maestros");
Console.WriteLine("2. Alumnos");
Console.WriteLine("3. Administrativos");
Console.Write("Selecciona una opción: ");

int opcion = int.Parse(s: Console.ReadLine());

// Mostrar datos de la clase correspondiente
switch (opcion)
{
    case 1:
        Console.WriteLine("Maestros:");
        foreach (var maestro in maestros.DatosMaestros)
        {
            Console.WriteLine($"Matrícula: {maestro.Matricula}, Nombre: {maestro.Nombre}, ApellidoP: {maestro.ApellidoP}, ApellidoM: {maestro.ApellidoM}, FechaN: {maestro.FechaN}, CURP: {maestro.CURP}");
        }
        break;
    case 2:
        Console.WriteLine("Alumnos:");
        foreach (var alumno in alumnos.listaAlumnos)
        {
            Console.WriteLine($"Matrícula: {alumno.Matricula}, Nombre: {alumno.Nombre}, ApellidoP: {alumno.ApellidoP}, ApellidoM: {alumno.ApellidoM}, FechaN: {alumno.FechaN}, CURP: {alumno.CURP}");
        }
        break;
    case 3:
        Console.WriteLine("Administrativos:");
        foreach (var admin in administrativos.ListaAdministrativos)
        {
            Console.WriteLine($"Matrícula: {admin.Matricula}, Nombre: {admin.Nombre}, ApellidoP: {admin.ApellidoP}, ApellidoM: {admin.ApellidoM}, FechaN: {admin.FechaN}, CURP: {admin.CURP}");
        }
        break;
    default:
        Console.WriteLine("Opción inválida");
        break;
}

Console.ReadKey();
