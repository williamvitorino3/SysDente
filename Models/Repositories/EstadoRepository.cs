using SysDente.Models;
using SysDente.Repositories;
using Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace SysDente.Repositories
{
    public class AutorRepository : RepositoryBase<Autor>, IAutorRepository
    {
        public AutorRepository(DataContext context, bool saveChanges = true) : base(context, saveChanges)
        {
        }
    }
}
