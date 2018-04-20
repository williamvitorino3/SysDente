using SysDente.Models;
using SysDente.Repositories;
using Infra.Data.Context;
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
