# Projeto Web .NET MVC - Clínica Veterinária LH-Pet

Este é um projeto inicial de uma aplicação web .NET utilizando a arquitetura MVC para a clínica veterinária LH-Pet. A aplicação foi estruturada para gerenciar clientes e fornecedores da empresa, com a possibilidade de futuramente integrar um banco de dados para persistência dos dados.

## Objetivo

O objetivo inicial deste projeto é estabelecer a estrutura básica de uma aplicação web MVC e criar os modelos de Cliente e Fornecedor, além de implementar a lógica no HomeController para criar e exibir listas de clientes e fornecedores.

## Estrutura do Projeto

O projeto segue a arquitetura MVC (Model-View-Controller) para separar responsabilidades e garantir uma melhor organização do código:

- **Model (Modelo)**
  - `Cliente`: Representa um cliente da clínica veterinária.
  - `Fornecedor`: Representa um fornecedor da clínica veterinária.

- **View (Visualização)**
  - `Index.cshtml`: Exibe listas de clientes e fornecedores.

- **Controller (Controlador)**
  - `HomeController`: Responsável por gerenciar as interações entre as views e os modelos, incluindo a criação e exibição de listas de clientes e fornecedores.

## Configuração do Projeto

Para executar este projeto em sua máquina local, siga os passos abaixo:

1. Certifique-se de ter o ambiente de desenvolvimento .NET configurado em sua máquina. Você pode baixar e instalar o [.NET SDK](https://dotnet.microsoft.com/download) caso ainda não tenha.

2. Clone este repositório para sua máquina local:
   ```bash
   git clone https://github.com/iz-brum/LH-Pets-senai.git

3. Navegue até o diretório do projeto:
   ```bash
   cd LH-Pets-senai

4. Execute o projeto utilizando o CLI do .NET:
   ```bash
   dotnet run

## Desenvolvimento Futuro
Após a fase inicial, o projeto poderá ser expandido para incluir a persistência de dados utilizando um banco de dados. Novos recursos e funcionalidades podem ser adicionados para atender às necessidades da clínica veterinária LH-Pet.

Este projeto foi desenvolvido como parte de um processo inicial para estabelecer a estrutura básica de uma aplicação web .NET MVC. A partir daqui, novos recursos e melhorias podem ser implementados conforme necessário.
