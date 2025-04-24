# 📚 Sistema Biblioteca

Um sistema de gerenciamento de biblioteca desenvolvido em C# (.NET), com foco em práticas de programação orientada a objetos. Permite adicionar, listar, buscar, remover e salvar livros em um arquivo JSON.

## 🚀 Funcionalidades

- ✅ Adicionar livros com título, autor e ano de publicação
- ✅ Listar todos os livros cadastrados
- ✅ Buscar livros por título (case-insensitive)
- ✅ Remover livros pelo título
- ✅ Salvar e carregar dados em formato JSON

## 🛠️ Tecnologias Utilizadas

- C# (.NET 6 ou superior)
- Serialização JSON com `System.Text.Json`
- Aplicação de console (CLI)

## 📂 Estrutura do Projeto

```
SistemaBiblioteca/
├── Book.cs
├── Library.cs
├── Program.cs
├── libraryData.json
└── README.md
```

## ▶️ Como Executar

1. Clone o repositório:

   ```bash
   git clone https://github.com/Otavinhopx/5-Sistema_Biblioteca.git
   cd 5-Sistema_Biblioteca
   ```

2. Compile e execute o projeto:

   ```bash
   dotnet build
   dotnet run
   ```

3. Siga as instruções no console para interagir com o sistema.

## 💾 Salvamento de Dados

Os dados dos livros são armazenados no arquivo `libraryData.json`, que é criado automaticamente na raiz do projeto. O sistema carrega os dados desse arquivo ao iniciar, se ele existir.
