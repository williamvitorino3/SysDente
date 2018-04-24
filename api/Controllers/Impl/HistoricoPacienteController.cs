
using SysDente.Entities;
using SysDente.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SysDente.Controllers.Impl
{
    public class HistoricoPacienteController : ControllerBase<HistoricoPaciente>, IHistoricoPacienteController
    {
        public HistoricoPacienteController(IServiceBase<HistoricoPaciente> service) : base(service)
        {
        }
    }
}
            