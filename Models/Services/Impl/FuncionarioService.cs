
using SysDente.Entities;
using SysDente.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SysDente.Services.Impl
{
    public class FuncionarioService : ServiceBase<Funcionario>, IFuncionarioService
    {
        public FuncionarioService(IFuncionarioRepository repository) : base(repository)
        {
        }
    }
}
            