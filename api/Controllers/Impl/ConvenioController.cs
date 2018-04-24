
using SysDente.Entities;
using SysDente.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SysDente.Controllers.Impl
{
    public class ConvenioController : ControllerBase<Convenio>, IConvenioController
    {
        public ConvenioController(IServiceBase<Convenio> service) : base(service)
        {
        }
    }
}
            