

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using SanurGenNHibernate.EN.Sanur;
using SanurGenNHibernate.CAD.Sanur;

namespace SanurGenNHibernate.CEN.Sanur
{
public partial class AdjuntoCEN
{
private IAdjuntoCAD _IAdjuntoCAD;

public AdjuntoCEN()
{
        this._IAdjuntoCAD = new AdjuntoCAD ();
}

public AdjuntoCEN(IAdjuntoCAD _IAdjuntoCAD)
{
        this._IAdjuntoCAD = _IAdjuntoCAD;
}

public IAdjuntoCAD get_IAdjuntoCAD ()
{
        return this._IAdjuntoCAD;
}
}
}
