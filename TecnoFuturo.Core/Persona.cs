namespace TecnoFuturo.Core;

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
        init
        {
            if (value!.Contains('@'))
            {
                _email = value;
            }
            else
            {
                throw new Exception("Email debe contener @");
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