class Calculos
{
    private string computador;
    private string cliente;
    private string servico;
    private string pagamento;
    private double dinheiro;

   public Calculos(string computador, string cliente, string servico, string pagamento)
   {
        this.computador = computador;
        this.cliente = cliente;
        this.servico = servico;
        this.pagamento = pagamento;
   }

    public double Dinheiro(double dinheiro)
    {
        return dinheiro % 20;
    }

    public double
}
