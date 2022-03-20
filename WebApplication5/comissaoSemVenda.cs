using System;

public class ComissaoSemVenda
{
    public ComissaoSemVenda(int vend, int month, double value)
    {
        vendedor = vend;
        mes = month;
        valor = String.Format("{0:0.00}",value);
    }
    public int vendedor { get; set; }
    public int mes { get; set; }
    public string valor { get; set; }
}

