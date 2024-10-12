# API Pessoa - .NET Core Web API

Este é um projeto simples de uma API utilizando C#, .NET Core e Entity Framework Core com um banco de dados MySQL. 
A API implementa operações básicas de CRUD (Create, Read, Update, Delete) para a entidade Pessoa.

# Tecnologias Utilizadas
C#;
.NET Core 7.0;
Entity Framework Core;
MySQL;
Migrations;
Web API

# Estrutura do Projeto

# O projeto é estruturado com as seguintes pastas e arquivos principais:

Models/: Contém as classes de modelo utilizadas pelo Entity Framework Core.
Controllers/: Contém os controladores que gerenciam as requisições HTTP para a API.
Migrations/: Contém as migrações do Entity Framework para criar e modificar o banco de dados.

# Modelo Pessoa
# A classe Pessoa representa a entidade que é persistida no banco de dados, com os seguintes atributos:

Id (int): Identificador único da pessoa.
Nome (string): Nome da pessoa.
Cidade (string): Cidade onde a pessoa mora.
Idade (int): Idade da pessoa.

# Endpoints da API
A API fornece os seguintes endpoints para manipular os dados de Pessoa:

GET /pessoa/api: Retorna uma lista de todas as pessoas.
GET /pessoa/api/{id}: Retorna uma pessoa pelo seu ID.
POST /pessoa/api: Cria uma nova pessoa.
PUT /pessoa/api/{id}: Atualiza uma pessoa existente.
DELETE /pessoa/api/{id}: Remove uma pessoa pelo ID.

# Como Executar o Projeto
Pré-requisitos
.NET Core SDK (versão 7.0 ou superior)
MySQL (configurado com um banco de dados para a aplicação)


