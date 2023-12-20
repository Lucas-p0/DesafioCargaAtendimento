using DesafioCargaAtendimento.Classes;
using System.Collections.Generic;
namespace DesafioCargaAtendimento.FilterLinq;

public class Filtros
{


    public static void FiltraTodosSegurados(List<Consulta> consultas)
    {
        var filtraTodosSegurados = consultas.Select(c => c.NomeDoSegurado).Distinct().ToList();
        var consultasPorSerie = consultas.GroupBy(consulta => consulta.NomeDoVeiculo);
        foreach (var consulta in filtraTodosSegurados)
        {
            Console.WriteLine($"{consulta}");
        }


    }
    //1 – Qual é o maior valor de franquia pago por um Segurado? (0,5)
    public static void MaiorValorDeFranquiaPagaPorSegurado(List<Consulta> consultas)
    {
        var maiorValorDeFranquia = consultas.Max(consulta => consulta.ValorDeFranquia);
        // var MaiorValorDeFranquia = consultas.Max(consulta => consulta.ValorDeFranquia);
        // var consultaPorSegurado = consultas.GroupBy(consulta => consulta.NomeDoSegurado);
        // var maioresValoresPorSegurado = consultaPorSegurado
        //             .Select(grupo =>
        //                 new
        //                 {
        //                     NomeDoSegurado = grupo.Key,
        //                     MaiorValorDeFranquia = grupo.Max(consulta => consulta.ValorDeFranquia)
        //                 });
        // foreach (var maiorValor in maioresValoresPorSegurado)
        // {
        //     System.Console.WriteLine($"{maiorValor.NomeDoSegurado} {maiorValor.MaiorValorDeFranquia}");
        // }
        System.Console.WriteLine($"O maior valor de franquia pago por um segurado é: {maiorValorDeFranquia}");
    }

    //2 – Quantos atendentes temos em nossa Central? Conte sem repetição. (0,5)
    public static void TotalDeAtendentesNaCentral(List<Consulta> consultas)
    {
        var TotalDeAtendentes = consultas.Select(c => c.NomeAtendente).Distinct().Count();

        System.Console.WriteLine($"Até o presente momento nós temos o total de {TotalDeAtendentes} atendentes");
    }


    //3-Quantos atendimentos temos mensalmente? Faça uma lista ordenada ascendente dos meses e as respectivas quantidades
    public static void QuantidadeDeAtendimentosPorMes(List<Consulta> consultas)
    {
        var atendimentosPorMes = consultas
                .GroupBy(consulta => consulta.DataAbertura)
                .Select(grupo => new
                {
                    Mes = grupo.Key,
                    Quantidade = grupo.Count()
                })
                .OrderBy(resultado => resultado.Mes);


        foreach (var resultado in atendimentosPorMes)
        {
            System.Console.WriteLine(resultado);
        }


    }
}


