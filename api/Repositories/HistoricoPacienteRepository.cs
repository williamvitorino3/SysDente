using Domain.Models;
using Domain.Repositories;
using Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Data.Repositories
{
    public class HistoricoPacienteRepository : RepositoryBase<HistoricoPaciente>, IHistoricoPacienteRepository
    {
        public HistoricoPacienteRepository(DataContext context, bool saveChanges = true) : base(context, saveChanges)
        {
        }
    }
}