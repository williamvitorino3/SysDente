
using SysDente.Entities;
using SysDente.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SysDente.Controllers.Impl
{
    public class EmpresaController : ControllerBase<Empresa>, IEmpresaController
    {
        public EmpresaController(IEmpresaService service) : base(service)
        {
        }
    }
}
            