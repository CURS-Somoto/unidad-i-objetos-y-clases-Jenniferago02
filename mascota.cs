using System;

class Mascota
{
    public string Nombre { get; set; }
    public string Tipo { get; set; }
    public int Edad { get; set; }

    public Mascota(string nombre, string tipo, int edad)
    {
        Nombre = nombre;
        Tipo = tipo;
        Edad = edad;
    }
}

class Program
{
    static void Main()
    {
        // Crear objetos de la clase Mascota
        Mascota mascota1 = new Mascota("Rex", "Perro", 3);
        Mascota mascota2 = new Mascota("Mittens", "Gato", 2);
        Mascota mascota3 = new Mascota("Tweety", "Pájaro", 1);

        // Mostrar la información de las mascotas
        Console.WriteLine("Mascota 1: Nombre - {0}, Tipo - {1}, Edad - {2} años", mascota1.Nombre, mascota1.Tipo, mascota1.Edad);
        Console.WriteLine("Mascota 2: Nombre - {0}, Tipo - {1}, Edad - {2} años", mascota2.Nombre, mascota2.Tipo, mascota2.Edad);
        Console.WriteLine("Mascota 3: Nombre - {0}, Tipo - {1}, Edad - {2} años", mascota3.Nombre, mascota3.Tipo, mascota3.Edad);
    }
}
