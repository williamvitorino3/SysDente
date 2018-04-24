
using SysDente.Entities;
using SysDente.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SysDente.Controllers.Impl
{
    public class FornecedorController : ControllerBase<Fornecedor>, IFornecedorController
    {
        public FornecedorController(IFornecedorService service) : base(service)
        {
        }
    }
}
            