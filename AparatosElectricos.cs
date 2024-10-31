
    public class AparatosElectricos
    {
    private string Nombre {  get; set; }
    private double Volteos { get; set; }

    private int HorasUso { get; set; }
    private double ConsumoTotal {  get; set; }

    public AparatosElectricos(string nombre, double volteos, int horasuso, double consumototal)
    {

        this.Nombre = nombre;
        this.Volteos = volteos;
        this.HorasUso = horasuso;
        this.ConsumoTotal = consumototal; ;
    }

    public double CalcularConsumoMensual(double volteos, int horasuso)
    {
        return 1;
    }
    public double CalcularConsumoDiario(double volteos, int horasuso)
    {
        return 1;
    }


}

