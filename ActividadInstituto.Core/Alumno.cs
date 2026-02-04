namespace ActividadInstituto.Core;

public class Alumno : Persona
{
    private string _telefono;

    public string? Telefono
    {
        get => _telefono;
        private set => _telefono = value ?? throw new ArgumentNullException(nameof(value));
    }

    private string _direccion;

    public string? Direccion
    {
        get => _direccion;
        private set => _direccion = value ?? throw new ArgumentNullException(nameof(value));
    }

    private string _expediente;

    public string Expediente
    {
        get => _expediente;
        set => _expediente = value ?? throw new ArgumentNullException(nameof(value));
    }

    public CicloFormativo CicloMatriculado { get; private set; }

    public Alumno(string? nif, string? nombre, string? telefono, string? direccion, string? email, CicloFormativo ciclo)
    {
        Nif = nif;
        Nombre = nombre;
        Telefono = telefono;
        Direccion = direccion;
        Email = email;
        CicloMatriculado = ciclo;
    }
    
    public override string ToString()
    {
        return $" Nombre: {this.Nombre} NIF: {Nif}, Telefono {Telefono}, Dirección: {Direccion}, Email: {Email}, Ciclo Matriculado: {CicloMatriculado.Nombre}.";
    }

    public override string? ObtenerFicha()
    {
        return $"Nombre: {Nombre} Direccion {Direccion} Ciclo Matriculado {CicloMatriculado}";
    }
}