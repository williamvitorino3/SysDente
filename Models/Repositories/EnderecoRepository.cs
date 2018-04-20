using SysDente.Entities;
using SysDente.Repositories;
using SysDente.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SysDente.Repositories
{
    public class EnderecoRepository : RepositoryBase<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(DataContext context, bool saveChanges = true) : base(context, saveChanges)
        {
        }
    }
}
