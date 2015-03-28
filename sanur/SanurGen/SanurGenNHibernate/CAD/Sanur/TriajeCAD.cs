
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
public partial class TriajeCAD : BasicCAD, ITriajeCAD
{
public TriajeCAD() : base ()
{
}

public TriajeCAD(ISession sessionAux) : base (sessionAux)
{
}



public TriajeEN ReadOIDDefault (int idTriaje)
{
        TriajeEN triajeEN = null;

        try
        {
                SessionInitializeTransaction ();
                triajeEN = (TriajeEN)session.Get (typeof(TriajeEN), idTriaje);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in TriajeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return triajeEN;
}


public int New_ (TriajeEN triaje)
{
        try
        {
                SessionInitializeTransaction ();
                if (triaje.Medico != null) {
                        triaje.Medico = (SanurGenNHibernate.EN.Sanur.MedicoEN)session.Load (typeof(SanurGenNHibernate.EN.Sanur.MedicoEN), triaje.Medico.IdUsuario);

                        triaje.Medico.Triaje.Add (triaje);
                }
                if (triaje.Episodio != null) {
                        triaje.Episodio = (SanurGenNHibernate.EN.Sanur.EpisodioEN)session.Load (typeof(SanurGenNHibernate.EN.Sanur.EpisodioEN), triaje.Episodio.IdEpisodio);

                        triaje.Episodio.Triaje = triaje;
                }

                session.Save (triaje);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in TriajeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return triaje.IdTriaje;
}

public void Modify (TriajeEN triaje)
{
        try
        {
                SessionInitializeTransaction ();
                TriajeEN triajeEN = (TriajeEN)session.Load (typeof(TriajeEN), triaje.IdTriaje);

                triajeEN.Prioridad = triaje.Prioridad;


                triajeEN.Movilidad = triaje.Movilidad;


                triajeEN.MotivoAsist = triaje.MotivoAsist;


                triajeEN.Destino = triaje.Destino;


                triajeEN.Observaciones = triaje.Observaciones;

                session.Update (triajeEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in TriajeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public TriajeEN ReadOID (int idTriaje)
{
        TriajeEN triajeEN = null;

        try
        {
                SessionInitializeTransaction ();
                triajeEN = (TriajeEN)session.Get (typeof(TriajeEN), idTriaje);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in TriajeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return triajeEN;
}

public System.Collections.Generic.IList<TriajeEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<TriajeEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(TriajeEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<TriajeEN>();
                else
                        result = session.CreateCriteria (typeof(TriajeEN)).List<TriajeEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in TriajeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
