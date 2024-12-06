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
