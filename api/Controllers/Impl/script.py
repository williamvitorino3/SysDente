# Gera as Interfaces.

entities = "Agenda    Endereco     HistoricoPaciente Cidade    Estado Convenio  Exame        Paciente Dentista  Fornecedor   PacienteConvenio Empresa   Funcionario".split()

for entity in entities:
    with open("{}Controller.cs".format(entity), "w") as target:
        target.writelines(
            """
using SysDente.Entities;
using SysDente.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SysDente.Controllers.Impl
{
    public class """+entity+"""Controller : ControllerBase<"""+entity+""">, I"""+entity+"""Controller
    {
        public """+entity+"""Controller(IServiceBase<"""+entity+"""> service) : base(service)
        {
        }
    }
}
            """
        )