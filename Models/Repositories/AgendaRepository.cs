using SysDente.Entities;
using SysDente.Repositories;
using SysDente.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SysDente.Repositories
{
    public class AgendaRepository : RepositoryBase<Agenda>, IAgendaRepository
    {
        public AgendaRepository(DataContext context, bool saveChanges = true) : base(context, saveChanges)
        {
        }
    }
}
