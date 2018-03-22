# SysDente
Sistema para consultórios dentários.

## Listagem das Entidades do Sistema Proposto

### Paciente

* Id
* Dentista
* Cidade
* Nome
* Telefone
* Endereco
* Email
* Data_Nascimento

### Convenio

* Id
* Nome
* Endereco
* Email
* Telefone

### Paciente_Com_Convenio

* Id
* Historico_Paciente
* Convenio
* Cidade
* Nome
* Endereco
* Telefone
* Email

### Agenda

* Ano
* Mes
* Dia
* Hora

### Estado

* Id
* Nome
* Uf

### Cidade

* Id
* Estado
* Nome

### Dentista

* Id
* Convenio
* Agenda
* Nome
* Endereco
* Email
* Telefone
* Especialidade
* Remuneracao
* Cpf

### Exame

* Id
* Dentista
* Tipo
* Descricao

### Fornecedor

* Id
* Dentista
* Cidade
* Nome_Empresa
* Cnpj
* Endereco
* Telefone
* Email

### Funcionario

* Id
* Dentista
* Cidade
* Nome
* Data_Nascimento
* Telefone
* Email
* Endereco
* Remuneracao
* Especialidade
* Cpf

### Historico_Paciente

* Id
* Paciente
* Servicos
* Pagamentos
* Geral