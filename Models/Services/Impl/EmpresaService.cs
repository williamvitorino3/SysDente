
using SysDente.Entities;
using SysDente.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SysDente.Services.Impl
{
    public class EmpresaService : ServiceBase<Empresa>, IEmpresaService
    {
        public EmpresaService(IEmpresaRepository repository) : base(repository)
        {
        }
    }
}
            