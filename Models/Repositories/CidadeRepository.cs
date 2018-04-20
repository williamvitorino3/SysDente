using SysDente.Entities;
using SysDente.Repositories;
using SysDente.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SysDente.Repositories
{
    public class CidadeRepository : RepositoryBase<Cidade>, ICidadeRepository
    {
        public CidadeRepository(DataContext context, bool saveChanges = true) : base(context, saveChanges)
        {
        }
    }
}
