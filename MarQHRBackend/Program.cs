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
        Console.write("Mini Sistema de Benefícios MarQ HR!");
        CadastrarColaborador();
    }

    static void CadastrarColaborador()
    {
        Console.Write("Digite o Nome do Colaborador: ")
        String nome = Console.ReadLine();
    }
}