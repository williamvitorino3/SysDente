
using SysDente.Entities;
using SysDente.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SysDente.Services.Impl
{
    public class ConvenioService : ServiceBase<Convenio>, IConvenioService
    {
        protected ConvenioService(IRepositoryBase<Convenio> repository) : base(repository)
        {
        }
    }
}
            