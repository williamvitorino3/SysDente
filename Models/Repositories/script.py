from os import system


dados = "IAgenda.cs  IConvenio.cs  IEmpresa.cs   IEstado.cs  IFornecedor.cs   IHistoricoPaciente.cs  IPacienteConvenio.cs ICidade.cs  IDentista.cs  IEndereco.cs  IExame.cs   IFuncionario.cs  IPaciente.cs".split()

def RemoveI(txt):
  return txt[1::]

# for dado in dados:
#     print("services.AddScoped<{0}, {1}>();".format(dado, RemoveI(dado)))

for dado in dados:
    # print("mv {0} {1}".format(dado, dado.split(".")[0]+"Repository.cs"));
    system("mv {0} {1}".format(dado, dado.split(".")[0]+"Repository.cs"));
