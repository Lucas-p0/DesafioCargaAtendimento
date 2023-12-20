using DesafioCargaAtendimento.Classes;

namespace DesafioCargaAtendimento.FilterLinq;

public class Filtros
{
    public static void MaiorValorDeFranquiaPagaPorSegurado(List<Consulta> consultas)
    {
        var MaiorValorDeFranquia = consultas.Max(consulta => consulta.ValorDeFranquia);
        var consultaPorSegurado = consultas.GroupBy(consulta => consulta.NomeDoSegurado);
        var maioresValoresPorSegurado = consultaPorSegurado
                    .Select(grupo =>
                        new
                        {
                            NomeDoSegurado = grupo.Key,
                            MaiorValorDeFranquia = grupo.Max(consulta => consulta.ValorDeFranquia)
                        });
        foreach (var maiorValor in maioresValoresPorSegurado)
        {
            System.Console.WriteLine($"{maiorValor.NomeDoSegurado} {maiorValor.MaiorValorDeFranquia}");
        }
        System.Console.WriteLine(MaiorValorDeFranquia);
    }

}
