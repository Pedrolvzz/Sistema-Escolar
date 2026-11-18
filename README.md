## Sistema de Gerenciamento de Alunos

Aplicação de console desenvolvida em C# para cadastrar alunos e notas, consultar resultados e acompanhar o desempenho da turma.

## Funcionalidades

- Cadastrar aluno e sua nota.
- Listar os alunos cadastrados.
- Consultar a nota de um aluno pelo nome.
- Calcular a média da turma.
- Exibir a situação de cada aluno: aprovado (nota a partir de 7) ou reprovado.
- Encerrar o sistema pelo menu.

## Requisitos

- [.NET SDK](https://dotnet.microsoft.com/download) instalado.

## Como executar

1. Crie um projeto de console:

   ```bash
   dotnet new console -n GerenciamentoAlunos
   cd GerenciamentoAlunos
   ```

2. Substitua o conteúdo de `Program.cs` pelo código deste projeto.
3. Execute:

   ```bash
   dotnet run
   ```

## Como usar

Escolha uma opção digitando o número correspondente no menu:

| Opção | Ação |
| --- | --- |
| 1 | Cadastrar aluno e nota |
| 2 | Listar alunos |
| 3 | Consultar nota por nome |
| 4 | Ver média da turma |
| 5 | Ver situação dos alunos |
| 6 | Sair |

## Observações

- Os dados ficam armazenados apenas durante a execução. Ao fechar o programa, os cadastros são perdidos.
- A aprovação é definida pela nota mínima 7.
- Digite a nota usando o separador decimal aceito pela configuração regional do sistema.

## Tecnologias

- C#
- .NET
- Aplicação de console
