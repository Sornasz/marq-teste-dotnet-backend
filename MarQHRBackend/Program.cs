using System;
using System.Collections.Generic;

class Colaborador
{
    public string Nome { get; set; }
    public string CPF { get; set; }
    public Dictionary<string, decimal> SaldoCategoria { get; set; }

    public Colaborador(string nome, string cpf)
    {
        Nome = nome;
        CPF = cpf;
        SaldoCategoria = new Dictionary<string, decimal>
        {
            {"Alimentação", 1000m},
            {"Saúde", 1000m},
            {"Transporte", 1000m},
            {"Cultura", 1000m},
            {"Outros", 1000m},
        };
    }
}

class Program
{
    static List<Colaborador> colaboradores = new List<Colaborador>();
    static void Main(string[] args)
    {
        Console.Write("Mini Sistema de Benefícios MarQ HR!");
        CadastrarColaborador();
    }

    static void CadastrarColaborador()
    {
        Console.Write("Digite o Nome do Colaborador: ");
        string nome = Console.ReadLine();

        Console.Write("Digite O CPF do colaborador: ");
        string cpf = Console.ReadLine();

        var colaborador = new Colaborador(nome, cpf);

        colaboradores.Add(colaborador);

        Console.WriteLine("Colaborador Cadastrado com êxito!");
    }
}