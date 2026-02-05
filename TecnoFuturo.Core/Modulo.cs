namespace TecnoFuturo.Core;

public class Modulo
{
    public string? Id { get; private set; }
    public string? Nombre { get; private set; }
    public int Horas { get; private set; }
    public Profesor? Profesor { get; private set; }

    public Modulo(string? id, string? nombre, int horas = 100)
    {
        Id = id;
        Nombre = nombre;
        Horas = horas;
    }

    public void AgregarProfesor(Profesor prof)
    {
        this.Profesor = prof;
    }
    public override string ToString()
    {
        return $"| ID: {Id} | Nombre: {Nombre} | Profesor: {Profesor!.Nombre} | Horas, {Horas} |";
    }
}