namespace TecnoFuturo.Core;

public class Alumno : Persona
{
    private string? _telefono;

    public string? Telefono
    {
        get => _telefono;
        private set => _telefono = value;
    }

    private string? _direccion;

    public string? Direccion
    {
        get => _direccion;
        private set => _direccion = value;
    }
    private string? _expediente;

    public string? Expediente
    {
        get => _expediente;
        set => _expediente = value;
    }

    public CicloFormativo CicloMatriculado { get; private set; }

    public Alumno(string? nif, string? nombre, string? telefono, string? direccion, string? email, string? expediente, CicloFormativo ciclo)
    {
        Nif = nif;
        Nombre = nombre;
        Telefono = telefono;
        Direccion = direccion;
        Email = email;
        CicloMatriculado = ciclo;
        Expediente = expediente;
    }
    
    public override string ToString()
    {
        return $" Nombre: {this.Nombre} NIF: {Nif}, Telefono {Telefono}, Dirección: {Direccion}, Email: {Email}, Ciclo Matriculado: {CicloMatriculado.Nombre}.";
    }

    public override string ObtenerFicha()
    {
        return $"Nombre: {Nombre} Direccion: {Direccion} Email. {Email} Ciclo Matriculado: {CicloMatriculado.Nombre}";
    }
}