
using System;

namespace SanurGenNHibernate.EN.Sanur
{
public partial class AdministrativoEN                   :                           SanurGenNHibernate.EN.Sanur.UsuarioEN


{
/**
 *
 */

private System.Collections.Generic.IList<SanurGenNHibernate.EN.Sanur.EpisodioEN> episodio;





public virtual System.Collections.Generic.IList<SanurGenNHibernate.EN.Sanur.EpisodioEN> Episodio {
        get { return episodio; } set { episodio = value;  }
}





public AdministrativoEN() : base ()
{
        episodio = new System.Collections.Generic.List<SanurGenNHibernate.EN.Sanur.EpisodioEN>();
}



public AdministrativoEN(int idUsuario, System.Collections.Generic.IList<SanurGenNHibernate.EN.Sanur.EpisodioEN> episodio, string nombre, String contrasena, bool iniciado, string email, string apellidos)
{
        this.init (idUsuario, episodio, nombre, contrasena, iniciado, email, apellidos);
}


public AdministrativoEN(AdministrativoEN administrativo)
{
        this.init (administrativo.IdUsuario, administrativo.Episodio, administrativo.Nombre, administrativo.Contrasena, administrativo.Iniciado, administrativo.Email, administrativo.Apellidos);
}

private void init (int idUsuario, System.Collections.Generic.IList<SanurGenNHibernate.EN.Sanur.EpisodioEN> episodio, string nombre, String contrasena, bool iniciado, string email, string apellidos)
{
        this.IdUsuario = idUsuario;


        this.Episodio = episodio;

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
        AdministrativoEN t = obj as AdministrativoEN;
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
