using SysDente.Entities;
using SysDente.Repositories;
using SysDente.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SysDente.Repositories
{
    public class ConvenioRepository : RepositoryBase<Convenio>, IConvenioRepository
    {
        public ConvenioRepository(DataContext context, bool saveChanges = true) : base(context, saveChanges)
        {
        }
    }
}
