namespace ActividadInstituto.Core;

public class Profesor : Persona
{
    private string? _especialidad;
    public string? Especialidad
    {
        get => _especialidad;
        set => _especialidad = value;
    }

    public Profesor(string especialidad, string nif, string nombre, string email)
    {
        Especialidad = especialidad;
        Nif = nif;
        Nombre = nombre;
        Email = email;
    }

    public override void Realizaractividad()
    {
        Console.WriteLine("Impartiendo lección...");
    }

    public override string? ObtenerFicha()
    {
        return $"Nombre: {Nombre} Especialidad {Especialidad} Email {Email} ";
    }
}