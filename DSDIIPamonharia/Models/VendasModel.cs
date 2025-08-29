using System;

public class VendasModel
{
    public int Id_venda { get; set; }
    public DateTime DateTime { get; set; }
    public decimal Total { get; set; }
    public int Id_item {  get; set; }
    public int Id_produto { get; set; }
    public string Nome { get; set; }
    public decimal Quantidade { get; set; }
    public decimal Preco {  get; set; }
}