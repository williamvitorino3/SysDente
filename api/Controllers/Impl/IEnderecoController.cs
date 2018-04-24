
using SysDente.Entities;
using SysDente.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SysDente.Controllers.Impl
{
    public class EnderecoController : ControllerBase<Endereco>, IEnderecoController
    {
        public EnderecoController(IServiceBase<Endereco> service) : base(service)
        {
        }
    }
}
            