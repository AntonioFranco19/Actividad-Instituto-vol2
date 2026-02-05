namespace TecnoFuturo.Core;

public class CicloFormativo : IInfodetallada
{
    private readonly List<Modulo> _asignaturas = [];

    public CicloFormativo(string? nombre, string? idModulo, Turnos turno)
    {
        Nombre = nombre;
        IdModulo = idModulo;
        Turno = turno;
    }

    public string? IdModulo { get; }
    public string? Nombre { get; }
    public Turnos Turno { get; }

    public void AgregarModulo()
    {
        Modulo m = new Modulo(Utilidades.LeerCadena("ID de la asignatura....", true),
            Utilidades.LeerCadena("NOMBRE....", true), Utilidades.LeerInt("Número de horas a la semana...."));
        _asignaturas.Add(m);
        Console.WriteLine("Se ha añadido el módulo.");
    }

    public void VerDetalles()
    {
        
        Console.WriteLine($"Ciclo formativo: [{IdModulo}] {Nombre}");
        Console.WriteLine($"Turno: {Turno}");
        Console.WriteLine(new string('=', 101));
        Console.WriteLine("|                                         ASIGNATURAS                                               |");
        Console.WriteLine(new string('-', 101));
        if (_asignaturas.Count() == 0) Console.WriteLine($"| De momento no hay asiganturas.{new string(' ', 68)}|");
        else
        {
            foreach (Modulo modulo in _asignaturas)
            {
                Console.WriteLine(
                    $"| {modulo.Id,5} | {modulo.Nombre,-40} | {modulo.Horas,3} | {modulo.Profesor!.Nombre,-40} |");
            }
        }
        Console.WriteLine(new string('=', 101));
    }

    public override string ToString()
    {
        return $"| {this.Nombre, 20} | {IdModulo, 10} | {Turno, 20} |";
    }
    
    public override bool Equals(object? obj)
    {
        if (obj == null || this.GetType() != obj.GetType())
        {
            return false;
        }

        CicloFormativo otro = (CicloFormativo)obj;

        return this.IdModulo == otro.IdModulo;
    }

    public override int GetHashCode()
    {
        return IdModulo!.GetHashCode();
    }


    public string ObtenerFicha()
    {
        return $"Nombre: {Nombre} Id del modulo {IdModulo} Turno: {Turno} ";
    }
}