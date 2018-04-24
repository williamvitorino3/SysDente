
using SysDente.Entities;
using SysDente.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SysDente.Services.Impl
{
    public class ExameService : ServiceBase<Exame>, IExameService
    {
        protected ExameService(IRepositoryBase<Exame> repository) : base(repository)
        {
        }
    }
}
            