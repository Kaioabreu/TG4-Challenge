using System;

public class totComissao
{
    public totComissao()
    {
        comissoes = new List<comissao>();
    }
    public List<comissao> comissoes { get; set; }

    public void add(comissao c)
    {
        comissoes.Add(c);
    }
}
