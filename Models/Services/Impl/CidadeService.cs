
using SysDente.Entities;
using SysDente.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SysDente.Services.Impl
{
    public class CidadeService : ServiceBase<Cidade>, ICidadeService
    {
        public CidadeService(ICidadeRepository repository) : base(repository)
        {
        }
    }
}
            