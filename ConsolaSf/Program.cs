// See https://aka.ms/new-console-template for more information
using System.Data.Common;
using System.Net.WebSockets;

Console.WriteLine("Hello, World!");

Videojuegos videojuego = new Videojuegos();
videojuego.Id = 1;
videojuego.Nombre = "Super Mario Bros";
videojuego.Version = 1.0m;
videojuego.Existe = true;
videojuego.Fecha = DateTime.Now;
videojuego.dispositivo = new Dispositivos() { Id = 1, Nombre = "PC", Valido = true };

public class Dispositivos

{
    public int Id;
    public string? Nombre;
    public bool Valido;
}


public class Videojuegos
{
    public int Id;
    public string? Nombre;
    public decimal Version;
    public bool Existe;
    public DateTime Fecha;
    public Dispositivos? dispositivo; 
}

public class VideojuegosPc
{
    public string? Emulador;
}