
using System;
using SanurGenNHibernate.EN.Sanur;

namespace SanurGenNHibernate.CAD.Sanur
{
public partial interface IEpisodioCAD
{
EpisodioEN ReadOIDDefault (int idEpisodio);

int New_ (EpisodioEN episodio);

void Modify (EpisodioEN episodio);


EpisodioEN ReadOID (int idEpisodio);


System.Collections.Generic.IList<EpisodioEN> ReadAll (int first, int size);
}
}
