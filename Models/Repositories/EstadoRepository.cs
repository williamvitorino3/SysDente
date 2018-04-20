using SysDente.Entities;
using SysDente.Repositories;
using SysDente.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SysDente.Repositories
{
    public class EstadoRepository : RepositoryBase<Estado>, IEstadoRepository
    {
        public EstadoRepository(DataContext context, bool saveChanges = true) : base(context, saveChanges)
        {
        }
    }
}
