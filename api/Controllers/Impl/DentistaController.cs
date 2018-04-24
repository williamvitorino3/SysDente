
using SysDente.Entities;
using SysDente.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SysDente.Controllers.Impl
{
    public class DentistaController : ControllerBase<Dentista>, IDentistaController
    {
        public DentistaController(IDentistaService service) : base(service)
        {
        }
    }
}
            