using SysDente.Entities;
using SysDente.Repositories;
using SysDente.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SysDente.Repositories
{
    public class HistoricoPacienteRepository : RepositoryBase<HistoricoPaciente>, IHistoricoPacienteRepository
    {
        public HistoricoPacienteRepository(DataContext context, bool saveChanges = true) : base(context, saveChanges)
        {
        }
    }
}
