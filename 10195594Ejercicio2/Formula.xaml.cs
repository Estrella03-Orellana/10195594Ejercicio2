namespace _10195594Ejercicio2;

public partial class Formula : ContentPage
{
	public Formula()
	{
		InitializeComponent();
	}
    /// <summary>
    ///  El evento clicked del botón realiza la acción de desarrollar una fórmula matematica, donde se solicitan
    ///  dos números enteros, y los almacenamos en las variables A y B, mediante un entry mostramos el resultado.
    ///  Con un If capturamos errores, en este caso se muestra una ventana de alerta si el usuario ingresa letras o carácteres.
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
                DisplayAlert("ERROR", "Introduce Número, no letras ni otro tipo de carácteres", "OK");
            }
        }
    }
}