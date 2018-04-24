
using SysDente.Entities;
using SysDente.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SysDente.Services.Impl
{
    public class AgendaService : ServiceBase<Agenda>, IAgendaService
    {
        public AgendaService(IAgendaRepository repository) : base(repository)
        {
        }
    }
}
            