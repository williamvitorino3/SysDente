
using SysDente.Entities;
using SysDente.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SysDente.Services.Impl
{
    public class DentistaService : ServiceBase<Dentista>, IDentistaService
    {
        public DentistaService(IDentistaRepository repository) : base(repository)
        {
        }
    }
}
            