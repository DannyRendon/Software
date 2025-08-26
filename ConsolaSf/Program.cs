Console.WriteLine("Hello, World!");

var persona = new Personas();
Personas persona1 = new Personas();
Personas persona2 = new Estudiantes();

persona.Id = 1;
persona.Nombre = "Pepito Perez";
persona.Activo = true;
persona.Salario = 1400000.0m;
persona.Tipo = new Tipos() { Id = 1, Nombre = "Casado" };
persona.VideoJuegos = new List<VideoJuegos>();
persona.VideoJuegos.Add(new VideoJuegos() { Id = 1, Nombre = "LOZ 2025" });
persona.VideoJuegos.Add(new VideoJuegos() { Id = 2, Nombre = "Tetrix" });

Console.WriteLine(persona.Nombre);
Console.WriteLine(persona.Tipo.Nombre);

foreach (var elemento in persona.VideoJuegos)
{
    Console.WriteLine(elemento.Nombre);
}

public class Tipos
{
    public int Id = 0;
    public String? Nombre = "";
}

public class VideoJuegos
{
    public int Id = 0;
    public String? Nombre = "";
}

public class Personas
{
    public int Id = 0;
    public String? Nombre = "";
    public DateTime Fecha = DateTime.Now;
    public bool Activo = false;
    public decimal Salario = 0.0m;
    public Tipos Tipo = new Tipos();
    public List<VideoJuegos> VideoJuegos = new List<VideoJuegos>();
}

public interface IEstudiantes
{
    public bool Matricula();

}

public interface ISeguros
{
    public decimal SeguroDeVida(string Nombre);

}

public interface IComidas
{
    public string Desayuno();
    public string Almuerzo();
    public string Cena();
}

public class Estudiantes : Personas, IEstudiantes, ISeguros, IComidas

{
    public String? Carnet;
    
    public bool Matricula()
    {
        return true;
    }

    public decimal SeguroDeVida(string Nombre)
    {
        return 0.0m;
    }

    public string Desayuno()
    {
        return string "Huevo, arepa";
    }

    public string Almuerzo()
    {
        return string "Sopa, arroz y carne";
    }

    public string Cena()
    {
        return string "Salchipapa";
    }
}

