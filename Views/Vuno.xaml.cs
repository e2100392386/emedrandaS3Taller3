namespace emedrandaS3Taller3.Views;

public partial class Vuno : ContentPage
{
    string usuarioglobal = "a";
    string claveglobal = "";
    public Vuno()
    {
        InitializeComponent();
    }
    public Vuno(string usuarioacceso, string clavetxt)
	{
		InitializeComponent();
        usuarioglobal = usuarioacceso;
        claveglobal = clavetxt;
	}

    private void btnAbrir_Clicked(object sender, EventArgs e)
    {
		try
		{
            
			
            string usuario = txtusuario.Text;
			string clave = txtclave.Text;

            if (usuarioglobal == usuario && clave == claveglobal)
			{
				Navigation.PushAsync(new Vdos(usuario, clave));
			}
            else
            {
				DisplayAlert("Error", "El usuario y clave es incorrecto", "ok");
            }

		}
		catch (Exception ex) 
		{
			Console.WriteLine(ex.Message);
		}
    }

    private void btnRegistro_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Vtres());
    }
}