using SysDente.Models;
using SysDente.Repositories;
using Infra.Data.Context;
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
