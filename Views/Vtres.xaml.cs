namespace emedrandaS3Taller3.Views;

public partial class Vtres : ContentPage
{
	public Vtres()
	{
		InitializeComponent();
	}

    private void btnsalir_Clicked(object sender, EventArgs e)
    {
		try
		{
			string usuario = txtusuariov3.Text;
			string clave = txtclavev3.Text;
			Navigation.PushAsync(new Vuno(usuario, clave));

        }
		catch (Exception ex) { 
			Console.WriteLine(ex.ToString());
		}
    }
}