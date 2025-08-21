# ECommerceApp

Este projeto é uma aplicação de e-commerce composta por backend (.NET), frontend (React) e bancos de dados (MongoDB, PostgreSQL, Redis).

## Pré-requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Node.js](https://nodejs.org/)
- [Docker](https://www.docker.com/)

## Setup do ambiente

1. **Clone o repositório:**

   ```sh
   git clone https://github.com/marcommacedo/ecommerce-app.git
   cd ecommerce-app
   ```

2. **Suba os serviços de banco de dados com Docker Compose:**

   ```sh
   docker-compose up -d
   ```

3. **Backend (.NET):**

   - Entre na pasta do backend:
     ```sh
     cd src/ECommerce.Api
     ```
   - Restaure os pacotes e execute as migrações (se necessário):
     ```sh
     dotnet restore
     dotnet ef database update
     ```
   - Execute a API:
     ```sh
     dotnet run
     ```

4. **Frontend (React):**
   - Entre na pasta do frontend:
     ```sh
     cd frontend/ecommerce-web
     ```
   - Instale as dependências:
     ```sh
     npm install
     ```
   - Execute o frontend:
     ```sh
     npm run dev
     ```

## Testes

- **Testes unitários:**
  ```sh
  dotnet test tests/ECommerce.UnitTests
  ```
- **Testes de integração:**
  ```sh
  dotnet test tests/ECommerce.IntegrationTests
  ```

## Observações

- Os bancos de dados são inicializados via Docker e persistem dados nas pastas `.data/`.
- As configurações podem ser ajustadas nos arquivos `appsettings.json` e `docker-compose.yml`.

## Estrutura do projeto

```
.data/                     # Dados dos bancos (MongoDB, PostgreSQL, Redis)
frontend/
  ecommerce-web/           # Frontend React
src/
  ECommerce.Api/           # Backend .NET API
  ECommerce.Core/          # Domínio e lógica de negócio
  ECommerce.Infrastructure/# Infraestrutura (bancos, repositórios)
tests/
  ECommerce.UnitTests/     # Testes unitários
  ECommerce.IntegrationTests/ # Testes de integração
```

---
