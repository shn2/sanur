
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
public partial class AdjuntoCAD : BasicCAD, IAdjuntoCAD
{
public AdjuntoCAD() : base ()
{
}

public AdjuntoCAD(ISession sessionAux) : base (sessionAux)
{
}



public AdjuntoEN ReadOIDDefault (int idAdjunto)
{
        AdjuntoEN adjuntoEN = null;

        try
        {
                SessionInitializeTransaction ();
                adjuntoEN = (AdjuntoEN)session.Get (typeof(AdjuntoEN), idAdjunto);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in AdjuntoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return adjuntoEN;
}
}
}
