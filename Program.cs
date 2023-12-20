using System.Collections.Generic;
using System.Text.Json;
using DesafioCargaAtendimento.Classes;
using DesafioCargaAtendimento.FilterLinq;

using (HttpClient client = new())
{
    string URL_API = "https://raw.githubusercontent.com/Lucas-p0/DesafioCargaAtendimento/main/Carga_Atendimento_string_novo.json";

    try
    {
        string response = await client.GetStringAsync(URL_API);
        var consultas = JsonSerializer.Deserialize<List<Consulta>>(response);
        //Filtros.FiltraTodosSegurados(consultas);

        //1 – Qual é o maior valor de franquia pago por um Segurado? (0,5)
        //Filtros.MaiorValorDeFranquiaPagaPorSegurado(consultas);

        //2 – Quantos atendentes temos em nossa Central? Conte sem repetição. (0, 5)
        //Filtros.TotalDeAtendentesNaCentral(consultas);

        //3 – Quantos atendimentos temos mensalmente? Faça uma lista ordenada ascendente dos meses e as respectivas quantidades.
        Filtros.QuantidadeDeAtendimentosPorMes(consultas);




    }
    catch (Exception ex)
    {
        Console.WriteLine($"Deu erro aquiii: {ex.Message}");
    }
}
