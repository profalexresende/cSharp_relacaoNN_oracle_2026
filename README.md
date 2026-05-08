# CRUD de Jogos e Plataformas com ASP.NET MVC + Oracle

Projeto desenvolvido com ASP.NET Core MVC utilizando Entity Framework Core e banco de dados Oracle.

O sistema permite cadastrar jogos e plataformas utilizando um relacionamento N:N (muitos para muitos).

---

# Tecnologias Utilizadas

- ASP.NET Core MVC
- C#
- Entity Framework Core
- Oracle Database
- Razor
- HTML

---

# Objetivo do Projeto

Este projeto foi criado com foco didático em desenvolvimento web com .NET.

Durante o desenvolvimento, os alunos aprendem:

- Estrutura MVC
- Models
- Controllers
- Views
- Entity Framework Core
- Relacionamentos N:N
- Migrations
- Oracle Database
- CRUD completo
- Model Binding
- Injeção de Dependência

---

# Estrutura do Projeto

```txt
ProjetoJogos
│
├── Controllers
│   ├── JogosController.cs
│   └── PlataformasController.cs
│
├── Dados
│   └── AppDbContext.cs
│
├── Models
│   ├── Jogo.cs
│   ├── Plataforma.cs
│   └── JogoPlataforma.cs
│
├── Views
│   ├── Jogos
│   └── Plataformas
│
├── appsettings.json
└── Program.cs
```

---

# Relação N:N

O projeto utiliza relacionamento muitos-para-muitos.

Exemplo:

- Um jogo pode possuir várias plataformas
- Uma plataforma pode possuir vários jogos

---


# Instalação dos Pacotes

Execute os comandos abaixo no Package Manager Console:

```powershell
Install-Package Oracle.EntityFrameworkCore
Install-Package Microsoft.EntityFrameworkCore.Tools
Install-Package Microsoft.EntityFrameworkCore.Design
```

---


# Executando o Projeto

## Clonar repositório

```bash
git clone https://github.com/profalexresende/csharp_mvc_2026_oracle.git
```

---

## Entrar na pasta

```bash
cd csharp_mvc_2026_oracle
```

## Executar projeto

```bash
dotnet run
```

---

# Funcionalidades

## Jogos

- Listar jogos
- Cadastrar jogo
- Relacionar jogo com múltiplas plataformas

---

## Plataformas

- Listar plataformas
- Cadastrar plataforma

---

# Conceitos Trabalhados

## MVC

Separação entre:

- Model
- View
- Controller

---

## Entity Framework

ORM responsável pela comunicação com o banco.

Permite:

- INSERT
- UPDATE
- DELETE
- SELECT

utilizando C# ao invés de SQL puro.

---

## DbContext

Classe responsável pela comunicação entre aplicação e banco.

---

## Migration

Recurso que permite criar tabelas automaticamente a partir das classes C#.

---

# Aprendizados do Projeto

Ao concluir este projeto, o aluno será capaz de:

- Criar aplicações MVC completas
- Persistir dados no Oracle
- Trabalhar com Entity Framework
- Criar relacionamentos N:N
- Utilizar migrations
- Construir CRUDs completos
- Manipular formulários HTML
- Trabalhar com Razor

---

# Autor

Prof. Alex Sander

---

# Licença

Projeto desenvolvido para fins educacionais.
