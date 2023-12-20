using System.Text.Json.Serialization;

namespace DesafioCargaAtendimento.Classes;

public class Consulta
{

    [JsonPropertyName("Código Atendimento")]
    public int CodigoAtendimento { get; protected set; }

    [JsonPropertyName("Data de Abertura")]
    public string? DataAbertura { get; protected set; }

    [JsonPropertyName("Seguradora")]
    public string? Seguradora { get; protected set; }

    [JsonPropertyName("Item danificado")]
    public string? ItemDanificado { get; protected set; }

    [JsonPropertyName("Valor de Franquia")]
    public int ValorDeFranquia { get; protected set; }

    [JsonPropertyName("Nome do Segurado")]
    public string? NomeDoSegurado { get; protected set; }

    [JsonPropertyName("Nome Atendente")]
    public string? NomeAtendente { get; protected set; }

    [JsonPropertyName("Cidade")]
    public string? Cidade { get; protected set; }

    [JsonPropertyName("Estado")]
    public string? Estado { get; protected set; }

    [JsonPropertyName("Número da Apólice")]
    public int NumeroDaApolice { get; protected set; }

    [JsonPropertyName("Nome do Veículo")]
    public string? NomeDoVeículo { get; protected set; }
}
