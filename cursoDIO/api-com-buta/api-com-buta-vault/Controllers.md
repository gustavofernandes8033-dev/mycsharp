No contexto de webApis integrado a um banco de dados, temos a pasta Controllers e dentro da pasta classes nomeadas como "NomeDaClasseControllers.cs". Nessa classe com final "Controller" irá agrupar todas as funções de ações da API, como atualizar, deletar, obter dados.


em termos mais técnicos: um controller no ASPNET é uma camada da aplicação responsável por receber requisições http e coordenar o que acontece com elas. 
- **Recebe** a requisição e extrai os dados dela (parâmetros, corpo, headers)
- **Chama** a lógica necessária — geralmente acessando o banco via um serviço ou diretamente pelo `DbContext` do Entity Framework
- **Retorna** uma resposta HTTP com os dados e o status code apropriado
A pasta Controller é o ponto de entrada principal da API
Dentro da classe fica o HttpGet(). Dentro do parenteses é onde fica o a porta de entrada que deve ser digitada para dar acesso a função da API. Importante notar que as classes, por convenção, tem a palavra Controller em seu final, mas para abrir a API, o controller precisa ser omitido.