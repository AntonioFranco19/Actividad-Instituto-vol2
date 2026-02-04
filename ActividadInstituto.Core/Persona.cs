namespace ActividadInstituto.Core;

public abstract class Persona : IInfodetallada
{
    public string? Nif
    {
        get;
        init;
    }

    private string? _nombre;
    public string? Nombre
    {
        get => _nombre;
        set
        {
            _nombre = value;
        }
    }

    private string? _email;

    public string? Email
    {
        get => _email;
        set
        {
            if (value!.Contains('@'))
            {
                _email = value;
            }
        }
    }

    public virtual void Realizaractividad()
    {
        
    }

    public virtual string? ObtenerFicha()
    {
        return null;
    }
}