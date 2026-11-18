List<string> alunos = new List<string>();
List<double> notas = new List<double>();

bool continuar = true;

while (continuar)
{
    Console.WriteLine("\n*** Sistema de Gerenciamento de Alunos ***");

    Console.WriteLine("\n1 - Cadastrar Aluno");
    Console.WriteLine("2 - Listar Alunos");
    Console.WriteLine("3 - Consultar Nota");
    Console.WriteLine("4 - Média da Turma");
    Console.WriteLine("5 - Situação dos Alunos");
    Console.WriteLine("6 - Sair");

    Console.Write("-> ");
    int escolha = Convert.ToInt32(Console.ReadLine());

    if (escolha == 1)
    {
        Console.Write("Nome do Aluno: ");
        string novoAluno = Console.ReadLine().ToLower().Trim();

        Console.Write("Nota do Aluno: ");
        double novaNota = Convert.ToDouble(Console.ReadLine());

        alunos.Add(novoAluno);
        notas.Add(novaNota);

        Console.WriteLine("Aluno Adicionado.");
    }

    else if (escolha == 2)
    {
        Console.WriteLine("*** LISTA DE ALUNOS ***");

        if (alunos.Count == 0)
        {
            Console.WriteLine("Nenhum aluno cadastrado.");
        }
        else
        {
            foreach (string aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }

    else if (escolha == 3)
    {
        Console.Write("Nome do Aluno: ");
        string nome = Console.ReadLine().ToLower().Trim();

        int posicao = alunos.IndexOf(nome);

        if (posicao != -1)
        {
            Console.WriteLine($"Nota de {nome}: {notas[posicao]}");
        }
        else
        {
            Console.WriteLine("O Aluno não foi encontrado.");
        }
    }

    else if (escolha == 4)
    {
        Console.WriteLine("*** MÉDIA DA TURMA ***");

        double soma = 0;

        if (notas.Count > 0)
        {
            foreach (double nota in notas)
            {
                soma += nota;
            }

            double media = soma / notas.Count;

            Console.WriteLine($"Média da turma: {media:F2}");
        }
        else
        {
            Console.WriteLine("Não há notas cadastradas.");
        }
    }

    else if (escolha == 5)
    {
        if (alunos.Count == 0)
        {
            Console.WriteLine("Nenhum aluno cadastrado.");
        }
        else
        {
            for (int i = 0; i < alunos.Count; i++)
            {
                if (notas[i] >= 7)
                {
                    Console.WriteLine($"{alunos[i]} - Nota: {notas[i]} - Aprovado.");
                }
                else
                {
                    Console.WriteLine($"{alunos[i]} - Nota: {notas[i]} - Reprovado.");
                }
            }
        }
    }

    else if (escolha == 6)
    {
        Console.WriteLine("Saindo do Sistema...");
        continuar = false;
    }

    else
    {
        Console.WriteLine("Opção inválida.");
    }
}