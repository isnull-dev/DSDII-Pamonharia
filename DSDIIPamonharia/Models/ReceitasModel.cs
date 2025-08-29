public class ReceitasModel
{
    public int Id { get; set; }
    public int IdProduto { get; set; }
    public string NomeProduto { get; set; }
    public string Descricao { get; set; }
    public int IdIngrediente { get; set; }
    public string NomeIngrediente { get; set; }
    public decimal Quantidade { get; set; }
    public decimal Custo { get; set; }
    public byte[] Imagem { get; set; }
}
