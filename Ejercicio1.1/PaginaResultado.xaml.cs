namespace Ejercicio1._1;

public partial class PaginaResultado : ContentPage
{
    public PaginaResultado(double resultado)
    {
        InitializeComponent();
        EtiquetaResultado.Text = $"Resultado: {resultado}";
    }
}