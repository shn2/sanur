
using System;

namespace SanurGenNHibernate.EN.Sanur
{
public partial class PacienteEN
{
/**
 *
 */

private string nombre;

/**
 *
 */

private string apellido;

/**
 *
 */

private Nullable<DateTime> fNac;

/**
 *
 */

private string tlf;

/**
 *
 */

private string direccion;

/**
 *
 */

private string nacionalidad;

/**
 *
 */

private int sip;

/**
 *
 */

private int idPaciente;

/**
 *
 */

private int dni;

/**
 *
 */

private string sexo;

/**
 *
 */

private string email;

/**
 *
 */

private string municipio;

/**
 *
 */

private string grupoSang;

/**
 *
 */

private string codigoPostal;

/**
 *
 */

private string iPS;





public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}


public virtual string Apellido {
        get { return apellido; } set { apellido = value;  }
}


public virtual Nullable<DateTime> FNac {
        get { return fNac; } set { fNac = value;  }
}


public virtual string Tlf {
        get { return tlf; } set { tlf = value;  }
}


public virtual string Direccion {
        get { return direccion; } set { direccion = value;  }
}


public virtual string Nacionalidad {
        get { return nacionalidad; } set { nacionalidad = value;  }
}


public virtual int Sip {
        get { return sip; } set { sip = value;  }
}


public virtual int IdPaciente {
        get { return idPaciente; } set { idPaciente = value;  }
}


public virtual int Dni {
        get { return dni; } set { dni = value;  }
}


public virtual string Sexo {
        get { return sexo; } set { sexo = value;  }
}


public virtual string Email {
        get { return email; } set { email = value;  }
}


public virtual string Municipio {
        get { return municipio; } set { municipio = value;  }
}


public virtual string GrupoSang {
        get { return grupoSang; } set { grupoSang = value;  }
}


public virtual string CodigoPostal {
        get { return codigoPostal; } set { codigoPostal = value;  }
}


public virtual string IPS {
        get { return iPS; } set { iPS = value;  }
}





public PacienteEN()
{
}



public PacienteEN(int idPaciente, string nombre, string apellido, Nullable<DateTime> fNac, string tlf, string direccion, string nacionalidad, int sip, int dni, string sexo, string email, string municipio, string grupoSang, string codigoPostal, string iPS)
{
        this.init (idPaciente, nombre, apellido, fNac, tlf, direccion, nacionalidad, sip, dni, sexo, email, municipio, grupoSang, codigoPostal, iPS);
}


public PacienteEN(PacienteEN paciente)
{
        this.init (paciente.IdPaciente, paciente.Nombre, paciente.Apellido, paciente.FNac, paciente.Tlf, paciente.Direccion, paciente.Nacionalidad, paciente.Sip, paciente.Dni, paciente.Sexo, paciente.Email, paciente.Municipio, paciente.GrupoSang, paciente.CodigoPostal, paciente.IPS);
}

private void init (int idPaciente, string nombre, string apellido, Nullable<DateTime> fNac, string tlf, string direccion, string nacionalidad, int sip, int dni, string sexo, string email, string municipio, string grupoSang, string codigoPostal, string iPS)
{
        this.IdPaciente = idPaciente;


        this.Nombre = nombre;

        this.Apellido = apellido;

        this.FNac = fNac;

        this.Tlf = tlf;

        this.Direccion = direccion;

        this.Nacionalidad = nacionalidad;

        this.Sip = sip;

        this.Dni = dni;

        this.Sexo = sexo;

        this.Email = email;

        this.Municipio = municipio;

        this.GrupoSang = grupoSang;

        this.CodigoPostal = codigoPostal;

        this.IPS = iPS;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PacienteEN t = obj as PacienteEN;
        if (t == null)
                return false;
        if (IdPaciente.Equals (t.IdPaciente))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.IdPaciente.GetHashCode ();
        return hash;
}
}
}
