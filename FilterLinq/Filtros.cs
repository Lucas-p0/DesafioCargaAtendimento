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
        var TodasAsDatas = consultas.Select(c => c.DataAbertura);
        var atendimentosPorMes = consultas
                .GroupBy(consulta => consulta.DataAbertura)
                .Select(grupo => new
                {
                    Mes = grupo.Key,
                    Quantidade = grupo.Count()
                })
                .OrderBy(resultado => resultado.Mes);



    }
    //4-Faça um TOP 5 de Seguradoras que mais tiveram atendimentos. Faça um TOP 5 dos veículos que mais apareceram na lista. Faça um TOP 3 de Itens danificados que mais apareceram na lista. 



    public static void ListaTop5ListaETop3Danificados(List<Consulta> consultas)
    {

        var top5Seguradoras = consultas
          .GroupBy(consulta => consulta.Seguradora)
          .OrderByDescending(grupo => grupo.Count())
          .Take(5)
          .Select(grupo => new
          {
              Seguradora = grupo.Key,
              Quantidade = grupo.Count()
          });
        foreach (var top5seg in top5Seguradoras)
        {
            Console.WriteLine($"TOP 5 de Seguradoras:{top5seg}");

        }
        var top5Veiculos = consultas
            .GroupBy(consulta => consulta.NomeDoVeiculo)
            .OrderByDescending(grupo => grupo.Count())
            .Take(5)
            .Select(grupo => new
            {
                Veiculo = grupo.Key,
                Quantidade = grupo.Count()
            });
        foreach (var top5veic in top5Veiculos)
        {
            Console.WriteLine($"TOP 5 de Veículos: {top5veic}");

        }

        var top3ItensDanificados = consultas
            .GroupBy(consulta => consulta.ItemDanificado)
            .OrderByDescending(grupo => grupo.Count())
            .Take(3)
            .Select(grupo => new
            {
                ItemDanificado = grupo.Key,
                Quantidade = grupo.Count()
            });

        foreach (var top3c in top3ItensDanificados)
        {
            Console.WriteLine($"TOP 3 de Itens Danificados:{top3c}");

        }

    }

    //5 – Referente aos segurados. Quantos segurados temos em nossa base? Faça um TOP 5 do total de acionamento dos segurados com o valor de franquia e a quantidade de atendimentos abertos.
    public static void Top5totalDeAcionamentos(List<Consulta> consultas)
    {
        var top5Acionamentos = consultas
                .GroupBy(consulta => consulta.NomeDoSegurado)
                .OrderByDescending(grupo => grupo.Count())
                .Take(5)
                .Select(grupo => new
                {
                    NomeDoSegurado = grupo.Key,
                    QuantidadeAtendimentos = grupo.Count(),
                    ValorTotalFranquia = grupo.Sum(consulta => consulta.ValorDeFranquia)
                });

        foreach (var top5 in top5Acionamentos)
        {
            Console.WriteLine($"TOP 5 de acionamentos de segurados:{top5}");

        }

    }

    public static void EstadosComMaiorNumeroDeAtedimentosAbertos(List<Consulta> consultas)
    {
        var top5EstadosPorMes = consultas
                        .GroupBy(consulta => new { Estado = consulta.Estado, Mes = consulta.DataAbertura })
                        .OrderByDescending(grupo => grupo.Count())
                        .Take(5)
                        .Select(grupo => new
                        {
                            Estado = grupo.Key.Estado,
                            Mes = grupo.Key.Mes,
                            QuantidadeAtendimentos = grupo.Count()
                        });

        foreach (var top5 in top5EstadosPorMes)
        {
            Console.WriteLine($"TOP 5 de estados com maior número de atendimentos por mês:{top5}");

        }
    }
}








