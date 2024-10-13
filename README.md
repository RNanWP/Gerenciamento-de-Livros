# Sistema de Gerenciamento de Livros

Este projeto é um sistema simples de gerenciamento de livros desenvolvido em C# utilizando o Windows Forms (.NET Framework). O sistema permite o cadastro e exibição de informações sobre livros e seus autores.

## Funcionalidades

- Cadastro de autores com nome e nacionalidade.
- Cadastro de livros com título e autor associado.
- Exibição dos livros em um formato de tabela, mostrando o autor, título e nacionalidade.

## Estrutura do Projeto

O projeto é composto pelos seguintes arquivos principais:

- **Program.cs**: Ponto de entrada do aplicativo.
- **Form1.cs**: Controlador principal do formulário onde ocorrem as interações do usuário.
- **Form1.Designer.cs**: Designer do formulário que contém a definição dos componentes visuais.
- **Livros.cs**: Classes que representam o modelo de dados do sistema (Livro e Autor).

## Como Usar

1. **Instalação do Ambiente**:
   - Certifique-se de ter o [Visual Studio](https://visualstudio.microsoft.com/) instalado em seu computador com suporte para C# e Windows Forms.

2. **Clone o Repositório**:
   ```bash
   git clone https://github.com/RNanWP/Gerenciamento-de-Livros.git
   cd GerenciamentoDeLivros

3. **Abra o Projeto:**
- Abra o arquivo .sln no Visual Studio.

4. **Compile e Execute:**
- Compile o projeto e inicie a execução no Visual Studio.

5. **Interaja com o Sistema:**
- Clique no botão "Mostrar Livro" para exibir os livros cadastrados em uma tabela.

## Exemplo de Uso
- Após a execução do aplicativo, você verá um formulário simples onde pode clicar no botão "Mostrar Livro". Uma tabela será exibida com as informações dos livros e seus autores.


| **Autor**         | **Título**                           | **Nacionalidade**  |
|--------------------|--------------------------------------|---------------------|
| J.K. Rowling       | Harry Potter e a Pedra Filosofal    | Reino Unido         |
| George R.R. Martin | A Guerra dos Tronos                  | EUA                 |
| J.R.R. Tolkien     | O Senhor dos Anéis                   | Reino Unido         |


## Licença
Este projeto está licenciado sob a MIT License - veja o arquivo LICENSE para detalhes.

## Contato
Se precisar de mais alguma coisa ou de ajustes, sinta-se à vontade para me contatar!
