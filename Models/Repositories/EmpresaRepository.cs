using SysDente.Entities;
using SysDente.Repositories;
using SysDente.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SysDente.Repositories
{
    public class EmpresaRepository : RepositoryBase<Empresa>, IEmpresaRepository
    {
        public EmpresaRepository(DataContext context, bool saveChanges = true) : base(context, saveChanges)
        {
        }
    }
}
