
using SysDente.Entities;
using SysDente.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SysDente.Services.Impl
{
    public class ExameService : ServiceBase<Exame>, IExameService
    {
        public ExameService(IExameRepository repository) : base(repository)
        {
        }
    }
}
            