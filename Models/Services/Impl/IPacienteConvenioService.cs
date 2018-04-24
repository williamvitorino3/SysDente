
using SysDente.Entities;
using SysDente.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SysDente.Services.Impl
{
    public class PacienteConvenioService : ServiceBase<PacienteConvenio>, IPacienteConvenioService
    {
        protected PacienteConvenioService(IRepositoryBase<PacienteConvenio> repository) : base(repository)
        {
        }
    }
}
            