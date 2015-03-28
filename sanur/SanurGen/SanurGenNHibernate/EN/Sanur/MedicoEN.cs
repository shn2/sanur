
using System;

namespace SanurGenNHibernate.EN.Sanur
{
public partial class MedicoEN                   :                           SanurGenNHibernate.EN.Sanur.UsuarioEN


{
/**
 *
 */

private System.Collections.Generic.IList<SanurGenNHibernate.EN.Sanur.TriajeEN> triaje;

/**
 *
 */

private SanurGenNHibernate.Enumerated.Sanur.EspecialidadEnum especialidad;

/**
 *
 */

private System.Collections.Generic.IList<SanurGenNHibernate.EN.Sanur.DiagnosticoEN> diagnostico;





public virtual System.Collections.Generic.IList<SanurGenNHibernate.EN.Sanur.TriajeEN> Triaje {
        get { return triaje; } set { triaje = value;  }
}


public virtual SanurGenNHibernate.Enumerated.Sanur.EspecialidadEnum Especialidad {
        get { return especialidad; } set { especialidad = value;  }
}


public virtual System.Collections.Generic.IList<SanurGenNHibernate.EN.Sanur.DiagnosticoEN> Diagnostico {
        get { return diagnostico; } set { diagnostico = value;  }
}





public MedicoEN() : base ()
{
        triaje = new System.Collections.Generic.List<SanurGenNHibernate.EN.Sanur.TriajeEN>();
        diagnostico = new System.Collections.Generic.List<SanurGenNHibernate.EN.Sanur.DiagnosticoEN>();
}



public MedicoEN(int idUsuario, System.Collections.Generic.IList<SanurGenNHibernate.EN.Sanur.TriajeEN> triaje, SanurGenNHibernate.Enumerated.Sanur.EspecialidadEnum especialidad, System.Collections.Generic.IList<SanurGenNHibernate.EN.Sanur.DiagnosticoEN> diagnostico, string nombre, String contrasena, bool iniciado, string email, string apellidos)
{
        this.init (idUsuario, triaje, especialidad, diagnostico, nombre, contrasena, iniciado, email, apellidos);
}


public MedicoEN(MedicoEN medico)
{
        this.init (medico.IdUsuario, medico.Triaje, medico.Especialidad, medico.Diagnostico, medico.Nombre, medico.Contrasena, medico.Iniciado, medico.Email, medico.Apellidos);
}

private void init (int idUsuario, System.Collections.Generic.IList<SanurGenNHibernate.EN.Sanur.TriajeEN> triaje, SanurGenNHibernate.Enumerated.Sanur.EspecialidadEnum especialidad, System.Collections.Generic.IList<SanurGenNHibernate.EN.Sanur.DiagnosticoEN> diagnostico, string nombre, String contrasena, bool iniciado, string email, string apellidos)
{
        this.IdUsuario = idUsuario;


        this.Triaje = triaje;

        this.Especialidad = especialidad;

        this.Diagnostico = diagnostico;

        this.Nombre = nombre;

        this.Contrasena = contrasena;

        this.Iniciado = iniciado;

        this.Email = email;

        this.Apellidos = apellidos;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        MedicoEN t = obj as MedicoEN;
        if (t == null)
                return false;
        if (IdUsuario.Equals (t.IdUsuario))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.IdUsuario.GetHashCode ();
        return hash;
}
}
}
