using SysDente.Entities;
using SysDente.Repositories;
using SysDente.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SysDente.Repositories
{
    public class PacienteConvenioRepository : RepositoryBase<PacienteConvenio>, IPacienteConvenioRepository
    {
        public PacienteConvenioRepository(DataContext context, bool saveChanges = true) : base(context, saveChanges)
        {
        }
    }
}
