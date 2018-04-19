dados = "IAgenda.cs  IConvenio.cs  IEmpresa.cs   IEstado.cs  IFornecedor.cs   IHistoricoPaciente.cs  IPacienteConvenio.cs ICidade.cs  IDentista.cs  IEndereco.cs  IExame.cs   IFuncionario.cs  IModelsproj.cs         IPaciente.cs".split()

def RemoveI(txt):
  return txt[1::]

for dado in dados:
    print("services.AddScoped<{0}, {1}>();".format(dado, RemoveI(dado)))