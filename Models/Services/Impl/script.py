entities = "Agenda    Endereco     HistoricoPaciente Cidade    Estado Convenio  Exame        Paciente Dentista  Fornecedor   PacienteConvenio Empresa   Funcionario".split()

for entity in entities:
    with open("I{}Service.cs".format(entity), "w") as target:
        target.writelines(
            """
using SysDente.Entities;
using SysDente.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SysDente.Services.Impl
{
    public class """+entity+"""Service : ServiceBase<"""+entity+""">, I"""+entity+"""Service
    {
        protected """+entity+"""Service(IRepositoryBase<"""+entity+"""> repository) : base(repository)
        {
        }
    }
}
            """
        )