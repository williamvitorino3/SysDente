
using SysDente.Entities;
using SysDente.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SysDente.Services.Impl
{
    public class EstadoService : ServiceBase<Estado>, IEstadoService
    {
        protected EstadoService(IRepositoryBase<Estado> repository) : base(repository)
        {
        }
    }
}
            