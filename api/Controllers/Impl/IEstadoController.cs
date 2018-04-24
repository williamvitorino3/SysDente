
using SysDente.Entities;
using SysDente.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SysDente.Controllers.Impl
{
    public class EstadoController : ControllerBase<Estado>, IEstadoController
    {
        public EstadoController(IServiceBase<Estado> service) : base(service)
        {
        }
    }
}
            