
using SysDente.Entities;
using SysDente.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SysDente.Controllers.Impl
{
    public class CidadeController : ControllerBase<Cidade>, ICidadeController
    {
        public CidadeController(IServiceBase<Cidade> service) : base(service)
        {
        }
    }
}
            