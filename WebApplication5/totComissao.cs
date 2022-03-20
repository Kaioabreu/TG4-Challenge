using System;

public class TotComissao
{
    public TotComissao()
    {
        comissoes = new List<Comissao>();
    }
    public List<Comissao> comissoes { get; set; }

    public void add(Comissao c)
    {
        comissoes.Add(c);
    }
}
