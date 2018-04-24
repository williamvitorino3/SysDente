
using SysDente.Entities;
using SysDente.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SysDente.Services.Impl
{
    public class HistoricoPacienteService : ServiceBase<HistoricoPaciente>, IHistoricoPacienteService
    {
        public HistoricoPacienteService(IHistoricoPacienteRepository repository) : base(repository)
        {
        }
    }
}
            