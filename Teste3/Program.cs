using System.Text.Json;
using System.Text.Json.Serialization;

string jsonFilePath = "dados.json";
string jsonContent = File.ReadAllText(jsonFilePath);

var faturamentoDiario = JsonSerializer.Deserialize<List<Faturamento>>(jsonContent);
var diasComFaturamento = faturamentoDiario!.Where(d => d.Valor > 0).ToList();

double menorFaturamento = diasComFaturamento.Min(d => d.Valor);
double maiorFaturamento = diasComFaturamento.Max(d => d.Valor);

double mediaMensal = diasComFaturamento.Average(d => d.Valor);

int diasAcimaDaMedia = diasComFaturamento.Count(d => d.Valor > mediaMensal);

Console.WriteLine($"Menor faturamento: {menorFaturamento}");
Console.WriteLine($"Maior faturamento: {maiorFaturamento}");
Console.WriteLine($"Dias com faturamento acima da média: {diasAcimaDaMedia}");

public class Faturamento
{
    [JsonPropertyName("dia")]
    public int Dia { get; set; }

    [JsonPropertyName("valor")]
    public double Valor { get; set; }
}