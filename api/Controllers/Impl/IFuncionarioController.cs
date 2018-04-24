
using SysDente.Entities;
using SysDente.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SysDente.Controllers.Impl
{
    public class FuncionarioController : ControllerBase<Funcionario>, IFuncionarioController
    {
        public FuncionarioController(IServiceBase<Funcionario> service) : base(service)
        {
        }
    }
}
            