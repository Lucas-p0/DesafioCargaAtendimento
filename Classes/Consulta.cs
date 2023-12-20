using System.Text.Json.Serialization;
using System.Collections.Generic;
namespace DesafioCargaAtendimento.Classes;

public class Consulta
{

    [JsonPropertyName("codigoAtendimento")]
    public int CodigoAtendimento { get; set; }

    [JsonPropertyName("dataDeAbertura")]
    public string? DataAbertura { get; set; }

    [JsonPropertyName("seguradora")]
    public string? Seguradora { get; set; }

    [JsonPropertyName("ItemDanificado")]
    public string? ItemDanificado { get; set; }

    [JsonPropertyName("valorDeFranquia")]
    public int ValorDeFranquia { get; set; }

    [JsonPropertyName("nomeDoSegurado")]
    public string? NomeDoSegurado { get; set; }

    [JsonPropertyName("nomeAtendente")]
    public string? NomeAtendente { get; set; }

    [JsonPropertyName("Cidade")]
    public string? Cidade { get; set; }

    [JsonPropertyName("Estado")]
    public string? Estado { get; set; }

    [JsonPropertyName("numeroDaApolice")]
    public int NumeroDaApolice { get; set; }

    [JsonPropertyName("nomeDoVeiDculo")]
    public string? NomeDoVeiculo { get; set; }
}
