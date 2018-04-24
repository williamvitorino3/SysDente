
using SysDente.Entities;
using SysDente.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SysDente.Services.Impl
{
    public class FornecedorService : ServiceBase<Fornecedor>, IFornecedorService
    {
        protected FornecedorService(IRepositoryBase<Fornecedor> repository) : base(repository)
        {
        }
    }
}
            