using System;

public class TotComissaoSemVenda
{
    public TotComissaoSemVenda()
    {
        comissoes = new List<ComissaoSemVenda>();
    }
    public List<ComissaoSemVenda> comissoes { get; set; }

    public void convert(TotComissao t)
    {
        foreach(var item in t.comissoes)
        {
            ComissaoSemVenda temp = new ComissaoSemVenda(item.vendedor, item.mes, item.valor);
            comissoes.Add(temp);
        }
    }
}