
public class ProdutosModel 
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public string Unidade { get; set; }
    public decimal Quantidade_Estoque { get; set; }
    public decimal Custo { get; set; }
    public decimal Preco { get; set; }
    public byte[] Imagem { get; set; }
}