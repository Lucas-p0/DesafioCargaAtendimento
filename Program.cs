using System.Text.Json;
using DesafioCargaAtendimento.Classes;
using DesafioCargaAtendimento.FilterLinq;

using (HttpClient client = new())
{
    string URL_API = "https://raw.githubusercontent.com/Lucas-p0/DesafioCargaAtendimento/main/Carga_Atendimento.json";

    try
    {
        string response = await client.GetStringAsync(URL_API);
        var consultas = JsonSerializer.Deserialize<List<Consulta>>(response);
        Filtros.MaiorValorDeFranquiaPagaPorSegurado(consultas);



    }
    catch (Exception ex)
    {
        Console.WriteLine($"Deu erro aquiii: {ex.Message}");
    }
}
