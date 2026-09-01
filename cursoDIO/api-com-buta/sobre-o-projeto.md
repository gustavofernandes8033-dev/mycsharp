## Requisições Http

uma webapi trabalha com requisições http.

## Controllers

um controller é uma classe que agrupa suas requisições http e disponibiliza endpoints.
usuarioController vai lidar apenas com requisições de usuario.

## Entity Framework

a ferramenta Entity Framework associa um Classes C# á  tabelas SQL no banco de dados 

Ex. tabela Contato e Classe Contato

Quando salvar uma nova instancia de objeto Contato o Entity Framework traduz esses dados para comandos SQL. 

Entity Framework gera queries de forma dinamica no banco de dados, faz insert into, update, select, delete e create table. 

## Instalando o Entity Framework

```bash
dotnet add package Microsoft.EntityFrameworkCore.Design
```

```bash
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```

## No projeto temos o 'Contexto'

No projeto fazemos a conexão com o banco de dados da seguinte forma: Criamos a classe AgendaContext.cs, que herda da classe DbContext. O construtor da classe AgendaContext.cs passa uma configuração de conexão para a classe pai através de um construtor. Além dessa configuração de conexão  há tambem o DbSet<Contato> que puxa as informações da classe 'Contato.cs' para que seja passado para o banco. 

## Migrations

Todas as classes que aparecerem no arquivo Context e estiverem em um DbSet<> irão se tornar "entidades", isso é, existem como classes no C# e existem como tabelas no Banco de Dados.

## Verbos HTTP

POST -- Create - Criar/registrar informações     

GET -- Read - Retorno de uma informação

PUT -- Update - Atualizar/modificar informações que já estão no banco

PATCH -- Update/Modify - Atualizar/modificar informações que já estão no banco

DELETE -- Delete - Deletar informações

## Respostas HTTP

404 - not found

200 - OK

409 - Conflict - Aparece em casos onde uma informação precisa ser unica, exemplo, um um email só pode ser associado a um unico cliente. se tentarmos usar um email em mais de um cliente é retornado o 409 - conflict

204 - No Content - Sem nenhuma informação a retornar.
