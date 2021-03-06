using System.Text.Json;
using System.Collections;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
static double Commission(double value)
{
    double bonus;
    if (value <= 300) bonus = 0.01;
    else if (value <= 1000) bonus = 0.03;
    else bonus = 0.05;
    return bonus*value;
}

app.MapPost("/api/calcula-comissao", (TotPedidos input) =>
{
    TotComissao Jvalue = new TotComissao();
    foreach (var item in input.pedidos)
    {
        bool check = true;
        int month = Int32.Parse(item.data.Substring(5, 2));
        double value = item.valor;
        int vendedor = item.vendedor;
        foreach(var i in Jvalue.comissoes)
        {
            if (i.mes == month && i.vendedor == vendedor)
            {
                check = false;
                i.sum(Commission(value));
                i.AddVenda();
                if (i.vendas == input.metas[month - 1])
                {
                    i.sum(value * 0.03);
                }
            }

        }
        if (check)
        {
            Comissao temp = new Comissao(vendedor, month, Commission(value));
            Jvalue.add(temp);
        }

    }
    TotComissaoSemVenda output = new TotComissaoSemVenda();
    output.convert(Jvalue);
    return output;
});

app.Run();





