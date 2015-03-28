
using System;
using System.Text;
using SanurGenNHibernate.CEN.Sanur;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using SanurGenNHibernate.EN.Sanur;
using SanurGenNHibernate.Exceptions;

namespace SanurGenNHibernate.CAD.Sanur
{
public partial class EpisodioCAD : BasicCAD, IEpisodioCAD
{
public EpisodioCAD() : base ()
{
}

public EpisodioCAD(ISession sessionAux) : base (sessionAux)
{
}



public EpisodioEN ReadOIDDefault (int idEpisodio)
{
        EpisodioEN episodioEN = null;

        try
        {
                SessionInitializeTransaction ();
                episodioEN = (EpisodioEN)session.Get (typeof(EpisodioEN), idEpisodio);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in EpisodioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return episodioEN;
}


public int New_ (EpisodioEN episodio)
{
        try
        {
                SessionInitializeTransaction ();
                if (episodio.Paciente != null) {
                        episodio.Paciente = (SanurGenNHibernate.EN.Sanur.PacienteEN)session.Load (typeof(SanurGenNHibernate.EN.Sanur.PacienteEN), episodio.Paciente.IdPaciente);

                        episodio.Paciente.Episodio.Add (episodio);
                }
                if (episodio.Administrativo != null) {
                        episodio.Administrativo = (SanurGenNHibernate.EN.Sanur.AdministrativoEN)session.Load (typeof(SanurGenNHibernate.EN.Sanur.AdministrativoEN), episodio.Administrativo.IdUsuario);

                        episodio.Administrativo.Episodio.Add (episodio);
                }

                session.Save (episodio);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in EpisodioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return episodio.IdEpisodio;
}

public void Modify (EpisodioEN episodio)
{
        try
        {
                SessionInitializeTransaction ();
                EpisodioEN episodioEN = (EpisodioEN)session.Load (typeof(EpisodioEN), episodio.IdEpisodio);

                episodioEN.FechaInicio = episodio.FechaInicio;


                episodioEN.Observaciones = episodio.Observaciones;


                episodioEN.FechaFin = episodio.FechaFin;


                episodioEN.Estado = episodio.Estado;


                episodioEN.Emergencia = episodio.Emergencia;


                episodioEN.Imporante = episodio.Imporante;

                session.Update (episodioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in EpisodioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public EpisodioEN ReadOID (int idEpisodio)
{
        EpisodioEN episodioEN = null;

        try
        {
                SessionInitializeTransaction ();
                episodioEN = (EpisodioEN)session.Get (typeof(EpisodioEN), idEpisodio);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in EpisodioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return episodioEN;
}

public System.Collections.Generic.IList<EpisodioEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<EpisodioEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(EpisodioEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<EpisodioEN>();
                else
                        result = session.CreateCriteria (typeof(EpisodioEN)).List<EpisodioEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in EpisodioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
