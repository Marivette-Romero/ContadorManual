namespace ContadorManual.Maui.Views;
using ContadorManual.Maui.Models;

//22/09/2026: Actualizacion a enlace de datos a un objeto de datos.
public partial class MainPage : ContentPage
{
	private Contador _contador;
	public MainPage()
	{
		InitializeComponent();
		_contador = new Contador();
		// ConteoLabel.Text = _contador.Conteo.ToString(); //Convertimos lo numerico en texto
		BindingContext = _contador; //Agregamos esto
    }

    private void OnContarButtonClicked(object sender, EventArgs e)
    {
		_contador.Contar();
		//ConteoLabel.Text=_contador.Conteo.ToString();
    }

    private void OnReiniciarButtonClicked(object sender, EventArgs e)
    {
		_contador.Reiniciar();
		//ConteoLabel.Text=_contador.Conteo.ToString() ;
    }

	/*23/09/2026 Nuevo controlador de eventos
    private void OnIncrementoStepperValueChanged(object sender, ValueChangedEventArgs e)
    {
		_contador.Incremento = (int)IncrementoStepper.Value;
    }*/
}