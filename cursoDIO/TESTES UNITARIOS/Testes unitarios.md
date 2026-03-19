## Testes Unitários com c#
# O que são testes unitarios?
São testes programados no código fonte de um projeto que automatiza cenários,assim automatizando todo os processos de teste. 
Pode validar resultados e comportamentos daquilo que foi escrito.
Testes unitários agilizam o processo de teste.

![estrutura de pastas](images/estrutura%20de%20pastas.png)

Acima está um exemplo de uma implementação de um programa que pode somar dois numeros(CalculadoraImp.cs) e conta quantos numeros um texto tem (ValidacoesString.cs). Este programa faz isso atraves de duas classes na pasta Services.

O programa principal fica na pasta Calculadora/, e as funcionalidades de testes acontecem em outra pasta, por simplicidade, nomeamos o outro local de CalculadoraTestes/. Interessante notar que para criarmos esta estrutura de pasta de testes, usamos seguinte comando no terminal `dotnet new xunit`.

