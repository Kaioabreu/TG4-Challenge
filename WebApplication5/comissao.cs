public class comissao
{
    public comissao(int vend, int month, double value)
    {
        vendedor = vend;
        mes = month;
        valor = value;
        vendas = 1;
    }
    public void sum(double n)
    {
        valor += n;
    }
    public void AddVenda()
    {
        vendas++;
    }
    public int vendedor { get; set; }
    public int mes { get; set; }
    public double valor { get; set; }
    public int vendas { get; set; }
}
