namespace Ejercicio1._1;

public partial class PaginaPrincipal : ContentPage
{
    OperacionesMatematicas operaciones = new OperacionesMatematicas();

    public PaginaPrincipal()
    {
        InitializeComponent();
    }

    private async void BotonSumarPresionado(object sender, EventArgs e)
    {
        double num1 = double.Parse(EntradaPrimerNumero.Text);
        double num2 = double.Parse(EntradaSegundoNumero.Text);
        double resultado = operaciones.Sumar(num1, num2);

        await Navigation.PushAsync(new PaginaResultado(resultado));
    }

    private async void BotonRestarPresionado(object sender, EventArgs e)
    {
        double num1 = double.Parse(EntradaPrimerNumero.Text);
        double num2 = double.Parse(EntradaSegundoNumero.Text);
        double resultado = operaciones.Restar(num1, num2);

        await Navigation.PushAsync(new PaginaResultado(resultado));
    }

    private async void BotonMultiplicarPresionado(object sender, EventArgs e)
    {
        double num1 = double.Parse(EntradaPrimerNumero.Text);
        double num2 = double.Parse(EntradaSegundoNumero.Text);
        double resultado = operaciones.Multiplicar(num1, num2);

        await Navigation.PushAsync(new PaginaResultado(resultado));
    }

    private async void BotonDividirPresionado(object sender, EventArgs e)
    {
        double num1 = double.Parse(EntradaPrimerNumero.Text);
        double num2 = double.Parse(EntradaSegundoNumero.Text);
        double resultado;

        try
        {
            resultado = operaciones.Dividir(num1, num2);
            await Navigation.PushAsync(new PaginaResultado(resultado));
        }
        catch (DivideByZeroException ex)
        {
            await DisplayAlert("Error", ex.Message, "OK");
        }
    }
}