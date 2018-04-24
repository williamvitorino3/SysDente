# Gera as Interfaces.

entities = "Agenda    Endereco     HistoricoPaciente Cidade    Estado Convenio  Exame        Paciente Dentista  Fornecedor   PacienteConvenio Empresa   Funcionario".split()

for entity in entities:
    with open("I{}Controller.cs".format(entity), "w") as target:
        target.writelines(
            """
using Domain.Entities;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers.Impl
{
    public class AutorController : ControllerBase<Autor>, IAutorController
    {
        public AutorController(IServiceBase<Autor> service) : base(service)
        {
        }
    }
}
            """
        )