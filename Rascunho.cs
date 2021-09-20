/*
DDD (Domain-Driven Design)

CQRS (Command Query Responsibility Segregation)

Criando um contexto de um projeto de pagamentos (gateway de pagamentos) e passando por todas as etapas na modelagem da solução.

1 - Criar as pastas:
    md PaymentContext.Domain
    md PaymentContext.Shared
    md PaymentContext.Tests

2 - Gerar a solution:
    dotnet new sln

3 - Adicionar classlibs (classlibery é um projeto que no final, depois de compilado, gera uma dll):
    cd PaymentContext.Domain
    dotnet new classlib
    cd PaymentContext.Shared
    dotnet new classlib
    cd PaymentContext.Tests
    dotnet new mstest

4 - Adicionando o projeto à solução
    cd PaymentContext
    dotnet sln add PaymentContext.Domain/PaymentContext.Domain.csproj
    cd PaymentContext
    dotnet sln add PaymentContext.Shared/PaymentContext.Shared.csproj
    cd PaymentContext
    dotnet sln add PaymentContext.Tests/PaymentContext.Tests.csproj

5 - Restaurar todos os pacotes dos projetos:
    dotnet restore
    dotnet build (compilar)

6 - Explicação:
    Domain = domínio rico
    Shared = itens que podemos compartilhar entre os domínios (o shared serve para trabalharmos com múltiplos domínios)
    Tests = testes que vamos executar

7- Adicionando Referências:
    cd PaymentContext.Domain
    dotnet add reference ../PaymentContext.Shared/PaymentContext.Shared.csproj
    //adicionando referência do shared no domínio. Então, o domínio referencia somente o shared.
    
    //o shared nao refencia ninguem pq esse projeto nao tem múltiplos domínios.

    cd PaymentContext.Tests
    dotnet add reference ../PaymentContext.Shared/PaymentContext.Shared.csproj
    dotnet add reference ../PaymentContext.Domain/PaymentContext.Domain.csproj
    //tests referencia os dois (domain e shared)
    dotnet build (compilar)

8 - Conclusão:
    Domain depende do Shared
    Shared não depende de ninguém
    Tests depende do Domain e do Shared
*/