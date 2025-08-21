// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class Dispositivos

{
    public int Id;
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