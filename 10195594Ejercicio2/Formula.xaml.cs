namespace _10195594Ejercicio2;

public partial class Formula : ContentPage
{
	public Formula()
	{
		InitializeComponent();
	}
    /// <summary>
    ///  El evento clicked del bot�n realiza la acci�n de desarrollar una f�rmula matematica, donde se solicitan
    ///  dos n�meros enteros, y los almacenamos en las variables A y B, mediante un entry mostramos el resultado.
    ///  Con un If capturamos errores, en este caso se muestra una ventana de alerta si el usuario ingresa letras o car�cteres.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Button_Clicked(object sender, EventArgs e)
    {
        int A, B, Respuesta;
        if (!string.IsNullOrEmpty(DatoA.Text) && !string.IsNullOrEmpty(DatoB.Text))
        {
            if (int.TryParse(DatoA.Text, out A) && int.TryParse(DatoB.Text, out B))
            {
                A = Convert.ToInt32(DatoA.Text);
                B = Convert.ToInt32(DatoB.Text);
                Respuesta = (A + B) ^ 2 / 2;
                Resultado.Text = Respuesta.ToString();
            }
            else
            {
                DisplayAlert("ERROR", "Introduce N�mero, no letras ni otro tipo de car�cteres", "OK");
            }
        }
    }
}