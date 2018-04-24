
using SysDente.Entities;
using SysDente.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SysDente.Controllers.Impl
{
    public class ExameController : ControllerBase<Exame>, IExameController
    {
        public ExameController(IExameService service) : base(service)
        {
        }
    }
}
            