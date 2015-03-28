
using System;
using SanurGenNHibernate.EN.Sanur;

namespace SanurGenNHibernate.CAD.Sanur
{
public partial interface ITriajeCAD
{
TriajeEN ReadOIDDefault (int idTriaje);

int New_ (TriajeEN triaje);

void Modify (TriajeEN triaje);


TriajeEN ReadOID (int idTriaje);


System.Collections.Generic.IList<TriajeEN> ReadAll (int first, int size);
}
}
