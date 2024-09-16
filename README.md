# API ASP.NET Core Web API

## Integrantes do Grupo
Victor Fanfoni RM-99173
Helena Paixão RM-550929
Gustavo Costa RM-99102
Julia Nery RM-552292
Giulia Pina RM-97694


## Descrição do Projeto
Este projeto consiste no desenvolvimento de uma API utilizando ASP.NET Core Web API. A API segue princípios de arquitetura de software, design patterns, técnicas de documentação, testes e integração com banco de dados Oracle.

## Arquitetura

### Arquitetura Escolhida
Optamos pela arquitetura **Monolítica** para este projeto. A escolha foi baseada nos seguintes fatores:
- **Complexidade do Projeto**: A aplicação tem um escopo bem definido e não requer a escalabilidade e a flexibilidade que microservices oferecem.
- **Simplicidade de Desenvolvimento e Manutenção**: Com uma arquitetura monolítica, o desenvolvimento e a manutenção são mais simples, uma vez que todos os componentes estão em um único projeto.
- **Tempo e Recursos**: A arquitetura monolítica é mais adequada para projetos com prazos mais curtos e recursos limitados.

### Justificativa
A arquitetura monolítica permite uma implementação mais rápida e menos complexa, o que é ideal para este projeto. Ela facilita a comunicação entre os componentes e reduz a sobrecarga associada à orquestração de microservices.

## Implementação da API

### Endpoints CRUD
A API inclui endpoints CRUD para os seguintes recursos:
- **ComportamentoNegocios**: Gerencia interações e feedback dos usuários.
- **DesempenhoFinanceiro**: Gerencia dados financeiros como receita e lucro.

### Design Patterns Utilizados
- **Singleton**: Implementado para o gerenciador de configurações, garantindo que uma única instância seja usada em toda a aplicação.
  
## Documentação da API

A documentação da API foi configurada utilizando Swagger/OpenAPI. Você pode acessar a documentação dos endpoints e modelos de dados através da interface do Swagger na URL: [http://localhost:5000/swagger](http://localhost:5000/swagger)

