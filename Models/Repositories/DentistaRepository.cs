using SysDente.Models;
using SysDente.Repositories;
using Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace SysDente.Repositories
{
    public class DentistaRepository : RepositoryBase<Dentista>, IDentistaRepository
    {
        public DentistaRepository(DataContext context, bool saveChanges = true) : base(context, saveChanges)
        {
        }
    }
}
