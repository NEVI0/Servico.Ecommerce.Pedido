# Sistema de Gerenciamento de Pedidos - Ecommerce

## Propósito do Sistema

O sistema de **Gerenciamento de Pedidos** foi desenvolvido para a gestão de pedidos em um ambiente de **e-commerce**. Ele permite que os clientes façam compras online, escolhendo produtos, realizando pedidos e efetuando pagamentos de forma simples e rápida. O sistema também oferece uma interface administrativa para o gerenciamento de pedidos, produtos e clientes, proporcionando controle e eficiência nas operações de um e-commerce.

## Usuários

O sistema possui dois tipos principais de usuários:

### 1. **Cliente**
   - **Objetivo**: Realizar compras e gerenciar seus pedidos.
   - **Ações**:
     - Realizar pedidos de produtos.
     - Consultar pedidos realizados.
     - Atualizar a quantidade de produtos nos pedidos existentes.

### 2. **Administrador**
   - **Objetivo**: Gerenciar os pedidos, produtos e clientes do sistema.
   - **Ações**:
     - Criar, visualizar e gerenciar pedidos.
     - Atualizar informações sobre produtos.
     - Visualizar informações de clientes.
     - Atualizar a quantidade de produtos nos pedidos.

## Requisitos Funcionais

### 1. **Cadastro de Pedidos**
   - O sistema deve permitir que o cliente faça um pedido de produtos, selecionando os itens desejados e definindo a quantidade.
   - O pedido deve incluir informações como **cliente**, **produtos**, **data** e **método de pagamento**.
   - O sistema deve salvar o pedido no banco de dados e gerar um ID único para cada pedido.

### 2. **Consulta de Pedidos**
   - O cliente deve poder consultar os detalhes de um pedido específico a partir do **ID do pedido**.
   - O administrador deve poder visualizar todos os pedidos, com a possibilidade de filtrar por **cliente** ou **data**.

### 3. **Atualização de Quantidade de Produtos**
   - O administrador pode atualizar a quantidade de um produto em um pedido.
   - O cliente também pode atualizar a quantidade de produtos em seus pedidos, caso o pedido ainda não tenha sido processado.

### 4. *Gerenciamento de Produtos*
   - O administrador pode cadastrar novos produtos no sistema.
   - O administrador pode visualizar, editar ou excluir produtos existentes no sistema.
   - O administrador deve gerenciar o estoque de produtos, garantindo que a quantidade em estoque seja sempre precisa.

### 5. *Gestão de Clientes*
   - O sistema deve permitir que o administrador consulte informações sobre os clientes, como *nome, **email, **CPF*, etc.
   - O administrador deve poder adicionar novos clientes ou editar informações existentes.

### 6. *Autenticação e Autorização*
   - O sistema deve garantir que apenas os administradores tenham acesso às funcionalidades de gerenciamento de pedidos, produtos e clientes.
   - O cliente deve acessar apenas suas próprias informações de pedido e não ter acesso a dados de outros usuários.

### 7. *Relatórios e Estatísticas*
   - O sistema deve permitir a geração de relatórios de vendas e a quantidade de produtos vendidos, ajudando na análise do desempenho do e-commerce.
   - O administrador deve poder filtrar relatórios por *período* e *produto*.

### 8. *Persistência de Dados*
   - O sistema deve persistir os dados em um banco de dados relacional.
   - As informações de pedidos, produtos e clientes devem ser armazenadas e consultadas de maneira eficiente, com suporte para consultas complexas.

# Microsserviço de Gerenciamento de Pedidos

## Função do Microsserviço

O *Microsserviço de Gerenciamento de Pedidos* é responsável pela gestão de pedidos dentro de um sistema de e-commerce. Este microsserviço permite que clientes façam pedidos de produtos, realizem alterações na quantidade dos produtos e escolham métodos de pagamento. Ele também fornece funcionalidades para os administradores do sistema, como a visualização e o gerenciamento de pedidos, produtos e clientes.

### Principais Funcionalidades

- *Criação de Pedidos*: Permite que os clientes façam pedidos com base nos produtos disponíveis no catálogo.
- *Consulta de Pedidos*: Os clientes podem consultar os detalhes de seus pedidos passados, e os administradores podem visualizar todos os pedidos realizados.
- *Atualização de Quantidade de Produtos*: O administrador pode atualizar a quantidade de um produto em um pedido existente, assim como os clientes podem ajustar seus pedidos antes de serem finalizados.
- *Gerenciamento de Produtos*: O administrador pode adicionar, editar ou excluir produtos, além de atualizar os detalhes relacionados ao estoque de cada produto.
- *Gestão de Clientes*: Permite a consulta e o gerenciamento de informações de clientes, como dados de contato e histórico de pedidos.

Este microsserviço é projetado para ser *escável, **modular* e *fácil de integrar* com outros serviços dentro de um ecossistema de e-commerce, garantindo que as operações de pedidos sejam realizadas de forma eficiente e segura.
