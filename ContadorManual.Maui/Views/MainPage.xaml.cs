namespace ContadorManual.Maui.Views;
using ContadorManual.Maui.Models;

public partial class MainPage : ContentPage
{
	private Contador _contador;
	public MainPage()
	{
		InitializeComponent();
		_contador = new Contador();
        ConteoLabel.Text = _contador.Conteo.ToString(); //Convertimos lo numerico en texto
    }

    private void OnContarButtonClicked(object sender, EventArgs e)
    {
		_contador.Contar();
		ConteoLabel.Text=_contador.Conteo.ToString();
    }

    private void OnReiniciarButtonClicked(object sender, EventArgs e)
    {
		_contador.Reiniciar();
		ConteoLabel.Text=_contador.Conteo.ToString() ;
    }
}