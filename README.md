# Sistema de Estoque de Produtos (Console Application)

Este é um sistema simples de estoque de produtos desenvolvido em C# .NET utilizando Dapper para a interação com o banco de dados SQL. O sistema implementa um CRUD (Create, Read, Update, Delete) para cadastro de produtos e categorias de produtos, além de realizar consultas e gerar relatórios. Operações para inclusão, edição e exclusão de produtos no banco de dados são realizadas através de *Stored Procedures* utilizando T-SQL (Transact-SQL). O projeto é executado em um ambiente de console (DOS).

## Tecnologias Utilizadas

- **C# .NET 8** (Console Application)
- **SQL Server**
- **Dapper** (Micro ORM para interação com o banco de dados)
- **Stored Procedures** para operações no banco de dados
- **T-SQL (Transact-SQL)**

## Funcionalidades

O sistema de estoque implementa as seguintes funcionalidades:

### Produtos
- **Cadastrar Produto**: Adiciona novos produtos ao sistema.
- **Listar Produtos**: Exibe todos os produtos cadastrados.
- **Editar Produto**: Atualiza as informações de um produto existente.
- **Excluir Produto**: Remove um produto do sistema.
- **Consultar Produtos**: Permite buscar produtos com base em critérios definidos (por exemplo, nome ou categoria).
- **Gerar Relatório de Produtos**: Cria relatórios com informações detalhadas dos produtos cadastrados, como quantidade em estoque, preço, etc.

### Estoques
- **Cadastrar Estoque**: Adiciona novos estoques de produtos.
- **Atualizar Estoque**: Atualiza os dados do estoque.
- **Excluir Estoque**: Exclui o estoque cadastrado.
- **Consultar Todos Estoques**: Exibe todos os estoques cadastrados.

## Estrutura do Projeto

O projeto segue uma estrutura simples e organizada para facilitar o desenvolvimento e a manutenção. Não utiliza separação em camadas de serviços ou repositórios. A interação com o banco de dados é feita diretamente a partir da aplicação de console.

## Configuração do Banco de Dados

O banco de dados utilizado é SQL Server, e as operações CRUD (inclusão, edição, exclusão) são realizadas através de *Stored Procedures*. O Dapper é utilizado para facilitar a execução dessas consultas e procedimentos armazenados.

## Como Executar o Projeto

1. **Clonar o Repositório**:
   ```bash
   git clone https://github.com/seu-usuario/seu-projeto-de-estoque.git
