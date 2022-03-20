public class TotPedidos
{
    public int[] metas = new[] { 5, 3, 2, 2, 5, 60, 2, 4, 4, 7, 2 };
    public TotPedidos()
    {
        pedidos = new List<Pedido>();
    }
    public List<Pedido> pedidos { get; set; }
}

