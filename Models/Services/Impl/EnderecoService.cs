
using SysDente.Entities;
using SysDente.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SysDente.Services.Impl
{
    public class EnderecoService : ServiceBase<Endereco>, IEnderecoService
    {
        public EnderecoService(IEnderecoRepository repository) : base(repository)
        {
        }
    }
}
            