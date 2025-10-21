namespace emedrandaS3Taller3.Views;

public partial class Vdos : ContentPage
{
	public Vdos(string dato1, string dato2)
	{
        
		InitializeComponent();
        lbldato1.Text = "El dato uno es: " + dato1;
        lbldato2.Text = "El dato uno es: " + dato2;
    }
}