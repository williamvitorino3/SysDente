
using SysDente.Entities;
using SysDente.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SysDente.Services.Impl
{
    public class PacienteService : ServiceBase<Paciente>, IPacienteService
    {
        protected PacienteService(IRepositoryBase<Paciente> repository) : base(repository)
        {
        }
    }
}
            