
using SysDente.Entities;
using SysDente.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SysDente.Services.Impl
{
    public class HistoricoPacienteService : ServiceBase<HistoricoPaciente>, IHistoricoPacienteService
    {
        protected HistoricoPacienteService(IRepositoryBase<HistoricoPaciente> repository) : base(repository)
        {
        }
    }
}
            