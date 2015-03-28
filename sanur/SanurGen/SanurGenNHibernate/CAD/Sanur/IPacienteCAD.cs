
using System;
using SanurGenNHibernate.EN.Sanur;

namespace SanurGenNHibernate.CAD.Sanur
{
public partial interface IPacienteCAD
{
PacienteEN ReadOIDDefault (int idPaciente);

int New_ (PacienteEN paciente);

void Modify (PacienteEN paciente);


void Destroy (int idPaciente);


PacienteEN ReadOID (int idPaciente);


System.Collections.Generic.IList<PacienteEN> ReadAll (int first, int size);
}
}
