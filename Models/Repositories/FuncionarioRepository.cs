using SysDente.Entities;
using SysDente.Repositories;
using SysDente.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SysDente.Repositories
{
    public class FuncionarioRepository : RepositoryBase<Funcionario>, IFuncionarioRepository
    {
        public FuncionarioRepository(DataContext context, bool saveChanges = true) : base(context, saveChanges)
        {
        }
    }
}
