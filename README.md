# EShopMicroservices

Aplicação de exemplo para microservices em C# utilizando Domain-Driven Design (DDD), Command Query Responsibility Segregation (CQRS) e Clean Architecture.

## Tecnologias e Ferramentas Utilizadas

- **C#**: Linguagem principal de desenvolvimento.
- **Domain-Driven Design (DDD)**: Abordagem para modelagem do domínio e estruturação do código.
- **CQRS (Command Query Responsibility Segregation)**: Padrão para separar a leitura e escrita de dados.
- **Clean Architecture**: Arquitetura que facilita a manutenção, testes e evolução do sistema.
- **RabbitMQ**: Sistema de mensageria para comunicação entre microservices.
- **MassTransit**: Biblioteca para facilitar a integração e o uso do RabbitMQ.

## Características

- **Desenvolvimento de Microservices com ASP.NET Core 8 Web API**: Utilizando as últimas funcionalidades do .NET 8 e C# 12.
- **APIs Mínimas do ASP.NET e implementação de Vertical Slice Architecture**: Organização do código em Feature Folders.
- **Implementação de CQRS usando a biblioteca MediatR**: Inclui Pipeline Behaviours para validação com MediatR e FluentValidation.
- **Banco de Dados Transacional de Documentos com Marten**: Utilização do PostgreSQL.
- **Definição de endpoints com Carter Library para APIs Mínimas**.
- **Uso do Redis como Cache Distribuído**: Implementação sobre o BasketDB.
- **Padrões de Design Proxy, Decorator e Cache-aside**.
- **Comunicação inter-serviços altamente performática com gRPC**: Implementação no Basket Microservice.
- **Consumo de serviços gRPC para comunicação síncrona inter-serviços**: Calculando o preço final do produto com o serviço de desconto.
- **Publicação da fila BasketCheckout com MassTransit e RabbitMQ**.
- **Conexão e conteinerização do banco de dados PostgreSQL**.
- **Implementação de DDD, CQRS e Clean Architecture seguindo as melhores práticas**.
- **Design Tático de DDD**: Inclui Entidades, Objetos de Valor, Agregados e Raízes de Agregados.
- **Desenvolvimento de CQRS com MediatR, FluentValidation e Mapster**.
- **Uso do Entity Framework Core ORM**: Migração automática para SQL Server no startup da aplicação.
- **Abordagem Code-First do Entity Framework Core, Migrations e Configurações de Entidade DDD em Clean Architecture**.
- **Comunicação assíncrona entre microservices com RabbitMQ**: Utilizando o modelo Publish/Subscribe com Topic Exchange.
- **Consumo de eventos RabbitMQ BasketCheckout com MassTransit-RabbitMQ Configuration**.
- **Uso do MassTransit para abstração sobre o sistema de mensageria RabbitMQ**.
- **API Gateways com YARP Reverse Proxy**: Aplicação do padrão Gateway Routing.
- **Configuração do YARP Reverse Proxy**: Inclui Route, Cluster, Path, Transform e Destinations.
- **Rate Limiting com FixedWindowLimiter no YARP Reverse Proxy Configuration**.
- **Aplicação Web ASP.NET Core**: Utilização do Bootstrap 4 e template Razor.
- **Consumo das APIs do YarpApiGateway usando a biblioteca Refit com HttpClientFactory gerado**.
- **Preocupações transversais**: Logging, tratamento global de exceções e verificações de integridade (Health Checks).
- **Dockerfile e docker-compose para execução de ambiente Docker multi-contêiner**.
