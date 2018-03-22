# SysDente
Sistema para consultórios dentários.

## Listagem das Entidades do Sistema

|Paciente|
| --- |
| Id |
| Dentista |
| Nome |
| Telefone |
| Endereco |
| Email |
| Data_Nascimento |

| Convenio |
| --- |
| Id |
| Nome |
| Endereco |
| Email |
| Telefone |

| Paciente_Com_Convenio |
| --- |
| Id |
| Historico_Paciente |
| Convenio |
| Nome |
| Endereco |
| Telefone |
| Email |

| Agenda |
| --- |
| Ano |
| Mes |
| Dia |
| Hora |

| Estado |
| --- |
| Id |
| Nome |
| Uf |

| Cidade |
| --- |
| Id |
| Estado |
| Nome |

| Endereco |
| --- |
| Id |
| Cidade |
| Estado |
| Rua |
| Numero |

| Dentista |
| --- |
| Id |
| Convenio |
| Agenda |
| Nome |
| Endereco |
| Email |
| Telefone |
| Especialidade |
| Remuneracao |
| Cpf |

| Exame |
| --- |
| Id |
| Dentista |
| Tipo |
| Descricao |

| Fornecedor |
| --- |
| Id |
| Dentista |
| Nome_Empresa |
| Cnpj |
| Endereco |
| Telefone |
| Email |

| Funcionario |
| --- |
| Id |
| Dentista |
| Nome |
| Data_Nascimento |
| Telefone |
| Email |
| Endereco |
| Remuneracao |
| Especialidade |
| Cpf |

| Historico_Paciente |
| --- |
| Id |
| Paciente |
| Servicos |
| Pagamentos |
| Geral |